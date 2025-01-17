﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Sahra.MutualFund.IdentityAdmin.Core.Core.Scope
{
    public class ScopeSecretValue: BaseScopeValue
    {
        public string Description { get; set; }
        public DateTime? Expiration { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public virtual string Value { get; set; }
    }
}