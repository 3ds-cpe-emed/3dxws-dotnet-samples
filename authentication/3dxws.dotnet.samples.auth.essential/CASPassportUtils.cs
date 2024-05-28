using System.Net.Http.Json;
using System.Net;
using System.Web;

using ds.authentication.model;

namespace ds.authentication
{
   // Condenses and strips down some of the ds.authentication sdk essential classes and functionality for CAS authentication
   internal class CASPassportUtils
   {
      const string LOGIN_WS        = "/login";
      const string LOGIN           = "login";

      const string CAS_TICKET_NAME = "CASTGC";

      private Uri? m_passportHost        = null;
      private string? m_passportService  = null;
      private Uri? m_passportUri         = null;

      HttpClient? m_client               = null;
      HttpClientHandler? m_clientHandler = null;

      public CASPassportUtils(string passportUrl)
      {
         if (!passportUrl.EndsWith(@"/"))
         {
            passportUrl += @"/";
         }

         m_passportUri = new Uri(passportUrl);

         m_passportService = m_passportUri.LocalPath;

         string passportHost = string.Format("{0}://{1}", m_passportUri.Scheme, m_passportUri.Host); ;

         if (!m_passportUri.IsDefaultPort)
         {
            passportHost += $":{m_passportUri.Port}";
         }

         m_passportHost = new Uri(passportHost);

         m_clientHandler = new()
         {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = true
         };

         m_client = new(m_clientHandler)
         {
            BaseAddress = PassportHost
         };

         return;
      }
      
      public Uri PassportHost => m_passportHost!;

      public Uri PassportUri => m_passportUri!;

      public HttpClient Client => m_client!;
      public HttpClientHandler ClientHandler => m_clientHandler!;

      public string GetEndpointURL(string _endpoint)
      {
         if (m_passportService!.EndsWith(@"/") && _endpoint.StartsWith(@"/"))
         {
            _endpoint = _endpoint.Substring(1, _endpoint.Length - 1);
         }

         return string.Format("{0}{1}", m_passportService, _endpoint);
      }

      public bool IsCookieAuthenticated()
      {
         //Check CASTGC cookie exists

         //on premise
         CookieCollection cookies = ClientHandler.CookieContainer.GetCookies(this.PassportUri);

         foreach (Cookie cookie in cookies)
         {
            if (cookie.Name == CAS_TICKET_NAME)
            {
               return true;
            }
         }

         //Cloud
         cookies = ClientHandler.CookieContainer.GetCookies(Client.BaseAddress!);

         foreach (Cookie cookie in cookies)
         {
            if (cookie.Name == CAS_TICKET_NAME)
            {
               return true;
            }
         }

         return false;

      }

      public async Task<string> GetCASLoginTicket()
      {
         //Step 1 - Request login ticket
         string loginTicket = GetEndpointURL(LOGIN_WS);
         loginTicket += "?action=get_auth_params";

         HttpRequestMessage getLoginTicketRequest = new HttpRequestMessage(HttpMethod.Get, loginTicket);

         HttpResponseMessage getLoginTicketResponse = await Client.SendAsync(getLoginTicketRequest);

         if (!getLoginTicketResponse.IsSuccessStatusCode)
         {
            //TODO: handle according to established exception policy
            throw new Exception(await getLoginTicketResponse.Content.ReadAsStringAsync());
         }

         //Handle ticket login response
         TicketInfo? loginTicketInfo = await HttpContentJsonExtensions.ReadFromJsonAsync<TicketInfo>(getLoginTicketResponse.Content);

         if ((loginTicketInfo != null) && (loginTicketInfo.response != LOGIN))
         {
            //handle according to established exception policy
            throw new Exception(await getLoginTicketResponse.Content.ReadAsStringAsync());
         };

         return loginTicketInfo!.lt!;
      }

      public async Task<bool> PostCASLoginWithRedirection(string username, string password, bool rememberMe, string lt, string redirUrl)
      {
         //Build the login request
         var nvc = new List<KeyValuePair<string, string>>();

         nvc.Add(new KeyValuePair<string, string>("lt", lt));
         nvc.Add(new KeyValuePair<string, string>("username", username));
         nvc.Add(new KeyValuePair<string, string>("password", password));
         nvc.Add(new KeyValuePair<string, string>("rememberMe", rememberMe.ToString()));

         string url = $"{this.GetEndpointURL(LOGIN_WS)}?service={HttpUtility.UrlEncode(redirUrl)}";

         HttpRequestMessage loginRequest = new(HttpMethod.Post, url)
         {
            Content = new FormUrlEncodedContent(nvc)
         };

         HttpResponseMessage loginRequestResponse = await Client.SendAsync(loginRequest);

         if (!loginRequestResponse.IsSuccessStatusCode)
         {
            //handle according to established exception policy
            throw new Exception(await loginRequestResponse.Content.ReadAsStringAsync());
         }

         return this.IsCookieAuthenticated();
      }
   }
}
