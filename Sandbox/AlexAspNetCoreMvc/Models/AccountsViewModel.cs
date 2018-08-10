using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlexAspNetCoreMvc.Models
{
    using Sandbox.Domain;

    public class AccountsViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public IEnumerable<Account> Accounts { get; set; }
    }
}
