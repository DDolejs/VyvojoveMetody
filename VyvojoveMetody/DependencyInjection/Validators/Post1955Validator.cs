using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using VyvojoveMetody.DependencyInjection.Interfaces;

namespace VyvojoveMetody.DependencyInjection.Validators
{
    public class Post1955Validator : IStringValidator
    {

        public bool IsValid(string s)
        {
            if (Regex.IsMatch(s, @"[0-9]{6}/[0-9]{4}"))
            {
                return true;
            }
            else return false;
        }

    }
}
