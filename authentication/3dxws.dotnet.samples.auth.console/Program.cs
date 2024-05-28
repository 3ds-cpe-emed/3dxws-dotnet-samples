// See https://aka.ms/new-console-template for more information
using ds.authentication;
using ds.authentication.redirection;
using ds.enovia.model;

const string DS3DXWS_AUTH_USERNAME = "DS3DXWS_AUTH_USERNAME";
const string DS3DXWS_AUTH_PASSWORD = "DS3DXWS_AUTH_PASSWORD";
const string DS3DXWS_AUTH_PASSPORT = "DS3DXWS_AUTH_PASSPORT";
const string DS3DXWS_AUTH_ENOVIA = "DS3DXWS_AUTH_ENOVIA";
const string DS3DXWS_AUTH_TENANT = "DS3DXWS_AUTH_TENANT";
//const string SECURITY_CONTEXT = "VPLMProjectLeader.Company Name.AAA27 Personal";


string? m_username = string.Empty;
string? m_password = string.Empty;
string? m_passportUrl = string.Empty;
string? m_enoviaUrl = string.Empty;
string? m_tenant = string.Empty;

UserInfo m_userInfo = null;

async Task<IPassportAuthentication?> Authenticate()
{
   UserPassport passport = new UserPassport(m_passportUrl);

   UserInfoRedirection userInfoRedirection = new UserInfoRedirection(m_enoviaUrl, m_tenant)
   {
      Current = true,
      IncludeCollaborativeSpaces = true,
      IncludePreferredCredentials = true
   };

   try
   {
      m_userInfo = await passport.CASLoginWithRedirection<UserInfo>(m_username, m_password, false, userInfoRedirection);
   }
   catch
   { }

   if (!passport.IsCookieAuthenticated) return null;

   return passport;
}

void Setup()
{
   // e.g. AAA27
   m_username = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_USERNAME, EnvironmentVariableTarget.User);

   // e.g. your password
   m_password = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_PASSWORD, EnvironmentVariableTarget.User);

   // e.g. https://eu1-ds-iam.3dexperience.3ds.com/3DPassport
   m_passportUrl = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_PASSPORT, EnvironmentVariableTarget.User);

   // e.g. https://r1132100982379-eu1-space.3dexperience.3ds.com/enovia (your 3DSpace tenant uri)
   m_enoviaUrl = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_ENOVIA, EnvironmentVariableTarget.User);

   // e.g. R1132100982379
   m_tenant = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_TENANT, EnvironmentVariableTarget.User);
}

Console.WriteLine("3DEXPERIENCE Authentication Sample 1");

Setup();

IPassportAuthentication? passportAuthentication = await Authenticate();

if (passportAuthentication == null)
{
   Console.WriteLine("Error authenticating");
}
else {
   Console.WriteLine("Authentication ok");
}