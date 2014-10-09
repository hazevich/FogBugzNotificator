using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FogBugzApi.Models;

namespace FogBugzApi
{
    interface IFogBugzClient
    {
        void Auth(string login, string password);
        List<FogBugzCase> GetCasesAssignedToCurrentUser();
        void LogOff();
    }
}
