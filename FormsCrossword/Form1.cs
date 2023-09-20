using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormsCrossword
{
    public partial class Form1 : Form
    {
        int checkwidth = 10;
        int checkheight = 10;
        int labelwid = 170;
        int labelhet = 120;
       // int[] nums = new int[];
      

        int[,] array =
        {
            { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
            { 0, 0, 0, 1, 0, 0, 0, 1, 1, 1},
            { 0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
            { 0, 1, 0, 0, 0, 0, 0, 1, 1, 1},
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
            { 0, 0, 0, 1, 1, 1, 0, 1, 1, 1},
            { 1, 0, 0, 1, 0, 1, 0, 0, 0, 0},
            { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0},
            { 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
            { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
        };
        
        public void checkBoxArray()
        {
            double a = Math.Sqrt(array.Length);
            int ArrWidth = Convert.ToInt32(a);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    CheckBox checkBx = new CheckBox();
                    checkBx.Size = new Size(15,15);
                    checkBx.Location = new Point (checkwidth,checkheight);
                    checkBx.Click += check_click;
                    flowLayoutPanel1.Controls.Add(checkBx);
                    checkwidth += 20;
                }
                checkheight+= 20;
            }
        }
        public void check_click(object sender, EventArgs e)
        {
            CheckBox checkBx = (CheckBox)sender;
        }
        public void chekI()
        {
            int y = 0;
            int x = 0;
            double a = Math.Sqrt(array.Length);
            int ArrWidth = Convert.ToInt32(a);
            for (int i = 0; i < a-2; i++)
            {
                for (int j = 0; j < a-2; j++)
                {
                    if (array[i,j] == 1)
                    {
                        x++;
                        if (array[i,j+1] == 1)
                        {
                            x++;
                            j++;
                        }
                        else
                        {
                            if (x != 0)
                            {
                                
                                Label lab = new Label();
                                lab.Size = new Size(20, 20);
                                lab.Text = Convert.ToString(x);
                                panel1.Controls.Add(lab);
                                lab.Location = new Point(173 + y*20, 103+x*20);
                                lab.ForeColor = Color.Black;

                            }
                            x = 0;
                        }
                    }
                    y++;
                    x = 0;
                }
               /* Label lab = new Label();
                lab.Size = new Size(200, nums.Length * 20);
                for (int l = 0; l < nums.Length; l++)
                {
                    lab.Text = Convert.ToString(nums);
                    panel1.Controls.Add (lab);
                }
                lab.Location = new Point(173, 103);
                lab.ForeColor= Color.Black;
                Array.Clear(nums, 0, nums.Length);
                masCount=-1;*/
            }
        }

        public Form1()
        {
            InitializeComponent();


            //тут чек на кол-во цифер и установка размера
            checkBoxArray();
            chekI();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
