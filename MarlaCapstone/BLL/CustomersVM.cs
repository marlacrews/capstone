using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomersVM
    {
        public SearchFM Search { get; set; }
        public List<CustomerVM> Customers { get; set; }
        public CustomersVM()
        {
            Search = new SearchFM();
            Customers = new List<CustomerVM>();
        }
    }
}
