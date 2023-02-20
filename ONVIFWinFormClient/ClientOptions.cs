using System.Collections.Generic;

namespace ONVIFWinFormClient
{
    public class ClientOptions
    {
        public class Account
        {
            public string IpAddress { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public Dictionary<string, Account> Accounts { get; set; } = new Dictionary<string, Account>();
    }
}