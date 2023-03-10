using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations.Composizione
{
    class Company
    {
        CEO _cEO;
        public Company(string CeoName)
        {
            _cEO = new CEO(CeoName);

        }
        class CEO
        {
            string _name;
            public CEO(string name)
            {
                _name = name;
            }
        }
    }

}
