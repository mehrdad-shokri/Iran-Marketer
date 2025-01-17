﻿using System.Collections.Generic;
using Bargozideh.Framework.Infra.Exception;

namespace Bargozideh.Framework.Infra.Validation
{
    public class BusinessRuleException : AppException
    {
        /// <summary>
        /// The exception code 
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// The parameters included with exception
        /// </summary>
        public IEnumerable<object> Parameters { get; set; }

        /// <summary>
        /// The name of the property.
        /// </summary>
        public string MemberName { get; private set; }

        /// <summary>
        /// The error message
        /// </summary>
        public string ErrorMessage { get; private set; }

        public BusinessRuleException(string memberName, string errorMessage)
            : base(errorMessage, -1)
        {
            MemberName = memberName;
            ErrorMessage = errorMessage;
        }

        public BusinessRuleException(string memberName, string errorMessage, System.Exception innerException)
            : base(errorMessage, innerException, -1)
        {
            MemberName = memberName;
            ErrorMessage = errorMessage;
        }
    }
}
