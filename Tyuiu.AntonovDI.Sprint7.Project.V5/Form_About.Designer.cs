using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    partial class Form_About
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox pictureBoxAuthor_ADI;
        private Label labelInfo_ADI;
        private Button buttonOk_ADI;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBoxAuthor_ADI = new PictureBox();
            labelInfo_ADI = new Label();
            buttonOk_ADI = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_ADI).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAuthor_ADI
            // 
            pictureBoxAuthor_ADI.Image = Image.FromFile(
                @"C:\Users\anton\Desktop\Тиу\source\repos\Tyuiu.AntonovDI.Sprint7\img\ava.jpg");
            pictureBoxAuthor_ADI.Location = new Point(10, 10);
            pictureBoxAuthor_ADI.Name = "pictureBoxAuthor_ADI";
            pictureBoxAuthor_ADI.Size = new Size(200, 280);
            pictureBoxAuthor_ADI.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAuthor_ADI.TabIndex = 0;
            pictureBoxAuthor_ADI.TabStop = false;
            // 
            // labelInfo_ADI
            // 
            labelInfo_ADI.Location = new Point(230, 10);
            labelInfo_ADI.Name = "labelInfo_ADI";
            labelInfo_ADI.Size = new Size(440, 260);
            labelInfo_ADI.TabIndex = 1;
            labelInfo_ADI.Text =
                "Оптовая база\n\n" +
                "Разработчик: Антонов Даниил Иванович\n" +
                "Группа: ИСТНб-25-1\n\n" +
                "Данное приложение предназначено для работы\n" +
                "с товарами и продавцами оптовой базы.\n\n" +
                "Функционал:\n" +
                "- Просмотр товаров\n" +
                "- Просмотр продавцов\n" +
                "- Поиск по данным";
            // 
            // buttonOk_ADI
            // 
            buttonOk_ADI.Location = new Point(60, 300);
            buttonOk_ADI.Name = "buttonOk_ADI";
            buttonOk_ADI.Size = new Size(100, 30);
            buttonOk_ADI.TabIndex = 2;
            buttonOk_ADI.Text = "OK";
            buttonOk_ADI.UseVisualStyleBackColor = true;
            buttonOk_ADI.Click += buttonOk_ADI_Click;
            // 
            // Form_About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 350);
            Controls.Add(pictureBoxAuthor_ADI);
            Controls.Add(labelInfo_ADI);
            Controls.Add(buttonOk_ADI);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_About";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_ADI).EndInit();
            ResumeLayout(false);
        }
    }
}
