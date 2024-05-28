// See https://aka.ms/new-console-template for more information
using ds.authentication;

const string DS3DXWS_AUTH_USERNAME = "DS3DXWS_AUTH_USERNAME";
const string DS3DXWS_AUTH_PASSWORD = "DS3DXWS_AUTH_PASSWORD";
const string DS3DXWS_AUTH_PASSPORT = "DS3DXWS_AUTH_PASSPORT";
const string DS3DXWS_AUTH_ENOVIA = "DS3DXWS_AUTH_ENOVIA";
const string DS3DXWS_AUTH_TENANT = "DS3DXWS_AUTH_TENANT";


string? m_username = string.Empty;
string? m_password = string.Empty;
string? m_passportUrl = string.Empty;
string? m_enoviaUrl = string.Empty;
string? m_tenant = string.Empty;


async Task<bool> Authenticate()
{
   CASPassportUtils loginUtils = new(m_passportUrl);

   string lt = await loginUtils.GetCASLoginTicket();

   string enoviaUrl = m_enoviaUrl;

   if (!enoviaUrl.EndsWith("/")) {
      enoviaUrl += "/";
   }
   string redirUrl = enoviaUrl + "resources/modeler/pno/person?current=true&select=collabspaces&tenant=" + m_tenant;

   return await loginUtils.PostCASLoginWithRedirection(m_username, m_password, false, lt, redirUrl);

}

void Setup()
{
   // e.g. AAA27
   m_username = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_USERNAME, EnvironmentVariableTarget.User);

   // e.g. your password
   m_password = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_PASSWORD, EnvironmentVariableTarget.User);

   // e.g. https://eu1-ds-iam.3dexperience.3ds.com/3DPassport
   m_passportUrl = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_PASSPORT, EnvironmentVariableTarget.User);

   // e.g. https://r1132100982379-eu1-space.3dexperience.3ds.com/enovia
   m_enoviaUrl = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_ENOVIA, EnvironmentVariableTarget.User);

   // e.g. R1132100982379
   m_tenant = Environment.GetEnvironmentVariable(DS3DXWS_AUTH_TENANT, EnvironmentVariableTarget.User);
}

Console.WriteLine("3DEXPERIENCE Authentication Sample 2 (essential)");

Setup();

if (await Authenticate())
{
   Console.WriteLine("Authentication OK");
}
else
{
   Console.WriteLine("Error authenticating");
}
