using ds.authentication;
using ds.authentication.redirection;
using ds.enovia.model;
using Ookii.CommandLine;
using System;
using System.IO;
using System.Threading.Tasks;

namespace _3dxws.dotnet.samples.console.attachdoc
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // INPUT - Arguments through the command line

            CommandLineParser parser = new CommandLineParser(typeof(Input));

            Input input = (Input)parser.Parse(args);

            Console.WriteLine("input arguments parsed");

            // AUTHENTICATION / TENANT ARGS
            string _enoviaURL       = input.EnoviaUrl;
            string _passportURL     = input.PassportUrl;
            string _username        = input.Username;
            string _password        = input.Password;
            string _tenantId        = input.TenantId;
            
            bool _isCloud           = input.IsCloud;
            string _securityContext = input.SecurityContext;

            // DOCUMENT ARGS
            string _docTitle         = input.DocTitle;
            string _docDescription   = input.DocDescription;
            string _docParentId      = input.DocParentId;
            string _docFileLocalPath = input.DocFileLocalPath;

            // VALIDATE INPUT
            if (!File.Exists(_docFileLocalPath))
            {
                //TODO
            }

            // PROCESS

            // STEP 1 - Authentication
            DateTime startTime = DateTime.Now;

            UserPassport passport = new UserPassport(_passportURL);

            UserInfoRedirection userInfoRedirection =
                    _isCloud ? new UserInfoRedirection(_enoviaURL, _tenantId) : new UserInfoRedirection(_enoviaURL);

            userInfoRedirection.Current = true;
            userInfoRedirection.IncludeCollaborativeSpaces = true;
            userInfoRedirection.IncludePreferredCredentials = true;

            UserInfo userInfo = await passport.CASLoginWithRedirection<UserInfo>(_username, _password, false, userInfoRedirection);

            DateTime endTime = DateTime.Now;

            TimeSpan elapsedTime = endTime - startTime;

            Console.WriteLine (string.Format("Successfully logged in {0} in {1:0.0} secs", userInfo.name, elapsedTime.TotalSeconds));

            // STEP 2 - Attach Document

            ServiceConnections.InitializeServices(_enoviaURL, passport, _securityContext, _tenantId);

            await ServiceConnections.Documents.CreateDocumentAsAttachment(_docTitle, _docDescription, _docParentId, _docFileLocalPath);

            // OUTPUT
            // ...
        }
    }
}
