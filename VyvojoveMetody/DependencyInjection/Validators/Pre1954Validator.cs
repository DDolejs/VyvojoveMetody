using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VyvojoveMetody.DependencyInjection.Interfaces;
using System.Text.RegularExpressions;

namespace VyvojoveMetody.DependencyInjection.Validators
{
    public class Pre1954Validator : IStringValidator
    {
        public bool IsValid(string s)
        {
            if (Regex.IsMatch(s, @"[0-9]{6}/[0-9]{3,4}"))
            {
                return true;
            }
            else return false;

        }
    }
}