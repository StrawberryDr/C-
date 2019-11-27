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
    public partial class Update : Form
    {
        public static string path;
        public static string info;
        public Update()
        {
            InitializeComponent();
            path = @"D:\证件照.gif";
            pictureBox1.Image = Image.FromFile(path);
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mySubmitBtn_Click(object sender, EventArgs e)
        {
            info = "学号：" + tbxid.Text + "\r\n";
            info += "姓名：" + tbxName.Text + "\r\n";
            foreach(Control control in gbxSex.Controls)
            {
                if((control as RadioButton).Checked)
                {
                    info += "性别：" + (control as RadioButton).Text;
                }
            }
            this.Opacity = 0;
            info += "\r\n爱好：";
            foreach (Control control in gbxFavor.Controls)
            {
                if ((control as CheckBox).Checked)
                {
                    info += (control as CheckBox).Text + " ";
                }
            }
            info += "\r\n出生日期：" + dateTimePicker1.Text;
            info += "\r\n专业：" + comboBox1.Text;
            Welcome.browserForm = new Browser();
            Welcome.browserForm.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
