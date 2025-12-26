using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    public partial class FormFilter : Form
    {
        public string ResultFilter { get; private set; }

        private readonly DataTable table;
        private readonly string tableName;
        private readonly string oldFilter;

        public FormFilter(DataTable table, string tableName, string oldFilter)
        {
            InitializeComponent();

            this.table = table;
            this.tableName = tableName;
            this.oldFilter = oldFilter ?? "";

            ResultFilter = this.oldFilter;

            InitForm();
        }

        // ================= ИНИЦИАЛИЗАЦИЯ =================
        private void InitForm()
        {
            if (tableName == "Товары")
            {
                panelProducts.Visible = true;
                panelSellers.Visible = false;

                var countries = table.AsEnumerable()
                    .Select(r => r["Страна производитель"].ToString())
                    .Distinct()
                    .OrderBy(x => x)
                    .ToArray();

                checkedListCountries.Items.Clear();
                checkedListCountries.Items.AddRange(countries);
            }
            else
            {
                panelProducts.Visible = false;
                panelSellers.Visible = true;
            }
        }

        // ================= ПРИМЕНИТЬ =================
        private void buttonApply_Click(object sender, EventArgs e)
        {
            StringBuilder newFilter = new StringBuilder();

            void Add(string condition)
            {
                if (newFilter.Length > 0)
                    newFilter.Append(" AND ");

                newFilter.Append(condition);
            }

            if (tableName == "Товары")
            {
                if (int.TryParse(textIdFrom.Text, out int idFrom))
                    Add($"[ID товара] >= {idFrom}");

                if (int.TryParse(textIdTo.Text, out int idTo))
                    Add($"[ID товара] <= {idTo}");

                if (!string.IsNullOrWhiteSpace(textName.Text))
                    Add($"[Наименование] LIKE '%{Escape(textName.Text)}%'");

                if (checkedListCountries.CheckedItems.Count > 0)
                {
                    string countries = string.Join(" OR ",
                        checkedListCountries.CheckedItems
                            .Cast<string>()
                            .Select(c => $"[Страна производитель] = '{Escape(c)}'"));

                    Add("(" + countries + ")");
                }

                if (int.TryParse(textQtyFrom.Text, out int qtyFrom))
                    Add($"[Кол-во на складе] >= {qtyFrom}");

                if (int.TryParse(textQtyTo.Text, out int qtyTo))
                    Add($"[Кол-во на складе] <= {qtyTo}");

                if (decimal.TryParse(textPriceFrom.Text, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out decimal priceFrom))
                    Add($"[Цена (руб)] >= {priceFrom.ToString(CultureInfo.InvariantCulture)}");

                if (decimal.TryParse(textPriceTo.Text, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out decimal priceTo))
                    Add($"[Цена (руб)] <= {priceTo.ToString(CultureInfo.InvariantCulture)}");

                if (int.TryParse(textSellerFrom.Text, out int sellerFrom))
                    Add($"[ID продавца] >= {sellerFrom}");

                if (int.TryParse(textSellerTo.Text, out int sellerTo))
                    Add($"[ID продавца] <= {sellerTo}");
            }
            else
            {
                if (int.TryParse(textSellerIdFrom.Text, out int sidFrom))
                    Add($"[ID продавца] >= {sidFrom}");

                if (int.TryParse(textSellerIdTo.Text, out int sidTo))
                    Add($"[ID продавца] <= {sidTo}");

                if (!string.IsNullOrWhiteSpace(textFio.Text))
                    Add($"[ФИО] LIKE '%{Escape(textFio.Text)}%'");

                if (!string.IsNullOrWhiteSpace(textPhone.Text))
                    Add($"[Телефон] LIKE '%{Escape(textPhone.Text)}%'");
            }

            if (!string.IsNullOrWhiteSpace(oldFilter) && newFilter.Length > 0)
                ResultFilter = $"({oldFilter}) AND ({newFilter})";
            else if (newFilter.Length > 0)
                ResultFilter = newFilter.ToString();
            else
                ResultFilter = oldFilter;

            DialogResult = DialogResult.OK;
            Close();
        }

        // ================= СБРОС =================
        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResultFilter = "";
            DialogResult = DialogResult.OK;
            Close();
        }

        // ================= ЭКРАНИРОВАНИЕ =================
        private static string Escape(string text)
        {
            return text.Replace("'", "''");
        }
    }
}
