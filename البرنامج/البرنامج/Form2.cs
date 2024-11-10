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
        bool slid3;
        public home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (slid)
            {

                aksampanal.Width -= 20;
                if (aksampanal.Width == aksampanal.MinimumSize.Width)
                {
                    slid3 = true;
                    timer3.Stop();
                }


                flomenu.Width -= 10;
                if (flomenu.Width == flomenu.MinimumSize.Width)
                {
                    //panel12.AutoScroll = false;     // نكتب الكود هنا مال قفل البنل 12 عند سد الشريط
                    slid = false;
                    timer1.Stop();

                }
            }
            else
            {
                flomenu.Width += 10;
                if (flomenu.Width == flomenu.MaximumSize.Width)

                {
                    slid = true;
                    timer1.Stop();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            //if (flowLayoutPanel1.Width < 50)
            //{
            //    timer3.Start();
            //}
            //else if (flowLayoutPanel1.Width > 50)
            //{
            //    timer3.Stop();
            //}

        }

        private void Sections_Click(object sender, EventArgs e)
        {
            timer3.Start();

            if (flomenu.Width == 50)
            {
                timer3.Stop();
            }

        }

        private void setting_Click(object sender, EventArgs e)
        {


           
            pagesetting.PageVisible = true;

            // تحديد "xtraTabPage2" كالتبويب النشط
            xtraTabControl1.SelectedTabPage = pagesetting;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void home_Load(object sender, EventArgs e)
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

        private void Edara_Click(object sender, EventArgs e)
        {

                pageadari.PageVisible = true;

                // تحديد "xtraTabPage1" كالتبويب النشط
                xtraTabControl1.SelectedTabPage = pageadari;
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (slid3)
            {
                aksampanal.Width += 10;
                if (aksampanal.Width == aksampanal.MaximumSize.Width)

                {
                    slid3 = false;
                    timer3.Stop();
                }
            }
            else
            {
                aksampanal.Width -= 10;
                if (aksampanal.Width == aksampanal.MinimumSize.Width)
                {
                    slid3 = true;
                    timer3.Stop();
                }
            }

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void xtraTabControl1_CloseButtonClick_1(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs closeArgs = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            DevExpress.XtraTab.XtraTabPage tabPage = closeArgs.Page as DevExpress.XtraTab.XtraTabPage;

            // التحقق من أن التبويب ليس هو التبويب الرئيسي (إذا كنت تريد منع إغلاقه)
            if (xtraTabControl1.TabPages.IndexOf(tabPage) != 0)
            {
                // إخفاء التبويب بدلاً من إزالته
                tabPage.PageVisible = false;
            }
            else
            {
                // رسالة توضيحية إذا حاول المستخدم إغلاق التبويب الرئيسي
                MessageBox.Show("لا يمكنك إغلاق الصفحة الرئيسية.");
            }
        }


        private void home_Load_1(object sender, EventArgs e)
        {
            xtraTabControl1.Visible = true;       // إظهار "الرئيسية"
            pageadari.PageVisible = false;      // إخفاء "المعاون الإداري"
            pagesetting.PageVisible = false;      // إخفاء "الإعدادات"

            // تعيين "الرئيسية" كتبيوبة نشطة
            xtraTabControl1.SelectedTabPage = pageadari;
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
   

