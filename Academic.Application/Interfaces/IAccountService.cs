﻿using Academic.Application.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Application.Interfaces
{
    public interface IAccountService :IService <ApplicationUserDTO> 
    {
        public Task<AccountResponseLoginDTO> Login(AccountLoginDTO dto);
    }
}