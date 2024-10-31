using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace البرنامج
{
    public partial class home : Form
    {
        bool slid;
        bool slid2;
        public home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (slid)
            {
                
               flowLayoutPanel1.Width -= 10;
                if (flowLayoutPanel1.Width == flowLayoutPanel1.MinimumSize.Width)
                {
                    panel12.AutoScroll = false;     // نكتب الكود هنا مال قفل البنل 12 عند سد الشريط


                    slid = false;
                    timer1.Stop();
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if (flowLayoutPanel1.Width == flowLayoutPanel1.MaximumSize.Width)

                {
                    slid = true;
                    timer1.Stop();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (panel12.Height == 440)
            {
                timer2.Start();
            }

        }

        private void Sections_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Width > 50)
            {
                timer2.Start();
            }
           

        }

        private void setting_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (slid2)
            {
                panel12.AutoScroll = true;
                panel12.Height += 10;
                if(panel12.Height == panel12.MaximumSize.Height)
                   
                {
                    slid2 = false;
                    timer2.Stop();
                }
            } else
            {
                panel12.AutoScroll = false;
                panel12.Height -= 10;
                if (panel12.Height == panel12.MinimumSize.Height)
                {
                    slid2 = true;
                    timer2.Stop();
                }
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            panel12.AutoScroll = false;

        }

        private void panel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
