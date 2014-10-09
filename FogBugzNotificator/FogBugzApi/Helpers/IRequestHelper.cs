using FogBugzApi.Models;

namespace FogBugzApi.Helpers
{
    interface IRequestHelper
    {
        string GetResponse(string url, FogBugzCase data);
    }
}
