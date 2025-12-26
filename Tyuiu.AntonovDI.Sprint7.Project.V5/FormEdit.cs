using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    public partial class FormEdit : Form
    {
        private readonly DataTable table;
        private readonly DataTable sellers;
        private readonly bool isEdit;
        private readonly DataRow editRow;
        private readonly string tableName;

        public FormEdit(
            DataTable table,
            DataTable sellers,
            bool isEdit,
            DataRow row,
            string tableName)
        {
            InitializeComponent();

            this.table = table;
            this.sellers = sellers;
            this.isEdit = isEdit;
            this.editRow = row;
            this.tableName = tableName;

            InitForm();
            Shown += FormEdit_Shown;
        }

        // ================= ИНИЦИАЛИЗАЦИЯ =================
        private void InitForm()
        {
            if (tableName == "Товары")
            {
                panelProducts.Visible = true;
                panelSellers.Visible = false;

                comboSeller.DataSource = sellers;
                comboSeller.DisplayMember = "ФИО";
                comboSeller.ValueMember = "ID продавца";

                if (!isEdit)
                    textId.Text = GetNextId("ID товара").ToString();
            }
            else
            {
                panelProducts.Visible = false;
                panelSellers.Visible = true;

                if (!isEdit)
                    textSellerId.Text = GetNextId("ID продавца").ToString();
            }
        }

        // ================= ПОСЛЕ ПОКАЗА =================
        private void FormEdit_Shown(object sender, EventArgs e)
        {
            if (!isEdit) return;

            if (tableName == "Товары")
                LoadProduct();
            else
                LoadSeller();
        }

        // ================= ЗАГРУЗКА =================
        private void LoadProduct()
        {
            textId.Text = editRow["ID товара"].ToString();
            textName.Text = editRow["Наименование"].ToString();
            textCountry.Text = editRow["Страна производитель"].ToString();
            textQty.Text = editRow["Кол-во на складе"].ToString();
            textPrice.Text = editRow["Цена (руб)"].ToString();

            string sellerId = editRow["ID продавца"].ToString();

            for (int i = 0; i < comboSeller.Items.Count; i++)
            {
                if (comboSeller.Items[i] is DataRowView drv)
                {
                    if (drv["ID продавца"].ToString() == sellerId)
                    {
                        comboSeller.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void LoadSeller()
        {
            textSellerId.Text = editRow["ID продавца"].ToString();
            textFio.Text = editRow["ФИО"].ToString();
            textPhone.Text = editRow["Телефон"].ToString();
        }

        // ================= СОХРАНЕНИЕ =================
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (tableName == "Товары")
                SaveProduct();
            else
                SaveSeller();
        }

        private void SaveProduct()
        {
            if (string.IsNullOrWhiteSpace(textName.Text) ||
                string.IsNullOrWhiteSpace(textCountry.Text) ||
                !int.TryParse(textQty.Text, out int qty) ||
                !decimal.TryParse(textPrice.Text, out decimal price))
            {
                MessageBox.Show("Проверьте ввод данных");
                return;
            }

            if (comboSeller.SelectedItem == null)
            {
                MessageBox.Show("Выберите продавца");
                return;
            }

            DataRow row = isEdit ? editRow : table.NewRow();

            row["ID товара"] = int.Parse(textId.Text);
            row["Наименование"] = textName.Text.Trim();
            row["Страна производитель"] = textCountry.Text.Trim();
            row["Кол-во на складе"] = qty;
            row["Цена (руб)"] = price;

            // 🔥 ТОЛЬКО INT
            row["ID продавца"] =
                Convert.ToInt32(((DataRowView)comboSeller.SelectedItem)["ID продавца"]);

            if (!isEdit)
                table.Rows.Add(row);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void SaveSeller()
        {
            if (string.IsNullOrWhiteSpace(textFio.Text) ||
                string.IsNullOrWhiteSpace(textPhone.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            DataRow row = isEdit ? editRow : table.NewRow();

            row["ID продавца"] = int.Parse(textSellerId.Text);
            row["ФИО"] = textFio.Text.Trim();
            row["Телефон"] = textPhone.Text.Trim();

            if (!isEdit)
                table.Rows.Add(row);

            DialogResult = DialogResult.OK;
            Close();
        }

        // ================= ВСПОМОГАТЕЛЬНОЕ =================
        private int GetNextId(string column)
        {
            return table.AsEnumerable().Any()
                ? table.AsEnumerable().Max(r => Convert.ToInt32(r[column])) + 1
                : 1;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
