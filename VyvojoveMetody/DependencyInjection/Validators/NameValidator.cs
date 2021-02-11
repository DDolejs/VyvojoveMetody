using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VyvojoveMetody.DependencyInjection.Interfaces;

namespace VyvojoveMetody.DependencyInjection.Validators
{
   public class NameValidator : IStringValidator
    {
        public bool IsValid(string s) { return s.Length > 1; }
    }
}
