//------------------------------------------------------------------------------------------------------------------------------------
// Copyright 2020 Dassault Systèmes - CPE EMED
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify,
// merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished
// to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS
// BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//------------------------------------------------------------------------------------------------------------------------------------

using ds.authentication;
using ds.delmia.dsmfg.service;
using ds.enovia.document.service;
using ds.enovia.dseng.service;
using ds.enovia.service;

namespace ds.emedcpe.samples
{
    public class ServiceConnections
    {
        private static EngineeringServices m_engineeringServices = null;
        private static DocumentService m_documentService = null;
        private static ManufacturingItemService m_manufacturingService = null;

        public static EngineeringServices Engineering { get { return m_engineeringServices; } }
        public static DocumentService Documents { get { return m_documentService; } }
        public static ManufacturingItemService ManufacturingItem { get { return m_manufacturingService; } }

        public static void InitializeServices(string _enoviaUrl, IPassportAuthentication _passport, string _securityContext,  string _tenant)
        {
            m_engineeringServices  = (EngineeringServices)InitializeEnoviaService(new EngineeringServices(_enoviaUrl, _passport), _securityContext, _tenant);
            m_manufacturingService = (ManufacturingItemService)InitializeEnoviaService(new ManufacturingItemService(_enoviaUrl, _passport), _securityContext, _tenant);
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