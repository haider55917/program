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
    public partial class Form3 : Form
    {
        private home form2Instance; // متغير للاحتفاظ بمرجع home (أو Form2)

        // تغيير النوع إلى home أو Form2
        public Form3(home form2)
        {
            InitializeComponent();
            this.form2Instance = form2; // الاحتفاظ بمرجع Form2 أو home
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //تأكد أن التبويبة "الرئيسية" هي المرئية فقط عند بدء التشغيل
            
            xtraTabPage1.PageVisible = true;  // إظهار "الرئيسية"
            xtraTabPage2.PageVisible = false;      // إخفاء "المعاون الإداري"
            xtraTabPage3.PageVisible = false;                                         // إخفاء "الإعدادات"
            xtraTabPage4.PageVisible = false;
            // تعيين "الرئيسية" كتبيوبة نشطة
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {

            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs closeArgs = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            DevExpress.XtraTab.XtraTabPage tabPage = closeArgs.Page as DevExpress.XtraTab.XtraTabPage;

            // التحقق من أن التبويب ليس هو التبويب الرئيسي (إذا كنت تريد منع إغلاقه)
            if (xtraTabControl1.TabPages.IndexOf(tabPage) != 0)
            {
                // إغلاق التبويب
                tabPage.PageVisible = false; // إخفاء التبويب بدلاً من إغلاقه
            }
            else
            {
                // رسالة توضيحية إذا حاول المستخدم إغلاق التبويب الرئيسي
                MessageBox.Show("لا يمكنك إغلاق الصفحة الرئيسية.");
            }
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // جعل التبويبة مرئية
            xtraTabPage2.PageVisible = true;

            // تحديد "xtraTabPage2" كالتبويب النشط
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
        }

        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            xtraTabPage2.PageVisible = true;
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            xtraTabPage3.PageVisible = true;
            xtraTabControl1.SelectedTabPage = xtraTabPage3;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            xtraTabPage4.PageVisible = true;
            xtraTabControl1.SelectedTabPage = xtraTabPage4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form homeForm = Application.OpenForms["home"];
            if (homeForm != null)
            {
                PictureBox pichome = homeForm.Controls["pichome"] as PictureBox;
                if (pichome != null)
                {
                    pichome.Visible = true; // إعادة إظهار PictureBox عند الإغلاق
                    pichome.BringToFront(); // اجعله في المقدمة
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void xtraOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
    }


 


