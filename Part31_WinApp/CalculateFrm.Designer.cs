namespace Part31_WinApp
{
    partial class CalculateFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFirstNumber = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtSecondNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد اول";
            // 
            // TxtFirstNumber
            // 
            this.TxtFirstNumber.Location = new System.Drawing.Point(82, 39);
            this.TxtFirstNumber.Name = "TxtFirstNumber";
            this.TxtFirstNumber.Size = new System.Drawing.Size(190, 23);
            this.TxtFirstNumber.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(216, 118);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(56, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtSecondNumber
            // 
            this.TxtSecondNumber.Location = new System.Drawing.Point(82, 78);
            this.TxtSecondNumber.Name = "TxtSecondNumber";
            this.TxtSecondNumber.Size = new System.Drawing.Size(190, 23);
            this.TxtSecondNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "عدد دوم ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.BtnDivide);
            this.groupBox1.Controls.Add(this.LblResult);
            this.groupBox1.Controls.Add(this.TxtSecondNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.TxtFirstNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 230);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "محاسبات ریاضی";
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.Color.Lime;
            this.LblResult.Location = new System.Drawing.Point(82, 154);
            this.LblResult.Name = "LblResult";
            this.LblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblResult.Size = new System.Drawing.Size(190, 24);
            this.LblResult.TabIndex = 5;
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(154, 118);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(56, 23);
            this.BtnDivide.TabIndex = 6;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // CalculateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 264);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculateFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم اصلی";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFirstNumber;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtSecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnDivide;
    }
}