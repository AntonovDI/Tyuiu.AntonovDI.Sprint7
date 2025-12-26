using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    partial class FormEdit
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelProducts;
        private Panel panelSellers;

        private TextBox textId;
        private TextBox textName;
        private TextBox textCountry;
        private TextBox textQty;
        private TextBox textPrice;
        private ComboBox comboSeller;

        private TextBox textSellerId;
        private TextBox textFio;
        private TextBox textPhone;

        private Button buttonSave;
        private Button buttonCancel;

        private Label labelId;
        private Label labelName;
        private Label labelCountry;
        private Label labelQty;
        private Label labelPrice;
        private Label labelSeller;

        private Label labelSellerId;
        private Label labelFio;
        private Label labelPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelProducts = new Panel();
            panelSellers = new Panel();

            textId = new TextBox();
            textName = new TextBox();
            textCountry = new TextBox();
            textQty = new TextBox();
            textPrice = new TextBox();
            comboSeller = new ComboBox();

            textSellerId = new TextBox();
            textFio = new TextBox();
            textPhone = new TextBox();

            labelId = new Label();
            labelName = new Label();
            labelCountry = new Label();
            labelQty = new Label();
            labelPrice = new Label();
            labelSeller = new Label();

            labelSellerId = new Label();
            labelFio = new Label();
            labelPhone = new Label();

            buttonSave = new Button();
            buttonCancel = new Button();

            SuspendLayout();

            // ================= PANEL PRODUCTS =================
            panelProducts.Location = new Point(10, 10);
            panelProducts.Size = new Size(420, 260);

            int labelX = 10;
            int inputX = 160;
            int y = 10;
            int step = 40;

            // ID
            labelId.Text = "ID товара:";
            labelId.Location = new Point(labelX, y);
            labelId.AutoSize = true;

            textId.Location = new Point(inputX, y - 3);
            textId.Size = new Size(220, 27);
            textId.ReadOnly = true;

            // Name
            y += step;
            labelName.Text = "Наименование:";
            labelName.Location = new Point(labelX, y);
            labelName.AutoSize = true;

            textName.Location = new Point(inputX, y - 3);
            textName.Size = new Size(220, 27);

            // Country
            y += step;
            labelCountry.Text = "Страна производитель:";
            labelCountry.Location = new Point(labelX, y);
            labelCountry.AutoSize = true;

            textCountry.Location = new Point(inputX, y - 3);
            textCountry.Size = new Size(220, 27);

            // Qty
            y += step;
            labelQty.Text = "Кол-во на складе:";
            labelQty.Location = new Point(labelX, y);
            labelQty.AutoSize = true;

            textQty.Location = new Point(inputX, y - 3);
            textQty.Size = new Size(220, 27);

            // Price
            y += step;
            labelPrice.Text = "Цена (руб):";
            labelPrice.Location = new Point(labelX, y);
            labelPrice.AutoSize = true;

            textPrice.Location = new Point(inputX, y - 3);
            textPrice.Size = new Size(220, 27);

            // Seller
            y += step;
            labelSeller.Text = "Продавец (ФИО):";
            labelSeller.Location = new Point(labelX, y);
            labelSeller.AutoSize = true;

            comboSeller.Location = new Point(inputX, y - 3);
            comboSeller.Size = new Size(220, 27);
            comboSeller.DropDownStyle = ComboBoxStyle.DropDownList;

            panelProducts.Controls.AddRange(new Control[]
            {
                labelId, textId,
                labelName, textName,
                labelCountry, textCountry,
                labelQty, textQty,
                labelPrice, textPrice,
                labelSeller, comboSeller
            });

            // ================= PANEL SELLERS =================
            panelSellers.Location = new Point(10, 10);
            panelSellers.Size = new Size(420, 180);

            y = 10;

            labelSellerId.Text = "ID продавца:";
            labelSellerId.Location = new Point(labelX, y);
            labelSellerId.AutoSize = true;

            textSellerId.Location = new Point(inputX, y - 3);
            textSellerId.Size = new Size(220, 27);
            textSellerId.ReadOnly = true;

            y += step;
            labelFio.Text = "ФИО:";
            labelFio.Location = new Point(labelX, y);
            labelFio.AutoSize = true;

            textFio.Location = new Point(inputX, y - 3);
            textFio.Size = new Size(220, 27);

            y += step;
            labelPhone.Text = "Телефон:";
            labelPhone.Location = new Point(labelX, y);
            labelPhone.AutoSize = true;

            textPhone.Location = new Point(inputX, y - 3);
            textPhone.Size = new Size(220, 27);

            panelSellers.Controls.AddRange(new Control[]
            {
                labelSellerId, textSellerId,
                labelFio, textFio,
                labelPhone, textPhone
            });

            // ================= BUTTONS =================
            buttonSave.Text = "Сохранить";
            buttonSave.Location = new Point(120, 280);
            buttonSave.Size = new Size(100, 30);
            buttonSave.Click += ButtonSave_Click;

            buttonCancel.Text = "Отмена";
            buttonCancel.Location = new Point(240, 280);
            buttonCancel.Size = new Size(100, 30);
            buttonCancel.Click += ButtonCancel_Click;

            // ================= FORM =================
            ClientSize = new Size(450, 330);
            Controls.Add(panelProducts);
            Controls.Add(panelSellers);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление / редактирование";

            ResumeLayout(false);
        }
    }
}
