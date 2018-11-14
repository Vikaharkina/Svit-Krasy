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
using Svit_Krasy;

namespace Svit_Krasy
{
    public partial class nextStep : MaterialForm

    {
        user User;
        int Discount;
        double Sum;
        public nextStep()
        {
            InitializeComponent();
        }
        public nextStep(ref user User, int discount, double sum) {
            
            InitializeComponent();
            this.User = User;
            Discount = discount;
            Sum = sum;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" {User.Name} {User.Surname}\n Discount - {Discount}% \n Total Sum - {Sum -= Sum * Discount / 100}$");
            this.Close();
           
           
           
            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1(ref User);
            this.Visible = false;
            newform.ShowDialog();
           



        }
    }
}
