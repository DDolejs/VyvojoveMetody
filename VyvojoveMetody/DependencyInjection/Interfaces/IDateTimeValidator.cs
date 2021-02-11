using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyvojoveMetody.DependencyInjection.Interfaces
{
    public interface IDateTimeValidator
    {
        bool IsValid(DateTime dt);
    }
}
