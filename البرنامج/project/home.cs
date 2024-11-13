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
        bool slid;          // متغير لتحديد إذا كانت القائمة الجانبية مغلقة أو مفتوحة
        bool sidebarss;      // حالة القائمة الخاصة بالإعدادات
        bool sidebardd;      // حالة القائمة الخاصة بالأقسام

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
            deptim.Start();   // بدء التايمر لفتح قائمة الأقسام

            // إيقاف التايمر إذا كانت القائمة الجانبية مغلقة
            if (flomenu.Width == 50)
            {
                deptim.Stop();
            }
        }

        // التعامل مع فتح قائمة "الإعدادات"
        private void setting_Click(object sender, EventArgs e)
        {
            settingtim.Start(); // بدء التايمر لفتح قائمة الإعدادات

            // إيقاف التايمر إذا كانت القائمة الجانبية مغلقة
            if (flomenu.Width == 50)
            {
                settingtim.Stop();
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
            if (!sidebardd) // إذا كانت النافذة مفتوحة، نبدأ عملية الإغلاق
            {
                deptim.Start(); // بدء عملية الإغلاق
            }
        }

        // التحكم في عرض قائمة الإعدادات وقائمة الأقسام
        private void timrtsetting(object sender, EventArgs e)
        {
            if (sidebardd)
            {
                // تقليص عرض قائمة "الأقسام"
                depsidebar.Width -= 20;
                if (depsidebar.Width == depsidebar.MinimumSize.Width)
                {
                    sidebarss = true;
                    deptim.Stop();
                }

                // توسيع عرض قائمة "الإعدادات"
                settingsidebar.Width += 20;
                if (settingsidebar.Width == settingsidebar.MaximumSize.Width)
                {
                    sidebardd = false;
                    settingtim.Stop();
                }
            }
            else
            {
                // تقليص عرض قائمة "الإعدادات"
                settingsidebar.Width -= 20;
                if (settingsidebar.Width == settingsidebar.MinimumSize.Width)
                {
                    sidebardd = true;
                    settingtim.Stop();
                }
            }
        }

        // التحكم في عرض قائمة "الأقسام" عند تشغيل التايمر الخاص بها
        private void deptim_Tick(object sender, EventArgs e)
        {
            if (sidebardd)
            {
                // تقليص عرض قائمة "الإعدادات"
                settingsidebar.Width -= 20;
                if (settingsidebar.Width == settingsidebar.MinimumSize.Width)
                {
                    sidebarss = true;
                    settingtim.Stop();
                }

                // توسيع عرض قائمة "الأقسام"
                depsidebar.Width += 20;
                if (depsidebar.Width == depsidebar.MaximumSize.Width)
                {
                    sidebardd = false;
                    deptim.Stop();
                }
            }
            else
            {
                // تقليص عرض قائمة "الأقسام"
                depsidebar.Width -= 20;
                if (depsidebar.Width == depsidebar.MinimumSize.Width)
                {
                    sidebardd = true;
                    deptim.Stop();
                }
            }
        }

        // التحكم في إظهار أو إخفاء القائمة الجانبية بالكامل
        private void menutim_Tick(object sender, EventArgs e)
        {
            if (slid)
            {
                // إخفاء "الإعدادات" عند غلق القائمة الجانبية
                settingsidebar.Width -= 20;
                if (settingsidebar.Width == settingsidebar.MinimumSize.Width)
                {
                    sidebarss = true;
                    settingtim.Stop();
                }

                // إخفاء "الأقسام" عند غلق القائمة الجانبية
                depsidebar.Width -= 20;
                if (depsidebar.Width == depsidebar.MinimumSize.Width)
                {
                    sidebarss = true;
                    deptim.Stop();
                }

                // غلق القائمة الجانبية بالكامل
                flomenu.Width -= 10;
                if (flomenu.Width == flomenu.MinimumSize.Width)
                {
                    slid = false;
                    menutim.Stop();
                }
            }
            else   // فتح القائمة الجانبية بالكامل
            {
                flomenu.Width += 10;
                if (flomenu.Width == flomenu.MaximumSize.Width)
                {
                    slid = true;
                    menutim.Stop();
                }
            }
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
            menutim.Start();    // تشغيل التايمر لفتح أو غلق القائمة الجانبية
        }
    }
}
