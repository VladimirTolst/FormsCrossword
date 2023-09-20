using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormsCrossword
{
    public partial class Form1 : Form
    {
        int x;
        string array
        int[,] array =
        {
            { 1, 0, 1, 0, 1, 1, 0, 1, 0, 0},
            { 0, 0, 0, 0, 1, 1, 0, 0, 1, 0},
            { 1, 0, 1, 0, 0, 1, 0, 0, 1, 0},
            { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
            { 0, 0, 1, 1, 0, 0, 1, 0, 1, 0},
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
            { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
            { 1, 0, 1, 0, 0, 0, 0, 0, 0, 0},
            { 1, 0, 1, 0, 1, 0, 0, 0, 0, 0},
        };
        
        public void checkBoxArray()
        {
            int k = array.Length;
            for (int i = 0; i < k; i++)
            {
                CheckBox checkBx = new CheckBox();
                checkBx.Size = new Size(15,15);
                checkBx.Click += check_click;
                flowLayoutPanel1.Controls.Add(checkBx);
            }
        }
        public void check_click(object sender, EventArgs e)
        {
            CheckBox checkBx = (CheckBox)sender;
        }
        public void chekI()
        {
            double a = Math.Sqrt(array.Length);
            int ArrWidth = Convert.ToInt32(a);
            for (int i = 0; i < a-1; i++)
            {
                for (int j = 0; j < a-1; j++)
                {
                    if (array[i,j] == 1)
                    {
                        x++;
                    }
                    else
                    {

                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();


            //тут чек на кол-во цифер и установка размера
            checkBoxArray();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
