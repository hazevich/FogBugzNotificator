using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace FogBugzApi.Helpers
{
    public class RequestHelper : IRequestHelper
    {
        public XmlDocument GetResponseXml(string baseUrl, Dictionary<string, string> args, string method)
        {
            XmlDocument responseXml = new XmlDocument();
            string argsString = args.ToArgsString();

            if (method.ToLower().Equals("post"))
                responseXml = PostRequest(baseUrl, argsString);
            else
                responseXml = GetRequest(baseUrl, argsString);
            
            return responseXml;
        }

        public XmlDocument GetResponseXml(string baseUrl)
        {
            XmlDocument responseXml = new XmlDocument();

            HttpWebRequest request = WebRequest.Create(baseUrl) as HttpWebRequest;

            try
            {
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                responseXml.Load(response.GetResponseStream());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return null;
            }

            return responseXml;
        }

        private XmlDocument GetRequest(string baseUrl, string stringArgs)
        {
            XmlDocument responseXml = new XmlDocument();

            HttpWebRequest request = WebRequest.Create(baseUrl + stringArgs) as HttpWebRequest;

            try
            {
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                responseXml.Load(response.GetResponseStream());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return null;
            }

            return responseXml;
        }

        private XmlDocument PostRequest(string baseUrl, string stringArgs)
        {
            XmlDocument responseXml = new XmlDocument();
            HttpWebRequest request = WebRequest.Create(baseUrl + stringArgs) as HttpWebRequest;

            request.Method = "POST";
            request.ContentType = "multipart/form-data";

            if (stringArgs != null)
            {
                byte[] data = Encoding.UTF8.GetBytes(stringArgs);

                request.ContentLength = data.Length;

                using (Stream s = request.GetRequestStream())
                {
                    s.Write(data, 0, data.Length);
                }
            }
            else
            {
                request.ContentLength = 0;
            }

            try
            {
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                responseXml.Load(response.GetResponseStream());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return null;
            }

            return responseXml;
        }
    }
}
