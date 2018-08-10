using System;

namespace Sandbox.Interfaces
{
    using Sandbox.Domain;
    using System.Collections.Generic;

    public interface IAccountRepository
    {
         IEnumerable<Account> GetAll();
    }
}

