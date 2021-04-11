
namespace Weather
{
    partial class Form1
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
            this.connect_btn = new System.Windows.Forms.Button();
            this.console_output_tb = new System.Windows.Forms.RichTextBox();
            this.token_tb = new System.Windows.Forms.TextBox();
            this.token_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(61, 282);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(546, 34);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // console_output_tb
            // 
            this.console_output_tb.Location = new System.Drawing.Point(61, 38);
            this.console_output_tb.Name = "console_output_tb";
            this.console_output_tb.Size = new System.Drawing.Size(546, 238);
            this.console_output_tb.TabIndex = 1;
            this.console_output_tb.Text = "";
            // 
            // token_tb
            // 
            this.token_tb.Location = new System.Drawing.Point(61, 12);
            this.token_tb.Name = "token_tb";
            this.token_tb.Size = new System.Drawing.Size(546, 20);
            this.token_tb.TabIndex = 2;
            // 
            // token_l
            // 
            this.token_l.AutoSize = true;
            this.token_l.Location = new System.Drawing.Point(11, 15);
            this.token_l.Name = "token_l";
            this.token_l.Size = new System.Drawing.Size(38, 13);
            this.token_l.TabIndex = 3;
            this.token_l.Text = "Token";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 328);
            this.Controls.Add(this.token_l);
            this.Controls.Add(this.token_tb);
            this.Controls.Add(this.console_output_tb);
            this.Controls.Add(this.connect_btn);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.RichTextBox console_output_tb;
        private System.Windows.Forms.TextBox token_tb;
        private System.Windows.Forms.Label token_l;
    }
}

