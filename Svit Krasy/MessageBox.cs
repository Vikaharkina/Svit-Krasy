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
    public partial class Messagebox : MaterialForm
    {
        public Messagebox()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            loginForm newform = new loginForm();
            this.Visible = false;
            newform.ShowDialog();
            
        }
    }
}
