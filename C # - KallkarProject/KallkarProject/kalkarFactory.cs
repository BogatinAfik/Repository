using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KallkarProject
{
   public class kalkarFactory
    {
        private string name;

        public kalkarFactory(string name)
        {
            this.name = name;
        }

        public string getName() {
            return this.name;
        }
    }
}
