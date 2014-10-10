using System.Collections.Generic;
using System.Xml;

namespace FogBugzApi.Helpers
{
    interface IRequestHelper
    {
        XmlDocument GetResponseXml(string baseUrl, Dictionary<string, string> args, string method);
    }
}
