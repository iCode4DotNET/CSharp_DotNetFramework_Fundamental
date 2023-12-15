using System;
using System.Windows.Forms;
using SadrTools.Extension;

namespace Part31_WinApp
{
    public partial class CalculateFrm : Form
    {
        public CalculateFrm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = TxtFirstNumber.Text.ToInt();
                int number2 = TxtSecondNumber.Text.ToInt();
                LblResult.Text = $"{number1} + {number2} = {number1 + number2}";
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message , "خطای سیستم",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = TxtFirstNumber.Text.ToInt();
                int number2 = TxtSecondNumber.Text.ToInt();
                LblResult.Text = $"{number1} / {number2} = {number1 / number2}";
            }

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطای سیستم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show(" فایل پیدا نشد ", "خطای سیستم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (FormatException)
            {
                MessageBox.Show("فرمت درست نیست ", "خطای سیستم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (InvalidCastException)
            {
                MessageBox.Show("تبدیل درست انجام نشد", "خطای سیستم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("تقسیم بر صفر نداریم", "خطای سیستم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطای سیستم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                TxtFirstNumber.Text = TxtSecondNumber.Text = string.Empty;
            }
        }
    }
}