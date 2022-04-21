using ds.authentication;
using ds.enovia.document.service;
using ds.enovia.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3dxws.dotnet.samples.console.attachdoc
{
    public class ServiceConnections
    {
        private static DocumentService m_documentService = null;

        public static DocumentService Documents { get { return m_documentService; } }

        public static void InitializeServices(string _enoviaUrl, IPassportAuthentication _passport, string _securityContext, string _tenant)
        {
            m_documentService = (DocumentService)InitializeEnoviaService(new DocumentService(_enoviaUrl, _passport), _securityContext, _tenant);
        }

        private static EnoviaBaseService InitializeEnoviaService(EnoviaBaseService _instance, string _securityContext, string _tenant)
        {
            _instance.SecurityContext = _securityContext;
            _instance.Tenant = _tenant;

            return _instance;
        }
    }
}
