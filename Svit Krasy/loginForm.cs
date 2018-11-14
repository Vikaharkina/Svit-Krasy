using MaterialSkin;
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
    public partial class loginForm : MaterialForm
    {
        private List<user> users = new List<user>();
        private user user = null;
      
        private readonly MaterialSkinManager materialSkinManager;
       

        public loginForm()
        {
            InitializeComponent();
            users.Add(new user { Login = "aaa", Name = " Vika", Password = "111", Surname = "harkina" });
            user = users[0];
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple400, Accent.Purple100, TextShade.WHITE);
         

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            user = new user();
           registration newForm = new registration(ref user);
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                users.Add(user);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var loginUser = new user { Login = materialSingleLineTextField1.Text, Password = materialSingleLineTextField2.Text };
            if (users.Any(elem => elem.Login == loginUser.Login && elem.Password == loginUser.Password))
            {
                Form1 form = new Form1(ref user);
                this.Visible = false;
                form.ShowDialog();
                this.Close();
            }
            else
            {
                Messagebox newform = new Messagebox();
                this.Visible = false;
                newform.ShowDialog();
            }

        }


    }
}
