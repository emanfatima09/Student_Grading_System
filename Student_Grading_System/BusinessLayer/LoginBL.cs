using Student_Grading_System.DataLayer;
using Student_Grading_System.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System.BusinessLayer
{
    class LoginBL
    {
        private LoginDL _lgDl;
        public LoginBL()
        {
            _lgDl = new LoginDL();
        }
        public string VerifyUser(LoginDTO dto)
        {
            LoginDTO ret = _lgDl.VerifyUserFromDB(dto);
            if (ret == null)
            {
                return null;
            }
            else if (ret.Role.Equals("admin"))
            {
                return "admin";

            }
            return null;
        }


    }
}
