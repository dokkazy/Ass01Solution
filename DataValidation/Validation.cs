using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation
{
    public static class Validation
    {
        public static bool IsEmail(string Email)
        {
            bool result = false;

            var CheckEmail = new EmailAddressAttribute();
            result = CheckEmail.IsValid(Email);

            return result;
        }
    }
}
