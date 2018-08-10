using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlexAspNetCoreMvc.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Sandbox.Data;
    using Sandbox.Interfaces;

    public class AccountController: Controller

    {

        private IAccountRepository _accountRepository = new AccountRepository();
        public IActionResult Index()
        {
            //show list of accounts

            var vm = new AccountsViewModel()
            {
                Title = "Accounts",
                Description = "All the accounts I know",
                Accounts = _accountRepository.GetAll()

            };


            return View(vm);

        }


    }
}
