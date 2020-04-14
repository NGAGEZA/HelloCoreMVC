using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingMultipleModels.Models
{
    public class ViewDataModel
    {
        public IEnumerable<Customers> GetCustomers { get; set; }
        public IEnumerable<Products> GetProducts { get; set; }
    }
}
