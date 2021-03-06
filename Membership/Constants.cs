﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Membership
{
    public static class Constants
    {
        public const string Error_AuthChallengeNeeded = "Caller needs to authenticate.";

        public const string ScopeDirectoryAccessAsUserAll = "https://graph.microsoft.com/Directory.AccessAsUser.All";
        public const string ScopeUserReadWrite = "https://graph.microsoft.com/User.ReadWrite";

        public const string MembersGroupId = "940ac926-845c-489b-a270-eb961ca4ca8f";
    }
}
