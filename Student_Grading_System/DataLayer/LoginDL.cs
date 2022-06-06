using Student_Grading_System.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System.DataLayer
{
    class LoginDL
    {
        DBConnect con;
        public LoginDL()
        {
            con = new DBConnect();
        }
        public LoginDTO VerifyUserFromDB(LoginDTO dto)
        {
            LoginDTO retDTO = new LoginDTO();
            con.Con.Open();
            string queryString = "SELECT * FROM MyUser WHERE UserName='" + dto.Username + "' AND Password='" + dto.Password + "';";
            SqlCommand com = new SqlCommand(queryString, con.Con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                retDTO.Username = reader["UserName"].ToString();
                retDTO.Password = reader["Password"].ToString();
                retDTO.Role = reader["Role"].ToString();
                con.Con.Close();
                return retDTO;
            }
            con.Con.Close();
            return null;

        }
    }
}
