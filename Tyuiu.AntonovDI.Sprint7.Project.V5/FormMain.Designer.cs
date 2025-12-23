namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 53);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(620, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(551, 15);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 3;
            label2.Text = "Поиск:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(337, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(257, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 1;
            label1.Text = "Таблица:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = Properties.Resources.cog;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(11, 6);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 15, 0);
            button1.Size = new Size(132, 37);
            button1.TabIndex = 0;
            button1.Text = "Меню";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 397);
            dataGridView1.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Оптовая база by Antonov";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}
