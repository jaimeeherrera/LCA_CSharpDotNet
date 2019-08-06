using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Controllers
{
    public class School:AgeAttribute :  Validation Attribute 
    {
        private int _minAge;
        private int _maxAge;

        public SchoolAgeAttribute(int minAge, int maxAge)
        {
            _minAge = minAge;
            _maxAge = maxAge;
        }

        public override ValidationResult Valid
        {

        }
    }

}
