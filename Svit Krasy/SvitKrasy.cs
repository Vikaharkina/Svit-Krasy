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

    [Serializable]
    class SvitKrasy
    {


        public static Random Rnd = new Random();
        public SvitKrasy()
        {
        }

        string color;
        string stones;
        string discount;
        public DateTime Date { get; set; }
        public SvitKrasy(string Color, string Discount, DateTime date,string Stones)
        {
        stones = Stones;
        color = Color;
        discount = Discount;
        Date = date;

        }
        public override string ToString()
        {
            return $"Color = {color}, Discount = {discount},  Date = {Date}, Rhinestones qty = {stones} ";
        }
  
    }
