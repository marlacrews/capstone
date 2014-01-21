using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class GuestBookDAO
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

        //Read Guestbook table of database
        public List<GbEntries> ReadGbEntries(string statement, SqlParameter[] parameters)
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
                    List<GbEntries> GbEntry = new List<GbEntries>();
                    while (data.Read())
                    {
                        GbEntries GbEntry = new Customers();
                        guestbook.Entry = Convert.ToInt32(data["Cust_ID"]);
                        guestbook.First_Name = data["FirstName"].ToString();
                        guestbook.Last_Name = data["LastName"].ToString();
                        guestbook.City = data["City"].ToString;
                        guestbook.State_2 = data["State_2"].ToString;
                        guestbook.Email = data["Email"].ToString();
                        guestbook,Comment_Area = data["Comment_Area"].ToString();
                        guestbook.Add(GbEntry);
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

        //Returns all entries
        public List<GbEntries> GetAllGbEntries()
        {
            return ReadGbEnreies("GetAllGbEntries", null);
        }

        //Add Guestbook entry to database
        public void CreateGbEntry(GbEntries GbEntry)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@First_Name", guestbook.First_Name),
                new SqlParameter("@Last_Name", guestbook.Last_Name),
                new SqlParameter("@City", guestbook.City),
                new SqlParameter("@State_2", guestbook.State_2),
                new SqlParameter("@Email", guestbook.Email),
                new SqlParameter("@Comment_Area", guestbook.Comment_Area)
            };
            Write("CreateGbEntry", parameters);
        }


    }
}
