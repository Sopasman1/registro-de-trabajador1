namespace registro_de_trabajador
{
    partial class Form1
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
            label1 = new Label();
            panel1 = new Panel();
            passwordtbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Enterbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 10);
            label1.Name = "label1";
            label1.Size = new Size(210, 30);
            label1.TabIndex = 0;
            label1.Text = "Worker Registration";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 57);
            panel1.TabIndex = 1;
            // 
            // passwordtbox
            // 
            passwordtbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordtbox.Location = new Point(120, 112);
            passwordtbox.Multiline = true;
            passwordtbox.Name = "passwordtbox";
            passwordtbox.Size = new Size(265, 46);
            passwordtbox.TabIndex = 2;
            passwordtbox.KeyPress += passwordtbox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 94);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(204, 161);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 4;
            label3.Text = "Enter Password";
            // 
            // Enterbtn
            // 
            Enterbtn.Location = new Point(217, 236);
            Enterbtn.Name = "Enterbtn";
            Enterbtn.Size = new Size(75, 23);
            Enterbtn.TabIndex = 5;
            Enterbtn.Text = "Enter";
            Enterbtn.UseVisualStyleBackColor = true;
            Enterbtn.Click += Enterbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 271);
            Controls.Add(Enterbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordtbox);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox passwordtbox;
        private Label label2;
        private Label label3;
        private Button Enterbtn;
    }
}
