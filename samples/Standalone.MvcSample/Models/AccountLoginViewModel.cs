﻿using System.Collections.Generic;

namespace Standalone.MvcSample.Models
{
    public class AccountLoginViewModel
    {
        public AccountLoginViewModel(IEnumerable<ExternalProvider> externalProviders, string returnUrl)
        {
            ExternalProviders = externalProviders;
            ReturnUrl = returnUrl;
        }

        public IEnumerable<ExternalProvider> ExternalProviders { get; }
        public string ReturnUrl { get; }
    }
}