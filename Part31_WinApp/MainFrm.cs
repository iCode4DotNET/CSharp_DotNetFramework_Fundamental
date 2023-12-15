using System;
using System.Windows.Forms;

namespace Part31_WinApp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var name = TxtFirstName.Text;

            var message = "خوش آمدید کاربر عزیز : " + name;

            //MessageBox.Show(message);
            //MessageBox.Show(message,"پیام سیستم");
            MessageBox.Show(message, "پیام سیستم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        }
    }
}