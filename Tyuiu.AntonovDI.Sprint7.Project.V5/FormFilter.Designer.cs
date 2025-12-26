using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    partial class FormFilter
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelProducts;
        private Panel panelSellers;

        private Label labelIdRange;
        private TextBox textIdFrom;
        private TextBox textIdTo;

        private Label labelName;
        private TextBox textName;

        private Label labelCountry;
        private CheckedListBox checkedListCountries;

        private Label labelQty;
        private TextBox textQtyFrom;
        private TextBox textQtyTo;

        private Label labelPrice;
        private TextBox textPriceFrom;
        private TextBox textPriceTo;

        private Label labelSellerId;
        private TextBox textSellerFrom;
        private TextBox textSellerTo;

        private Label labelSellerIdRange;
        private TextBox textSellerIdFrom;
        private TextBox textSellerIdTo;

        private Label labelFio;
        private TextBox textFio;

        private Label labelPhone;
        private TextBox textPhone;

        private Button buttonApply;
        private Button buttonReset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            panelProducts = new Panel();
            panelSellers = new Panel();

            labelIdRange = new Label();
            textIdFrom = new TextBox();
            textIdTo = new TextBox();

            labelName = new Label();
            textName = new TextBox();

            labelCountry = new Label();
            checkedListCountries = new CheckedListBox();

            labelQty = new Label();
            textQtyFrom = new TextBox();
            textQtyTo = new TextBox();

            labelPrice = new Label();
            textPriceFrom = new TextBox();
            textPriceTo = new TextBox();

            labelSellerId = new Label();
            textSellerFrom = new TextBox();
            textSellerTo = new TextBox();

            labelSellerIdRange = new Label();
            textSellerIdFrom = new TextBox();
            textSellerIdTo = new TextBox();

            labelFio = new Label();
            textFio = new TextBox();

            labelPhone = new Label();
            textPhone = new TextBox();

            buttonApply = new Button();
            buttonReset = new Button();

            SuspendLayout();

            // ================= PANEL PRODUCTS =================
            panelProducts.Location = new Point(10, 10);
            panelProducts.Size = new Size(380, 430);

            labelIdRange.Text = "ID товара (от / до):";
            labelIdRange.Location = new Point(10, 10);
            labelIdRange.AutoSize = true;

            textIdFrom.Location = new Point(10, 30);
            textIdFrom.Size = new Size(80, 23);

            textIdTo.Location = new Point(100, 30);
            textIdTo.Size = new Size(80, 23);

            labelName.Text = "Наименование:";
            labelName.Location = new Point(10, 60);
            labelName.AutoSize = true;

            textName.Location = new Point(10, 80);
            textName.Size = new Size(200, 23);

            labelCountry.Text = "Страна производитель:";
            labelCountry.Location = new Point(10, 110);
            labelCountry.AutoSize = true;

            checkedListCountries.Location = new Point(10, 130);
            checkedListCountries.Size = new Size(200, 80);

            labelQty.Text = "Кол-во на складе (от / до):";
            labelQty.Location = new Point(10, 220);
            labelQty.AutoSize = true;

            textQtyFrom.Location = new Point(10, 240);
            textQtyFrom.Size = new Size(80, 23);

            textQtyTo.Location = new Point(100, 240);
            textQtyTo.Size = new Size(80, 23);

            labelPrice.Text = "Цена (от / до):";
            labelPrice.Location = new Point(10, 270);
            labelPrice.AutoSize = true;

            textPriceFrom.Location = new Point(10, 290);
            textPriceFrom.Size = new Size(80, 23);

            textPriceTo.Location = new Point(100, 290);
            textPriceTo.Size = new Size(80, 23);

            labelSellerId.Text = "ID продавца (от / до):";
            labelSellerId.Location = new Point(10, 320);
            labelSellerId.AutoSize = true;

            textSellerFrom.Location = new Point(10, 340);
            textSellerFrom.Size = new Size(80, 23);

            textSellerTo.Location = new Point(100, 340);
            textSellerTo.Size = new Size(80, 23);

            panelProducts.Controls.AddRange(new Control[] {
                labelIdRange, textIdFrom, textIdTo,
                labelName, textName,
                labelCountry, checkedListCountries,
                labelQty, textQtyFrom, textQtyTo,
                labelPrice, textPriceFrom, textPriceTo,
                labelSellerId, textSellerFrom, textSellerTo
            });

            // ================= PANEL SELLERS =================
            panelSellers.Location = new Point(10, 10);
            panelSellers.Size = new Size(380, 200);

            labelSellerIdRange.Text = "ID продавца (от / до):";
            labelSellerIdRange.Location = new Point(10, 10);
            labelSellerIdRange.AutoSize = true;

            textSellerIdFrom.Location = new Point(10, 30);
            textSellerIdFrom.Size = new Size(80, 23);

            textSellerIdTo.Location = new Point(100, 30);
            textSellerIdTo.Size = new Size(80, 23);

            labelFio.Text = "ФИО:";
            labelFio.Location = new Point(10, 60);
            labelFio.AutoSize = true;

            textFio.Location = new Point(10, 80);
            textFio.Size = new Size(250, 23);

            labelPhone.Text = "Телефон:";
            labelPhone.Location = new Point(10, 110);
            labelPhone.AutoSize = true;

            textPhone.Location = new Point(10, 130);
            textPhone.Size = new Size(250, 23);

            panelSellers.Controls.AddRange(new Control[] {
                labelSellerIdRange, textSellerIdFrom, textSellerIdTo,
                labelFio, textFio,
                labelPhone, textPhone
            });

            // ================= BUTTONS =================
            buttonApply.Text = "Применить";
            buttonApply.Location = new Point(420, 50);
            buttonApply.Size = new Size(140, 35);
            buttonApply.Click += buttonApply_Click;

            buttonReset.Text = "Сбросить фильтр";
            buttonReset.Location = new Point(420, 100);
            buttonReset.Size = new Size(140, 35);
            buttonReset.Click += buttonReset_Click;

            // ================= FORM =================
            ClientSize = new Size(600, 460);
            Controls.Add(panelProducts);
            Controls.Add(panelSellers);
            Controls.Add(buttonApply);
            Controls.Add(buttonReset);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фильтр";

            ResumeLayout(false);
        }
    }
}
