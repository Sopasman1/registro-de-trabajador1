namespace registro_de_trabajador
{
    partial class Registro
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
            panel1 = new Panel();
            Salvardatos = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label5 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            edadtext = new TextBox();
            phonetext = new TextBox();
            emailtext = new TextBox();
            rfctext = new TextBox();
            curptext = new TextBox();
            apellidomtext = new TextBox();
            apellidotext = new TextBox();
            Nombretext = new TextBox();
            panel2 = new Panel();
            Datosdetrabajadores = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            button5 = new Button();
            borrarbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Datosdetrabajadores).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(Salvardatos);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(edadtext);
            panel1.Controls.Add(phonetext);
            panel1.Controls.Add(emailtext);
            panel1.Controls.Add(rfctext);
            panel1.Controls.Add(curptext);
            panel1.Controls.Add(apellidomtext);
            panel1.Controls.Add(apellidotext);
            panel1.Controls.Add(Nombretext);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 537);
            panel1.TabIndex = 0;
            // 
            // Salvardatos
            // 
            Salvardatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salvardatos.Location = new Point(311, 502);
            Salvardatos.Name = "Salvardatos";
            Salvardatos.Size = new Size(75, 23);
            Salvardatos.TabIndex = 15;
            Salvardatos.Text = "save data";
            Salvardatos.UseVisualStyleBackColor = true;
            Salvardatos.Click += button4_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.MediumTurquoise;
            label14.Location = new Point(260, 374);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 28;
            label14.Text = "label14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.MediumTurquoise;
            label13.Location = new Point(12, 374);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 27;
            label13.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(274, 330);
            label12.Name = "label12";
            label12.Size = new Size(95, 15);
            label12.TabIndex = 26;
            label12.Text = "Hours Worked";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(58, 330);
            label11.Name = "label11";
            label11.Size = new Size(29, 15);
            label11.TabIndex = 25;
            label11.Text = "Job";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(260, 196);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 24;
            label10.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 257);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 23;
            label5.Text = "Age";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(287, 82);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 22;
            label9.Text = "RFC";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 196);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(283, 141);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 20;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(283, 21);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 18;
            label6.Text = "CURP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 196);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 17;
            label4.Text = "Birthday Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 141);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 16;
            label3.Text = "Mother Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 82);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 15;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 21);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "2 hora", "3 hora", "4 hora", "5 hora", "6 hora", "7 hora", "8 hora" });
            comboBox2.Location = new Point(260, 348);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerentes", "Supervisor", "Operarios" });
            comboBox1.Location = new Point(12, 348);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 502);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 9;
            button1.Text = "Save to list";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // edadtext
            // 
            edadtext.Location = new Point(12, 275);
            edadtext.Name = "edadtext";
            edadtext.Size = new Size(154, 23);
            edadtext.TabIndex = 7;
            edadtext.KeyPress += edadtext_KeyPress;
            // 
            // phonetext
            // 
            phonetext.Location = new Point(227, 214);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(154, 23);
            phonetext.TabIndex = 6;
            phonetext.KeyPress += phonetext_KeyPress;
            // 
            // emailtext
            // 
            emailtext.Location = new Point(227, 159);
            emailtext.Name = "emailtext";
            emailtext.Size = new Size(154, 23);
            emailtext.TabIndex = 5;
            // 
            // rfctext
            // 
            rfctext.Location = new Point(227, 100);
            rfctext.Name = "rfctext";
            rfctext.Size = new Size(154, 23);
            rfctext.TabIndex = 4;
            // 
            // curptext
            // 
            curptext.Location = new Point(227, 39);
            curptext.Name = "curptext";
            curptext.Size = new Size(154, 23);
            curptext.TabIndex = 3;
            // 
            // apellidomtext
            // 
            apellidomtext.Location = new Point(12, 159);
            apellidomtext.Name = "apellidomtext";
            apellidomtext.Size = new Size(154, 23);
            apellidomtext.TabIndex = 2;
            apellidomtext.KeyPress += apellidomtext_KeyPress;
            // 
            // apellidotext
            // 
            apellidotext.Location = new Point(12, 100);
            apellidotext.Name = "apellidotext";
            apellidotext.Size = new Size(154, 23);
            apellidotext.TabIndex = 1;
            apellidotext.KeyPress += apellidotext_KeyPress;
            // 
            // Nombretext
            // 
            Nombretext.Location = new Point(12, 39);
            Nombretext.Name = "Nombretext";
            Nombretext.Size = new Size(154, 23);
            Nombretext.TabIndex = 0;
            Nombretext.KeyPress += Nombretext_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(Datosdetrabajadores);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(392, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 429);
            panel2.TabIndex = 1;
            // 
            // Datosdetrabajadores
            // 
            Datosdetrabajadores.AllowUserToOrderColumns = true;
            Datosdetrabajadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Datosdetrabajadores.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            Datosdetrabajadores.Dock = DockStyle.Fill;
            Datosdetrabajadores.Location = new Point(0, 0);
            Datosdetrabajadores.Name = "Datosdetrabajadores";
            Datosdetrabajadores.Size = new Size(910, 429);
            Datosdetrabajadores.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Last Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Mother Last Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Birthday Date";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Age";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "CURP";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "RFC";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Email";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Phone Number";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Job";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Hours Worked";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Salary";
            Column12.Name = "Column12";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Aquamarine;
            panel3.Controls.Add(button5);
            panel3.Controls.Add(borrarbtn);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(392, 429);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 108);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(145, 45);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 15;
            button5.Text = "Export";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // borrarbtn
            // 
            borrarbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrarbtn.Location = new Point(6, 45);
            borrarbtn.Name = "borrarbtn";
            borrarbtn.Size = new Size(103, 23);
            borrarbtn.TabIndex = 0;
            borrarbtn.Text = "Delete worker";
            borrarbtn.UseVisualStyleBackColor = true;
            borrarbtn.Click += borrarbtn_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 537);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Datosdetrabajadores).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox curptext;
        private TextBox apellidomtext;
        private TextBox apellidotext;
        private TextBox Nombretext;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox edadtext;
        private TextBox phonetext;
        private TextBox emailtext;
        private TextBox rfctext;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label12;
        private Label label11;
        private Panel panel2;
        private DataGridView Datosdetrabajadores;
        private Panel panel3;
        private Button borrarbtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Label label14;
        private Label label13;
        private Button Salvardatos;
        private Button button5;
    }
}