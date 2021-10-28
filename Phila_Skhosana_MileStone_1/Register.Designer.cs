
namespace Phila_Skhosana_MileStone_1
{
    partial class Register
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
            this.regUsernametxt = new System.Windows.Forms.TextBox();
            this.regPasswordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regUsernametxt
            // 
            this.regUsernametxt.Location = new System.Drawing.Point(492, 247);
            this.regUsernametxt.Name = "regUsernametxt";
            this.regUsernametxt.Size = new System.Drawing.Size(276, 27);
            this.regUsernametxt.TabIndex = 0;
            this.regUsernametxt.TextChanged += new System.EventHandler(this.regUsernametxt_TextChanged);
            // 
            // regPasswordtxt
            // 
            this.regPasswordtxt.Location = new System.Drawing.Point(492, 330);
            this.regPasswordtxt.Name = "regPasswordtxt";
            this.regPasswordtxt.Size = new System.Drawing.Size(276, 27);
            this.regPasswordtxt.TabIndex = 1;
            this.regPasswordtxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // regbtn
            // 
            this.regbtn.Location = new System.Drawing.Point(567, 431);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(94, 29);
            this.regbtn.TabIndex = 4;
            this.regbtn.Text = "Register";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(513, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 67);
            this.label3.TabIndex = 6;
            this.label3.Text = "Register";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(985, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 623);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regPasswordtxt);
            this.Controls.Add(this.regUsernametxt);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regUsernametxt;
        private System.Windows.Forms.TextBox regPasswordtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}