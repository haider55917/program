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
        // المتغيرات الخاصة بحالة القائمة الجانبية
        //bool slid;          // متغير لتحديد إذا كانت القائمة الجانبية مغلقة أو مفتوحة
        //bool sidebarss;      // حالة القائمة الخاصة بالإعدادات
        //bool sidebardd;      // حالة القائمة الخاصة بالأقسام
        private Form3 frm; // متغير للاحتفاظ بمرجع Form3

        public home()
        {
            InitializeComponent(); // استدعاء المكونات
        }

        // تحميل نافذة "الرئيسية" عند فتح التطبيق
        private void home_Load(object sender, EventArgs e)
        {
            mainTabControl.Visible = true;       // إظهار "الرئيسية"
            pageadari.PageVisible = false;       // إخفاء "المعاون الإداري"
            pagesetting.PageVisible = false;     // إخفاء "الإعدادات"
            mainTabControl.BackColor = Color.FromArgb(1, 65, 51);
            // تعيين "الرئيسية" كالتبويب النشط
            mainTabControl.SelectedTabPage = pageadari;
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

            //deptim.Start();   // بدء التايمر لفتح قائمة الأقسام

            // إيقاف التايمر إذا كانت القائمة الجانبية مغلقة


            if (flomenu.Width == 50)
            {
                deptim.Stop();
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
            pageadari.PageVisible = true; // إظهار صفحة "المعاون الإداري"
            mainTabControl.SelectedTabPage = pageadari; // تعيينها كالتبويب النشط
        }

        // التعامل مع إغلاق أو فتح القائمة الجانبية عند الضغط على أيقونة "المنزل"
        private void pichome_Click(object sender, EventArgs e)
        {
            //if (!sidebardd) // إذا كانت النافذة مفتوحة، نبدأ عملية الإغلاق
            //{
            //    deptim.Start(); // بدء عملية الإغلاق
            //}
            CloseSlider();


        }

        // التحكم في عرض قائمة الإعدادات وقائمة الأقسام
        private void timrtsetting(object sender, EventArgs e)
        {
            //if (sidebardd)
            //{
            //    // تقليص عرض قائمة "الأقسام"
            //    depsidebar.Width -= 20;
            //    if (depsidebar.Width == depsidebar.MinimumSize.Width)
            //    {
            //        sidebarss = true;
            //        deptim.Stop();
            //    }

            //    // توسيع عرض قائمة "الإعدادات"
            //    settingsidebar.Width += 20;
            //    if (settingsidebar.Width == settingsidebar.MaximumSize.Width)
            //    {
            //        sidebardd = false;
            //        settingtim.Stop();
            //    }
            //}
            //else
            //{
            //    // تقليص عرض قائمة "الإعدادات"
            //    settingsidebar.Width -= 20;
            //    if (settingsidebar.Width == settingsidebar.MinimumSize.Width)
            //    {
            //        sidebardd = true;
            //        settingtim.Stop();
            //    }
            //}
        }

        // التحكم في عرض قائمة "الأقسام" عند تشغيل التايمر الخاص بها
        private void deptim_Tick(object sender, EventArgs e)
        {
            //if (sidebardd)
            //{
            //    // تقليص عرض قائمة "الإعدادات"
            //    settingsidebar.Width -= 20;
            //    if (settingsidebar.Width == settingsidebar.MinimumSize.Width)
            //    {
            //        sidebarss = true;
            //        settingtim.Stop();
            //    }

            //    // توسيع عرض قائمة "الأقسام"
            //    depsidebar.Width += 20;
            //    if (depsidebar.Width == depsidebar.MaximumSize.Width)
            //    {
            //        sidebardd = false;
            //        deptim.Stop();
            //    }
            //}
            //else
            //{
            //    // تقليص عرض قائمة "الأقسام"
            //    depsidebar.Width -= 20;
            //    if (depsidebar.Width == depsidebar.MinimumSize.Width)
            //    {
            //        sidebardd = true;
            //        deptim.Stop();
            //    }
            //}
        }

        // التحكم في إظهار أو إخفاء القائمة الجانبية بالكامل
        private void menutim_Tick(object sender, EventArgs e)
        {
            //if (slid)
            //{
            //    // إخفاء "الإعدادات" عند غلق القائمة الجانبية
            //    settingsidebar.Width -= 20;
            //    if (settingsidebar.Width == settingsidebar.MinimumSize.Width)
            //    {
            //        sidebarss = true;
            //        settingtim.Stop();
            //    }

            //    // إخفاء "الأقسام" عند غلق القائمة الجانبية
            //    depsidebar.Width -= 20;
            //    if (depsidebar.Width == depsidebar.MinimumSize.Width)
            //    {
            //        sidebarss = true;
            //        deptim.Stop();
            //    }

            //    // غلق القائمة الجانبية بالكامل
            //    flomenu.Width -= 10;
            //    if (flomenu.Width == flomenu.MinimumSize.Width)
            //    {
            //        slid = false;
            //        menutim.Stop();
            //    }
            //}
            //else   // فتح القائمة الجانبية بالكامل
            //{
            //    flomenu.Width += 10;
            //    if (flomenu.Width == flomenu.MaximumSize.Width)
            //    {
            //        slid = true;
            //        menutim.Stop();
            //    }
            //}
        }

        // التعامل مع إغلاق التبويبات عند الضغط على زر الإغلاق في التبويب
        private void menuTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs closeArgs = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            DevExpress.XtraTab.XtraTabPage tabPage = closeArgs.Page as DevExpress.XtraTab.XtraTabPage;

            // التأكد من أن المستخدم لا يحاول إغلاق التبويب الرئيسي
            if (mainTabControl.TabPages.IndexOf(tabPage) != 0)
            {
                tabPage.PageVisible = false; // إخفاء التبويب بدلاً من إغلاقه
            }
            else
            {
                // إظهار رسالة توضيحية عند محاولة إغلاق التبويب الرئيسي
                MessageBox.Show("لا يمكنك إغلاق الصفحة الرئيسية.");
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            //pichome.Visible = false;
            //Form3 frm = new Form3(this); // تمرير مرجع Form2 إلى Form3
            //frm.Show();
            //frm.TopLevel = false;
            //panel1.Controls.Add(frm);
            //frm.BringToFront();

            // تحقق مما إذا كانت Form3 مفتوحة بالفعل
            if (frm == null || frm.IsDisposed)
            {
                frm = new Form3(this); // تمرير مرجع Form2 إلى Form3
                frm.TopLevel = false; // تأكد من أنها ليست نافذة مستقلة
                frm.FormBorderStyle = FormBorderStyle.None; // إزالة الحدود حتى لا تظهر كنافذة منفصلة
                frm.Dock = DockStyle.Fill; // لجعل Form3 تملأ panel1 بالكامل

                panel1.Controls.Add(frm); // إضافة Form3 إلى Panel1
                frm.BringToFront(); // إحضار Form3 إلى الواجهة
                frm.Show(); // إظهار Form3
            }
            else
            {
                frm.BringToFront(); // إذا كانت Form3 موجودة بالفعل، فقط أحضرها إلى الواجهة
            }

            // تأكد من أن panel1 مرئية
            panel1.Visible = true;
            pichome.Visible = false;
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



        private void btntableg_Click_1(object sender, EventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Form3(this); // تمرير مرجع Form2 إلى Form3
                frm.TopLevel = false; // تأكد من أنها ليست نافذة مستقلة
                frm.FormBorderStyle = FormBorderStyle.None; // إزالة الحدود حتى لا تظهر كنافذة منفصلة
                frm.Dock = DockStyle.Fill; // لجعل Form3 تملأ panel1 بالكامل

                panel1.Controls.Add(frm); // إضافة Form3 إلى Panel1
                frm.BringToFront(); // إحضار Form3 إلى الواجهة
                frm.Show(); // إظهار Form3
            }
            else
            {
                frm.BringToFront(); // إذا كانت Form3 موجودة بالفعل، فقط أحضرها إلى الواجهة
            }

            // تأكد من أن panel1 مرئية
            panel1.Visible = true;
            pichome.Visible = false;
            CloseSlider();
        }



        //menutim.Start();    // تشغيل التايمر لفتح أو غلق القائمة الجانبية




    }
}

