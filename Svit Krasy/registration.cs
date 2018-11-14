using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Svit_Krasy
{
    public partial class registration : MaterialForm
    {
        private user User; // = null;
        public registration()
        {
            InitializeComponent();
        }

        public registration(ref user User)
        {
            InitializeComponent();
        
            this.User = User;
            materialSingleLineTextField1.Text = User.Name;
            materialSingleLineTextField2.Text = User.Surname;
            materialSingleLineTextField4.Text = User.Login;
            materialSingleLineTextField5.Text = User.Password;
        }



        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked == true)
            {
                materialSingleLineTextField5.PasswordChar = '\0';
            }
            else
            {
                materialSingleLineTextField5.PasswordChar = '*';
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)


        {
            //if (User.Login == null)
            //{
            //    User.Login = "unknown";
            //    User.Password = "1111";
            //}
            registration regist = new registration();
            User.Login = materialSingleLineTextField4.Text;
            User.Password = materialSingleLineTextField5.Text;
            
            this.Close();

        }

       
    }

}
