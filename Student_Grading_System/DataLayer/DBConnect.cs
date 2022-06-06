using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System.DataLayer
{
    class DBConnect
    {
        private SqlConnection con;
        private string _conString;
        public DBConnect()
        {
            _conString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\Student_Grading_System\Student_Grading_System\DataLayer\SGS_Data.mdf;Integrated Security = True";
            con = new SqlConnection(_conString);
        }

        public SqlConnection Con { get => con; set => con = value; }
    }
}
