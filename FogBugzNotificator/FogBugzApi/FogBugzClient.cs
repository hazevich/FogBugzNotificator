using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FogBugzApi.Helpers;
using System.Xml;
using FogBugzApi.Models;

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
            XmlDocument xmlDoc = requestHelper.GetResponseXml(_fbApiCheckUrl, null);

            if (xmlDoc == null)
                throw new NullReferenceException("Couldn't retrieve api information");

            string apiUrl = xmlConverter.XmlToFogBugzApiUrl(xmlDoc);

            _fbApiUrl = _fbUrl.AppendUrlResource(apiUrl);
        }

        public FogBugzClient(string fbUrl)
        {
            if (String.IsNullOrEmpty(fbUrl))
                throw new InvalidOperationException("fbUrl can't be null or empty");

            _fbUrl = fbUrl;
            _fbApiCheckUrl = _fbUrl.AppendUrlResource("api.xml");

            GetFBApiUrl();
        }

        public void Auth(string login, string password)
        {
            Dictionary<string, string> args = new Dictionary<string, string>
            {
                { "cmd", "logon" },
                { "login", login },
                { "password", password }
            };

            XmlDocument xml = requestHelper.GetResponseXml(_fbApiUrl, args);

            _token = xmlConverter.XmlToFogBugzToken(xml);

            _authorized = true;
        }

        public List<FogBugzCase> GetCasesAssignedToCurrentUser()
        {
            if (!_authorized)
                throw new InvalidOperationException("Not authorized");

            Dictionary<string, string> args = new Dictionary<string, string>
            {
                { "cmd", "search" },
                { "token", _token },
                { "q", "assignedto:me" },
                { "cols", "sTitle,sStatus,sPriority,ixPriority" }
            };

            XmlDocument xml = requestHelper.GetResponseXml(_fbApiUrl, args);

            List<FogBugzCase> fbCases = xmlConverter.XmlToFugBugzCases(xml);

            return fbCases;
        }

        public void LogOff()
        {
            if(_authorized)
            {
                Dictionary<string, string> args = new Dictionary<string, string>
                {
                    { "cmd", "logoff" },
                    { "token", _token }
                };

                requestHelper.GetResponseXml(_fbApiUrl, args);
            }
        }
    }
}
