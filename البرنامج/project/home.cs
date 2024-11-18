using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class home : Form
    {
        private Form3 frm; // متغير للاحتفاظ بمرجع Form3

        public home()
        {
            InitializeComponent(); // استدعاء المكونات
        }

        // تحميل نافذة "الرئيسية" عند فتح التطبيق
        private void home_Load(object sender, EventArgs e)
        {
       
        }

        // غلق النافذة عند الضغط على زر الإغلاق
        private void btnclose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        // تصغير النافذة عند الضغط على زر التصغير
        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // التعامل مع فتح قائمة "الأقسام"
        private void Sections_Click(object sender, EventArgs e)
        {

            if (depsidebar.Width == 0 || settingsidebar.Width == 225)
            {
                settingsidebar.Width = 0;
                depsidebar.Width = 225;
              
            }
            else
            {
                depsidebar.Width = 0;
            }

             }
        // التعامل مع فتح قائمة "الإعدادات"
        private void setting_Click(object sender, EventArgs e)
        {

            if (settingsidebar.Width == 0 || depsidebar.Width == 225)
            {
                depsidebar.Width = 0;
                settingsidebar.Width = 225;



            }
            else
            {
                settingsidebar.Width = 0;
            }

        }

        // التعامل مع فتح "المعاون الإداري"
        private void Edara_Click(object sender, EventArgs e)
        {

        }

        // التعامل مع إغلاق أو فتح القائمة الجانبية عند الضغط على أيقونة "المنزل"
        private void pichome_Click(object sender, EventArgs e)
        {
           


        }
      
        // التعامل مع فتح أو غلق القائمة الجانبية عند الضغط على أيقونة "القائمة"
        private void picmenu_Click(object sender, EventArgs e)
        {
            if (flomenu.Width == 50)
            {
                flomenu.Width = 185;
            }
            else
            {
                flomenu.Width = 50;
            }
        }
        public void CloseSlider()
        {
            if (depsidebar.Width == 225 || settingsidebar.Width == 225) // إذا كانت النافذة مفتوحة فقط، نبدأ عملية الإغلاق
            {
                depsidebar.Width = 0; // بدء عملية الإغلاق
                settingsidebar.Width = 0;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntableg_Click(object sender, EventArgs e)
        {
            // تحقق مما إذا كانت Form3 مفتوحة بالفعل
            if (frm == null || frm.IsDisposed)
            {
                frm = new Form3(this); // تمرير مرجع Form2 إلى Form3
                frm.TopLevel = false; // تأكد من أنها ليست نافذة مستقلة
                frm.FormBorderStyle = FormBorderStyle.None; // إزالة الحدود حتى لا تظهر كنافذة منفصلة
                // لجعل Form3 تملأ panel1 بالكامل

                panel1.Controls.Add(frm); // إضافة Form3 إلى Panel1
                frm.BringToFront(); // إحضار Form3 إلى الواجهة
                frm.Show(); // إظهار Form3
                depsidebar.Width = 0;
            }
            else
            {
                frm.BringToFront(); // إذا كانت Form3 موجودة بالفعل، فقط أحضرها إلى الواجهة
               
            }

            // تأكد من أن panel1 مرئية
            panel1.Visible = true;
            pichome.Visible = true;
        }

        private void pichome_Click_1(object sender, EventArgs e)
        {

        }

        private void btntableg_Click_1(object sender, EventArgs e)
        {
            //if (frm == null || frm.IsDisposed)
            //{
            //    frm = new Form3(this); // تمرير مرجع Form2 إلى Form3
            //    frm.TopLevel = false; // تأكد من أنها ليست نافذة مستقلة
            //    frm.FormBorderStyle = FormBorderStyle.None; // إزالة الحدود حتى لا تظهر كنافذة منفصلة
            //    frm.Dock = DockStyle.Fill; // لجعل Form3 تملأ panel1 بالكامل

            //    panel3.Controls.Add(frm); // إضافة Form3 إلى Panel1
            //    frm.BringToFront(); // إحضار Form3 إلى الواجهة
            //    frm.Show(); // إظهار Form3
            //}
            //else
            //{
            //    frm.BringToFront(); // إذا كانت Form3 موجودة بالفعل، فقط أحضرها إلى الواجهة
            //}

            //// تأكد من أن panel1 مرئية
            //panel3.Visible = true;
            //pichome.Visible = false;
            //CloseSlider();
            if (frm == null || frm.IsDisposed)
            {
                frm = new Form3(this);
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panel1.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();
                depsidebar.Width = 0;
                flomenu.Width = 50;
            }
            else
            {
                frm.BringToFront();
            }

            panel1.Visible = true;
            pichome.Visible = false; // إخفاء PictureBox عند فتح Form3
        }

    }
}



