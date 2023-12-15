using System;
using System.Windows.Forms;
using SadrTools.Extension;

namespace Part31_WinApp
{
    public partial class EventFrm : Form
    {
        public EventFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

     
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("press");

            if(char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }

        }

        private void TxtFirstNumber_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("up");
        }

        private void TxtFirstNumber_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("down");

           
            
        }
    }
}