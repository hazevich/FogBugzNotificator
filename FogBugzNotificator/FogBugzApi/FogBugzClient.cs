using FogBugzApi.Helpers;
using FogBugzApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace FogBugzApi
{
    public class FogBugzClient : IFogBugzClient
    {
        private string _token;
        private bool _authorized = false;
        private string _fbUrl;
        private string _fbApiUrl;
        private string _fbApiCheckUrl;
        private RequestHelper requestHelper = new RequestHelper();
        private XmlConverter xmlConverter = new XmlConverter();

        private void GetFBApiUrl()
        {
            XmlDocument xmlDoc = requestHelper.GetResponseXml(_fbApiCheckUrl);

            if (xmlDoc == null)
                throw new NullReferenceException(string.Format("Couldn't retrieve api information - {0}", _fbApiCheckUrl));

            string apiUrl = xmlConverter.XmlToFogBugzApiUrl(xmlDoc);

            _fbApiUrl = _fbUrl.AppendUrlResource(apiUrl);
            Debug.WriteLine(_fbApiUrl);
        }

        public FogBugzClient(string fbUrl)
        {
            if (String.IsNullOrEmpty(fbUrl))
                throw new InvalidOperationException("fbUrl can't be null or empty");

            _fbUrl = fbUrl;
            _fbApiCheckUrl = _fbUrl.AppendUrlResource("api.xml");

            GetFBApiUrl();
        }

        public bool Auth(string login, string password)
        {
            var args = new Dictionary<string, string>
            {
                { "cmd", "logon" },
                { "email", login },
                { "password", password }
            };

            XmlDocument xml = requestHelper.GetResponseXml(_fbApiUrl, args, "get");

            _token = xmlConverter.XmlToFogBugzToken(xml);

            if(_token != null)
                _authorized = true;

            return _authorized;    
        }

        public List<FogBugzCase> GetCasesAssignedToCurrentUser()
        {
            if (!_authorized)
                throw new InvalidOperationException("Not authorized");

            var args = new Dictionary<string, string>
            {
                { "token", _token },
                { "cmd", "search" },
                { "q", "assignedto:me" },
                { "cols", "sTitle,sStatus,sPriority,ixPriority" }
            };

            XmlDocument xml = requestHelper.GetResponseXml(_fbApiUrl, args, "post");

            List<FogBugzCase> fbCases = xmlConverter.XmlToFugBugzCases(xml);

            return fbCases;
        }

        public void LogOff()
        {
            if(_authorized)
            {
                var args = new Dictionary<string, string>
                {
                    { "cmd", "logoff" },
                    { "token", _token }
                };

                requestHelper.GetResponseXml(_fbApiUrl, args, "post");
            }
        }
    }
}
