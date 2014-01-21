using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerRegisterVM
    {
        public int Cust_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Street_Address { get; set; }
        public string City { get; set; }
        public string State_2 { get; set; }
        public string Zip_5 { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
