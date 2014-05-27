using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    public class Store
    {
        #region Properties and Fields
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Store(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Methods
        public Product GetProduct(int id)
        {
            // find product in database and return
            // will fake it for now
            Product result = new Product(id, "Visual Studio 2013 Ultimate");
            return result;
        }
        #endregion
    }
}
