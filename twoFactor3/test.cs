﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace twoFactor3 {
    public class test : IIdentityValidator<string> {


        public Task<IdentityResult> ValidateAsync(string item) {
            throw new NotImplementedException();
        }
    }
}