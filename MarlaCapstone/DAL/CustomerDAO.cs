using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class CustomerDAO
    {
        //Writes to database
        public void Write(string statement, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MarlaCapstone;Integrated Security=SSPI;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
        //Read Customers table of database
        public List<Customers> ReadCustomers(string statement, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MarlaCapstone;Integrated Security=SSPI;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    SqlDataReader data = command.ExecuteReader();
                    List<Customers> customers = new List<Customers>();
                    while (data.Read())
                    {
                        Customers customer = new Customers();
                        customers.Cust_ID = Convert.ToInt32(data["Cust_ID"]);
                        customers.First_Name = data["FirstName"].ToString();
                        customers.Last_Name = data["LastName"].ToString();
                        customers.Street_Address = data["Street_Address"].ToString;
                        customers.City = data["City"].ToString;
                        customers.State_2 = data["State_2"].ToString;
                        customers.Zip_5 = data["Zip_5"].ToString;
                        customers.Email = data["Email"].ToString();
                        customers.Add(customer);
                    }
                    try
                    {
                        return customers;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }
        //Returns all customers
        public List<Customers> GetAllCustomers()
        {
            return ReadCustomers("GetAllCustomers", null);
        }
        //Returns a subscriber when you input an email
        public Customers GetCustomerByEmail(string email)
        {
            List<Customers> customers = GetAllSubscribers();
            foreach (Customers customer in customers)
            {
                if (customers.Email == email)
                {
                    return customer;
                }
            }
            return null;
        }
        //Add customer to database
        public void CreateSubscriber(Customers customer)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@FirstName", customers.First_Name),
                new SqlParameter("@LastName", customers.Last_Name),
                new SqlParameter("@Street_Address", customers.Street_Address),
                new SqlParameter("@City", customers.City),
                new SqlParameter("@State_2", customers.State_2),
                new SqlParameter("@Zip_5", customers.Zip_5),
                new SqlParameter("@Birthday", customers.Birthday),
                new SqlParameter("@Email", customers.Email),
                new SqlParameter("@Active", 1)
            };
            Write("CreateCustomer", parameters);
        }
        //retrieve list of users matching search parameters
        public List<Customers> Search(string s)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@search", s)
            };
            return ReadCustomers("SearchCustomers", parameters);
        }
    }
}
