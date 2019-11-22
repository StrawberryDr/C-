using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMIS
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(StudentMIS.Update.path);
            rtbxStudentInfo1.Text = StudentMIS.Update.info;
        }

        private void Browser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome.updateForm.Opacity = 1;
            Welcome.updateForm.Show();
            this.Close();
        }
    }
}
