using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    public class Computer : Product // Computer inherits from ("is a") Product
    {
        #region Properties and Fields
        public string CPU { get; set; }
        public string OS { get; set; }
        #endregion
    }
}
