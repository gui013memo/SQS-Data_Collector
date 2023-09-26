namespace DR_Collector
{
    partial class Main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_Console = new TextBox();
            btn_Get = new Button();
            dtp_From = new DateTimePicker();
            lb_From = new Label();
            lb_To = new Label();
            dtp_To = new DateTimePicker();
            SuspendLayout();
            // 
            // tb_Console
            // 
            tb_Console.Location = new Point(12, 146);
            tb_Console.Multiline = true;
            tb_Console.Name = "tb_Console";
            tb_Console.ReadOnly = true;
            tb_Console.Size = new Size(513, 292);
            tb_Console.TabIndex = 0;
            // 
            // btn_Get
            // 
            btn_Get.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Get.Location = new Point(219, 98);
            btn_Get.Name = "btn_Get";
            btn_Get.Size = new Size(100, 42);
            btn_Get.TabIndex = 2;
            btn_Get.Text = "GET";
            btn_Get.UseVisualStyleBackColor = true;
            btn_Get.Click += btn_Get_Click;
            // 
            // dtp_From
            // 
            dtp_From.Location = new Point(12, 48);
            dtp_From.Name = "dtp_From";
            dtp_From.Size = new Size(250, 27);
            dtp_From.TabIndex = 3;
            // 
            // lb_From
            // 
            lb_From.AutoSize = true;
            lb_From.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_From.Location = new Point(101, 25);
            lb_From.Name = "lb_From";
            lb_From.Size = new Size(46, 20);
            lb_From.TabIndex = 4;
            lb_From.Text = "From";
            // 
            // lb_To
            // 
            lb_To.AutoSize = true;
            lb_To.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_To.Location = new Point(364, 25);
            lb_To.Name = "lb_To";
            lb_To.Size = new Size(26, 20);
            lb_To.TabIndex = 6;
            lb_To.Text = "To";
            // 
            // dtp_To
            // 
            dtp_To.Location = new Point(275, 48);
            dtp_To.Name = "dtp_To";
            dtp_To.Size = new Size(250, 27);
            dtp_To.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(537, 450);
            Controls.Add(lb_To);
            Controls.Add(dtp_To);
            Controls.Add(lb_From);
            Controls.Add(dtp_From);
            Controls.Add(btn_Get);
            Controls.Add(tb_Console);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Console;
        private Button btn_Get;
        private DateTimePicker dtp_From;
        private Label lb_From;
        private Label lb_To;
        private DateTimePicker dtp_To;
    }
}