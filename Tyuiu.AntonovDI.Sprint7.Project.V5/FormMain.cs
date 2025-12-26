using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint7.Project.V5.Lib;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        private readonly DataService ds_ADI = new DataService();

        private DataTable table_ADI;          
        private DataTable sellersTable_ADI;   

        private const string pathProducts_ADI =
            @"C:\Users\anton\Desktop\Тиу\source\repos\Tyuiu.AntonovDI.Sprint7\Files\Commodities.csv";

        private const string pathSellers_ADI =
            @"C:\Users\anton\Desktop\Тиу\source\repos\Tyuiu.AntonovDI.Sprint7\Files\Seller.csv";

        private string productsFilter_ADI = "";
        private string sellersFilter_ADI = "";

        public FormMain()
        {
            InitializeComponent();

            InitComboBox_ADI();
            LoadSellersOnce_ADI();
            LoadProducts_ADI();
            BindEvents_ADI();
        }

        private void InitComboBox_ADI()
        {
            comboBoxTable_ADI.Items.Clear();
            comboBoxTable_ADI.Items.Add("Товары");
            comboBoxTable_ADI.Items.Add("Продавцы");
            comboBoxTable_ADI.SelectedIndex = 0;
        }

        private void BindEvents_ADI()
        {
            comboBoxTable_ADI.SelectedIndexChanged += ComboBoxTable_ADI_SelectedIndexChanged;
            textBoxSearch_ADI.TextChanged += TextBoxSearch_ADI_TextChanged;
            buttonResetSearch_ADI.Click += ButtonResetSearch_ADI_Click;

            menuStatistic_ADI.Click += MenuStatistic_ADI_Click;
            menuAbout_ADI.Click += MenuAbout_ADI_Click;
            menuExit_ADI.Click += MenuExit_ADI_Click;
        }

        private void LoadSellersOnce_ADI()
        {
            sellersTable_ADI = ds_ADI.LoadCsv(
                pathSellers_ADI,
                new[] { "ID продавца", "ФИО", "Телефон" }
            );
        }

        private void LoadProducts_ADI()
        {
            table_ADI = ds_ADI.LoadCsv(
                pathProducts_ADI,
                new[]
                {
                    "ID товара",
                    "Наименование",
                    "Страна производитель",
                    "Кол-во на складе",
                    "Цена (руб)",
                    "ID продавца"
                });

            dataGridViewMain_ADI.DataSource = table_ADI;
        }

        private void LoadSellers_ADI()
        {
            table_ADI = sellersTable_ADI;
            dataGridViewMain_ADI.DataSource = table_ADI;
        }

        private void SaveCurrentTable()
        {
            if (comboBoxTable_ADI.Text == "Товары")
                ds_ADI.SaveTableToCsv(table_ADI, pathProducts_ADI);
            else
                ds_ADI.SaveTableToCsv(table_ADI, pathSellers_ADI);
        }


        private void MenuAdd_ADI_Click(object sender, EventArgs e)
        {
            using (FormEdit frm = new FormEdit(
                table_ADI,
                sellersTable_ADI,
                false,
                null,
                comboBoxTable_ADI.SelectedItem.ToString()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SaveCurrentTable();
                    dataGridViewMain_ADI.Refresh();
                }
            }
        }


        private void MenuEdit_ADI_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewMain_ADI.CurrentRow?.DataBoundItem is DataRowView drv))
            {
                MessageBox.Show("Выберите запись");
                return;
            }

            using (FormEdit frm = new FormEdit(
                table_ADI,
                sellersTable_ADI,
                true,
                drv.Row,
                comboBoxTable_ADI.SelectedItem.ToString()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SaveCurrentTable();
                    dataGridViewMain_ADI.Refresh();
                }
            }
        }

        private void MenuDelete_ADI_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewMain_ADI.CurrentRow?.DataBoundItem is DataRowView drv))
                return;

            if (MessageBox.Show(
                "Удалить запись?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            table_ADI.Rows.Remove(drv.Row);
            SaveCurrentTable();
        }

        private void TextBoxSearch_ADI_TextChanged(object sender, EventArgs e)
        {
            if (table_ADI == null) return;

            dataGridViewMain_ADI.DataSource =
                comboBoxTable_ADI.Text == "Товары"
                    ? ds_ADI.Search(table_ADI, "Наименование", textBoxSearch_ADI.Text)
                    : ds_ADI.Search(table_ADI, "ФИО", textBoxSearch_ADI.Text);
        }

        private void ButtonResetSearch_ADI_Click(object sender, EventArgs e)
        {
            textBoxSearch_ADI.Clear();
            dataGridViewMain_ADI.DataSource = table_ADI;
        }

        private void ComboBoxTable_ADI_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSearch_ADI.Clear();

            if (comboBoxTable_ADI.Text == "Товары")
            {
                LoadProducts_ADI();
                table_ADI.DefaultView.RowFilter = productsFilter_ADI;
            }
            else
            {
                LoadSellers_ADI();
                table_ADI.DefaultView.RowFilter = sellersFilter_ADI;
            }
        }


        private void MenuStatistic_ADI_Click(object sender, EventArgs e)
        {
            if (table_ADI == null || table_ADI.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста");
                return;
            }

            string tableName = comboBoxTable_ADI.Text;
            string text = tableName == "Товары"
                ? GetProductsStatistics()
                : GetSellersStatistics();

            if (MessageBox.Show(
                text + "\n\nСохранить в файл?",
                "Статистика",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveStatisticsToFile(text, tableName);
            }
        }

        private string GetSellersStatistics()
        {
            return
                "СТАТИСТИКА ПО ПРОДАВЦАМ\n\n" +
                $"Количество записей: {table_ADI.Rows.Count}";
        }

        private string GetProductsStatistics()
        {
            string popularProduct = table_ADI.AsEnumerable()
                .GroupBy(r => r["Наименование"].ToString())
                .OrderByDescending(g => g.Count())
                .First().Key;

            string popularCountry = table_ADI.AsEnumerable()
                .GroupBy(r => r["Страна производитель"].ToString())
                .OrderByDescending(g => g.Count())
                .First().Key;

            decimal maxPrice = table_ADI.AsEnumerable()
                .Max(r => Convert.ToDecimal(r["Цена (руб)"]));

            decimal minPrice = table_ADI.AsEnumerable()
                .Min(r => Convert.ToDecimal(r["Цена (руб)"]));

            return
                "СТАТИСТИКА ПО ТОВАРАМ\n\n" +
                $"Количество записей: {table_ADI.Rows.Count}\n" +
                $"Популярное наименование: {popularProduct}\n" +
                $"Популярная страна: {popularCountry}\n" +
                $"Макс. цена: {maxPrice}\n" +
                $"Мин. цена: {minPrice}";
        }

        private void SaveStatisticsToFile(string text, string tableName)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                FileName = $"статистика_{tableName}_{DateTime.Now:dd_MM_yyyy}.txt"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, text, Encoding.UTF8);
                MessageBox.Show("Файл сохранён");
            }
        }

        private void MenuGuide_ADI_Click(object sender, EventArgs e)
        {
            new FormGuide().ShowDialog();
        }

        private void MenuAbout_ADI_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog();
        }

        private void MenuExit_ADI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuExport_ADI_Click(object sender, EventArgs e)
        {
            if (table_ADI == null || table_ADI.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста, нечего экспортировать");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv",
                FileName = $"экспорт_{comboBoxTable_ADI.Text}_{DateTime.Now:dd_MM_yyyy}.csv"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ds_ADI.SaveTableToCsv(table_ADI, dlg.FileName);
                MessageBox.Show("Экспорт выполнен успешно");
            }
        }

        private void MenuFilter_ADI_Click(object sender, EventArgs e)
        {
            string tableName = comboBoxTable_ADI.Text;
            string oldFilter = tableName == "Товары"
                ? productsFilter_ADI
                : sellersFilter_ADI;

            using (FormFilter frm = new FormFilter(table_ADI, tableName, oldFilter))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (tableName == "Товары")
                        productsFilter_ADI = frm.ResultFilter;
                    else
                        sellersFilter_ADI = frm.ResultFilter;

                    table_ADI.DefaultView.RowFilter = frm.ResultFilter;
                }
            }
        }

        private void MenuCharts_ADI_Click(object sender, EventArgs e)
        {
            if (comboBoxTable_ADI.Text != "Товары")
            {
                MessageBox.Show("Диаграммы доступны только для товаров");
                return;
            }

            new FormCharts(table_ADI).ShowDialog();
        }
    }
}
