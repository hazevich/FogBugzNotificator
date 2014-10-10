using FogBugzApi.Models;
using System.Collections.Generic;

namespace FogBugzApi
{
    public interface IFogBugzClient
    {
        bool Auth(string login, string password);
        List<FogBugzCase> GetCasesAssignedToCurrentUser();
        void LogOff();
    }
}
