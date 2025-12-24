using System.Data;
using Tyuiu.AntonovDI.Sprint7.Project.V5.Lib;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        private readonly DataService ds_ADI = new DataService();
        private DataTable table_ADI;

        private const string pathProducts_ADI =
            @"C:\Users\anton\Desktop\Тиу\source\repos\Tyuiu.AntonovDI.Sprint7\Files\Commodities.csv";

        private const string pathSellers_ADI =
            @"C:\Users\anton\Desktop\Тиу\source\repos\Tyuiu.AntonovDI.Sprint7\Files\Seller.csv";

        public FormMain()
        {
            InitializeComponent();
            InitComboBox_ADI();
            LoadProducts_ADI();
            BindEvents_ADI();
        }

        // ================== ИНИЦИАЛИЗАЦИЯ ==================

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

            menuAbout_ADI.Click += MenuAbout_ADI_Click;
            menuExit_ADI.Click += MenuExit_ADI_Click;
        }

        // ================== ЗАГРУЗКА ТАБЛИЦ ==================

        private void LoadProducts_ADI()
        {
            string[] columns =
            {
                "ID товара",
                "Наименование",
                "Страна производитель",
                "Кол-во на складе",
                "Цена (руб)",
                "ID продавца"
            };

            table_ADI = ds_ADI.LoadCsv(pathProducts_ADI, columns);
            dataGridViewMain_ADI.DataSource = table_ADI;
            dataGridViewMain_ADI.ReadOnly = true;
        }

        private void LoadSellers_ADI()
        {
            string[] columns =
            {
                "ID продавца",
                "ФИО",
                "Телефон"
            };

            table_ADI = ds_ADI.LoadCsv(pathSellers_ADI, columns);
            dataGridViewMain_ADI.DataSource = table_ADI;
            dataGridViewMain_ADI.ReadOnly = true;
        }

        // ================== СОБЫТИЯ ==================

        private void ComboBoxTable_ADI_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSearch_ADI.Clear();

            if (comboBoxTable_ADI.SelectedItem.ToString() == "Товары")
            {
                LoadProducts_ADI();
            }
            else
            {
                LoadSellers_ADI();
            }
        }

        private void TextBoxSearch_ADI_TextChanged(object sender, EventArgs e)
        {
            if (table_ADI == null) return;

            if (comboBoxTable_ADI.SelectedItem.ToString() == "Товары")
            {
                dataGridViewMain_ADI.DataSource =
                    ds_ADI.Search(table_ADI, "Наименование", textBoxSearch_ADI.Text);
            }
            else
            {
                dataGridViewMain_ADI.DataSource =
                    ds_ADI.Search(table_ADI, "ID продавца", textBoxSearch_ADI.Text);
            }
        }

        private void ButtonResetSearch_ADI_Click(object sender, EventArgs e)
        {
            textBoxSearch_ADI.Clear();
        }

        private void MenuAbout_ADI_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Оптовая база\n\nРазработал: Антонов Д.И.\nSprint 7",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MenuExit_ADI_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
