﻿using Account.Domain.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Domain.AccountAggregates
{
    public interface IAccountRepository : IRepository<Account>
    {
    }
}
