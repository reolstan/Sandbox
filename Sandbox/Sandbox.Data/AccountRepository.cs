using Sandbox.Interfaces;
using System;

namespace Sandbox.Data
{
    using System.Collections.Generic;
    using Domain;

    public class AccountRepository: IAccountRepository
    {
        public IEnumerable<Account> GetAll()
        {
            //dummy data

            var accounts = new List<Account>();
            accounts.Add(new Account()
            {
                FirstName = "Fred",
                MiddleName = "Percival",
                LastName = "Smith",
                Age=33
            });
            accounts.Add(new Account()
            {
                FirstName = "Gandalf",
                MiddleName = "The",
                LastName = "Grey",
                Age=99
            });
            accounts.Add(new Account()
            {
                FirstName = "George",
                MiddleName = "S.",
                LastName = "Patton",
                Age=50
            });



            return accounts;


        }
    }
}
