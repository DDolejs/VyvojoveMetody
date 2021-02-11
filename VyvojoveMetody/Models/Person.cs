using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VyvojoveMetody.DependencyInjection.Validators;
using VyvojoveMetody.DependencyInjection.Interfaces;

namespace VyvojoveMetody.Models
{
    
        public class Person
        {
            public Person(IStringValidator namevalid, IStringValidator surnamevalid, IStringValidator bnumvalid, IDateTimeValidator bdatevalid)
            {
                NameValid = namevalid;
                SurnameValid = surnamevalid;
                BNumValid = bnumvalid;
                BDateValid = bdatevalid;
                
            }
            public bool FillInfo(string name, string surname, string bnum, DateTime bdate) 
            {
            bool nameOK = false; ;
            bool surnameOK = false; ;
            bool bnumOK = false; ;
            bool bdateOK = false;
            if (NameValid.IsValid(name))
            {
                this.Name = name;
                nameOK = true;
            }
            if (SurnameValid.IsValid(surname))
            {
                this.Surname = surname;
                surnameOK = true;
            }
            if (BNumValid.IsValid(bnum))
            {
                this.Bnum = bnum;
                bnumOK = true;
            }
            if (BDateValid.IsValid(bdate))
            {
                this.Bdate = bdate;
                bdateOK = true;
            }

            if (nameOK && surnameOK && bnumOK && bdateOK)
            {
                return true;
            }
            else return false;
            }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public string Name { get; set; }
            public string Surname { get; set; }
            public string Bnum { get; set; }
            public DateTime Bdate { get; set; }
            public bool IsValidPerson;
            readonly IStringValidator NameValid;
            readonly IStringValidator SurnameValid;
            readonly IStringValidator BNumValid;
            readonly IDateTimeValidator BDateValid;
        }
    
}
