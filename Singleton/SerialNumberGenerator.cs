using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;
        public static SerialNumberGenerator Instance {
            get {
                if (instance == null) {
                    instance = new SerialNumberGenerator();
                }
                return instance;
            }
        }

        private int count;

        private SerialNumberGenerator() { }
        
        public virtual int NextSerial
        {
            get {
                return count++;
            }

        }
    }
}
