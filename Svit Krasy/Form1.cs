using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Svit_Krasy
{
    public partial class Form1 : MaterialForm
    {
        user User;

        public int Discount_buyer { get; set; }
        public double Total_sum { get; set; }

        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple400, Accent.Purple100, TextShade.WHITE);
           
        }
        public Form1(ref user User)
        {
            this.User = User;
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple400, Accent.Purple100, TextShade.WHITE);
        }

       

       

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            
         
        }

    

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked == true)
            {
                groupBox1.Enabled = true;
            }
           else
            {
                groupBox1.Enabled = false;
            }

        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox2.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void materialCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox3.Checked == true)
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }
        }

       
     private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            string discount = comboBox1.Text;
            string color = comboBox2.Text;
            DateTime date = dateTimePicker1.Value;
            string stones = materialSingleLineTextField1.Text;
            SvitKrasy sv = new SvitKrasy(color, discount, date, stones);
           
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                var text = sv;
                string path = saveFileDialog1.FileName;
                using (var stream = new FileStream(path +".txt", FileMode.Create))
                {

                    formatter.Serialize(stream, text);
                }
            }
        }
        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                SvitKrasy item2 = null;
                using (var stream = new FileStream(path, FileMode.Open))
                {

                    item2 = (SvitKrasy)formatter.Deserialize(stream);
                    MessageBox.Show(item2.ToString());
                   

                }
            }
        }
     

     
      


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Discount_buyer = Int32.Parse((comboBox1.SelectedItem as string).Substring(0, (comboBox1.SelectedItem as string).Length - 1));
        }

        private void materialCheckBox4_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
               
                Total_sum += 10;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox5_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                
                Total_sum += 17;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox7_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
               
                Total_sum += 23;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox6_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
               
                Total_sum += 27;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox11_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                Total_sum +=11;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox10_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                int Count = Int32.Parse(materialLabel8.Text);
                Total_sum +=  19;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox8_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                Total_sum += 25;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox9_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
               
                Total_sum += 29;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox12_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                Total_sum +=  9;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox13_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                int Count = Int32.Parse(materialLabel15.Text);
                Total_sum += Count * 10;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox14_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                Total_sum +=  14;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox15_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                Total_sum += 54;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialCheckBox16_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
               
                Total_sum += 28;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            nextStep newForm = new nextStep(ref User, Discount_buyer, Total_sum);
            this.Visible = false;
            newForm.ShowDialog();
            this.Close();
           

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            try
            {
                int Count = Int32.Parse(materialSingleLineTextField1.Text);
                Total_sum += Count * 1;
            }
            catch (Exception t)
            {
                t.ToString();
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = materialTabControl1.TabPages[1];
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = String.Empty;
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
        
        }
    }
}

