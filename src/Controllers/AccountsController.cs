using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;

namespace my_wallet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private static readonly Account[] accounts = new Account[] { 
               new Account { 
                   Name = "AM", 
                   Balance = new Money {
                       Currency = "USD", 
                       Value = 100  
                   }  
               },
               new Account { 
                   Name = "ITA", 
                   Balance = new Money {
                       Currency = "BRL", 
                       Value = 200  
                   }  
               }
        };

        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return accounts;
        }
    }
}
