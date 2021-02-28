using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SL.Survey.Api.Contracts.V1
{
    public class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class Survey
        {
            public const string GetAll = Base + "/surveys";
            public const string GetQuestionsAnswers = Base + "/surveys/{id}";
        }

        public static class Identity
        {
            public const string Login = Base + "/identity/loging";
            public const string Register = Base + "/identity/register";
            public const string Refresh = Base + "/identity/refresh";
        }
    }
}
