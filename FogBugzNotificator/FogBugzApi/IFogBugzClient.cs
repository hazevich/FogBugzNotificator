using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FogBugzApi.Models;

namespace FogBugzApi
{
    public interface IFogBugzClient
    {
        bool Auth(string login, string password);
        List<FogBugzCase> GetCasesAssignedToCurrentUser();
        void LogOff();
    }
}
