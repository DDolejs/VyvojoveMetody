using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VyvojoveMetody.DependencyInjection.Interfaces;

namespace VyvojoveMetody.DependencyInjection.Validators
{
    public class BirthDateValidator : IDateTimeValidator
    {   public bool IsValid(DateTime dt) 
        {
            if (dt < DateTime.Today)
            {
                return true;
            }
            else return false;
        }
    }
}
