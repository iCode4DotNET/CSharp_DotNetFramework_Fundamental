namespace Part31_WinApp
{
    partial class EventFrm
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
            this.TxtSecondNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی";
            // 
            // TxtFirstNumber
            // 
            this.TxtFirstNumber.Location = new System.Drawing.Point(45, 39);
            this.TxtFirstNumber.Name = "TxtFirstNumber";
            this.TxtFirstNumber.Size = new System.Drawing.Size(190, 23);
            this.TxtFirstNumber.TabIndex = 1;
            this.TxtFirstNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFirstNumber_KeyDown);
            this.TxtFirstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirstNumber_KeyPress);
            this.TxtFirstNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFirstNumber_KeyUp);
            // 
            // TxtSecondNumber
            // 
            this.TxtSecondNumber.Location = new System.Drawing.Point(45, 78);
            this.TxtSecondNumber.Name = "TxtSecondNumber";
            this.TxtSecondNumber.Size = new System.Drawing.Size(190, 23);
            this.TxtSecondNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "سن";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.TxtSecondNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtFirstNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 230);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // EventFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 264);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventFrm";
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
        private System.Windows.Forms.TextBox TxtSecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}