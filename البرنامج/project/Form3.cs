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
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            form2Instance.CloseSlider(); // استدعاء الدالة من home أو Form2
        }
    }
}
