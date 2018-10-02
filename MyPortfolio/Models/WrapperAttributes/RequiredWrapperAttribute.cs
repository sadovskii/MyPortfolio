using MyPortfolio.Resource;
using MyPortfolio.Resource.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models.WrapperAttributes
{
    public class RequiredWrapperAttribute : RequiredAttribute
    {
        private readonly string element;

        private const string emailElement = "Email";
        private const string PasswordElement = "Password";
        private const string PasswordConfirmElement = "PasswordConfirm";

        public RequiredWrapperAttribute(string element)
        {
            this.element = element;
        }

        public override string FormatErrorMessage(string name)
        {
            switch (element)
            {
                case "Element":
                    {
                        ErrorMessage = Common.valMustField;
                        break;
                    }
                //case PasswordElement:
                //    {
                //        ErrorMessage = Common.valOnlyLatinNumber;
                //        break;
                //    }
                //case PasswordConfirmElement:
                //    {
                //        ErrorMessage = Password.valPasswordConfirm
                //    }
            }
            return base.FormatErrorMessage(name);
        }


    }
}
