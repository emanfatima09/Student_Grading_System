using Student_Grading_System.BusinessLayer;
using Student_Grading_System.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grading_System
{
    public partial class Form1 : Form
    {
        private LoginDTO _lgDTO;
        private LoginBL _lgBL;
        public Form1()
        {
            InitializeComponent();
            _lgDTO = new LoginDTO();
            _lgBL = new LoginBL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            _lgDTO.Username = txt_Username.Text;
            _lgDTO.Password = txt_Password.Text;
            string check = _lgBL.VerifyUser(_lgDTO);
            if (check != null)
            {

                MessageBox.Show("Login Succesful");
            }
            else
            {
                Faculty fac_scrn = new Faculty();
                fac_scrn.Show();
                
            }
        }
    }
}
