namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    partial class FormGuide
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.richTextBoxGuide = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ===== Заголовок =====
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(260, 25);
            this.labelTitle.Text = "Руководство пользователя";

            // ===== RichTextBox =====
            this.richTextBoxGuide.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right));

            this.richTextBoxGuide.Location = new System.Drawing.Point(20, 55);
            this.richTextBoxGuide.Name = "richTextBoxGuide";
            this.richTextBoxGuide.ReadOnly = true;
            this.richTextBoxGuide.Size = new System.Drawing.Size(760, 430);
            this.richTextBoxGuide.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.richTextBoxGuide.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            // ===== Кнопка закрыть =====
            this.buttonClose.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;

            this.buttonClose.Location = new System.Drawing.Point(680, 500);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click +=
                new System.EventHandler(this.ButtonClose_Click);

            // ===== Form =====
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize =
                new System.Drawing.Size(800, 550);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.richTextBoxGuide);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormGuide";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Руководство";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RichTextBox richTextBoxGuide;
        private System.Windows.Forms.Button buttonClose;
    }
}
