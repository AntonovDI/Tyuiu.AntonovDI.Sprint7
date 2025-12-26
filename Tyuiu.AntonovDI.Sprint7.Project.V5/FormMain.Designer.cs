namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FormMain));

            menuStripMain_ADI = new MenuStrip();
            menuMenu_ADI = new ToolStripMenuItem();
            menuAdd_ADI = new ToolStripMenuItem();
            menuEdit_ADI = new ToolStripMenuItem();
            menuDelete_ADI = new ToolStripMenuItem();
            menuStatistic_ADI = new ToolStripMenuItem();
            menuCharts_ADI = new ToolStripMenuItem();
            menuFilter_ADI = new ToolStripMenuItem();
            menuExport_ADI = new ToolStripMenuItem();
            menuGuide_ADI = new ToolStripMenuItem();
            menuAbout_ADI = new ToolStripMenuItem();
            menuExit_ADI = new ToolStripMenuItem();

            panelTop_ADI = new Panel();
            labelTable_ADI = new Label();
            comboBoxTable_ADI = new ComboBox();
            labelSearch_ADI = new Label();
            textBoxSearch_ADI = new TextBox();
            buttonResetSearch_ADI = new Button();

            dataGridViewMain_ADI = new DataGridView();

            menuStripMain_ADI.SuspendLayout();
            panelTop_ADI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_ADI).BeginInit();
            SuspendLayout();

            // ===== MenuStrip =====
            menuStripMain_ADI.Items.AddRange(new ToolStripItem[] {
                menuMenu_ADI
            });
            menuStripMain_ADI.Location = new Point(0, 0);
            menuStripMain_ADI.Name = "menuStripMain_ADI";
            menuStripMain_ADI.Size = new Size(900, 24);

            menuMenu_ADI.DropDownItems.AddRange(new ToolStripItem[] {
                menuAdd_ADI,
                menuEdit_ADI,
                menuDelete_ADI,
                new ToolStripSeparator(),
                menuStatistic_ADI,
                menuCharts_ADI,
                menuFilter_ADI,
                menuExport_ADI,
                new ToolStripSeparator(),
                menuGuide_ADI,
                menuAbout_ADI,
                new ToolStripSeparator(),
                menuExit_ADI
            });
            menuMenu_ADI.Text = "Меню";

            menuAdd_ADI.Text = "Добавить";
            menuAdd_ADI.Click += MenuAdd_ADI_Click;

            menuEdit_ADI.Text = "Изменить";
            menuEdit_ADI.Click += MenuEdit_ADI_Click;

            menuDelete_ADI.Text = "Удалить";
            menuDelete_ADI.Click += MenuDelete_ADI_Click;

            menuStatistic_ADI.Text = "Статистика";

            menuCharts_ADI.Text = "Диаграммы";
            menuCharts_ADI.Click += MenuCharts_ADI_Click;

            menuFilter_ADI.Text = "Фильтр";
            menuFilter_ADI.Click += MenuFilter_ADI_Click;

            menuExport_ADI.Text = "Экспорт CSV";
            menuExport_ADI.Click += MenuExport_ADI_Click;

            menuGuide_ADI.Text = "Руководство";
            menuGuide_ADI.Click += MenuGuide_ADI_Click;


            menuAbout_ADI.Text = "О программе";
            menuAbout_ADI.Click += MenuAbout_ADI_Click;

            menuExit_ADI.Text = "Выход";
            menuExit_ADI.Click += MenuExit_ADI_Click;

            // ===== Panel Top =====
            panelTop_ADI.BackColor = SystemColors.ControlLight;
            panelTop_ADI.Dock = DockStyle.Top;
            panelTop_ADI.Location = new Point(0, 24);
            panelTop_ADI.Name = "panelTop_ADI";
            panelTop_ADI.Size = new Size(900, 50);

            panelTop_ADI.Controls.Add(labelTable_ADI);
            panelTop_ADI.Controls.Add(comboBoxTable_ADI);
            panelTop_ADI.Controls.Add(labelSearch_ADI);
            panelTop_ADI.Controls.Add(textBoxSearch_ADI);
            panelTop_ADI.Controls.Add(buttonResetSearch_ADI);

            // ===== Label Table =====
            labelTable_ADI.AutoSize = true;
            labelTable_ADI.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            labelTable_ADI.Location = new Point(15, 15);
            labelTable_ADI.Text = "Таблица:";

            // ===== ComboBox =====
            comboBoxTable_ADI.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTable_ADI.Location = new Point(90, 14);
            comboBoxTable_ADI.Size = new Size(150, 23);

            // ===== Label Search =====
            labelSearch_ADI.AutoSize = true;
            labelSearch_ADI.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            labelSearch_ADI.Location = new Point(270, 15);
            labelSearch_ADI.Text = "Поиск:";

            // ===== TextBox Search =====
            textBoxSearch_ADI.Location = new Point(335, 14);
            textBoxSearch_ADI.Size = new Size(250, 23);

            // ===== Reset Button =====
            buttonResetSearch_ADI.Location = new Point(610, 12);
            buttonResetSearch_ADI.Size = new Size(120, 27);
            buttonResetSearch_ADI.Text = "Сбросить";

            // ===== DataGridView =====
            dataGridViewMain_ADI.AllowUserToAddRows = false;
            dataGridViewMain_ADI.AllowUserToDeleteRows = false;
            dataGridViewMain_ADI.ReadOnly = true;
            dataGridViewMain_ADI.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMain_ADI.Dock = DockStyle.Fill;
            dataGridViewMain_ADI.Location = new Point(0, 74);
            dataGridViewMain_ADI.Size = new Size(900, 476);

            // ===== Form =====
            ClientSize = new Size(900, 550);
            Controls.Add(dataGridViewMain_ADI);
            Controls.Add(panelTop_ADI);
            Controls.Add(menuStripMain_ADI);

            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain_ADI;
            Text = "Оптовая база";

            menuStripMain_ADI.ResumeLayout(false);
            menuStripMain_ADI.PerformLayout();
            panelTop_ADI.ResumeLayout(false);
            panelTop_ADI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_ADI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain_ADI;
        private ToolStripMenuItem menuMenu_ADI;
        private ToolStripMenuItem menuAdd_ADI;
        private ToolStripMenuItem menuEdit_ADI;
        private ToolStripMenuItem menuDelete_ADI;
        private ToolStripMenuItem menuStatistic_ADI;
        private ToolStripMenuItem menuCharts_ADI;
        private ToolStripMenuItem menuFilter_ADI;
        private ToolStripMenuItem menuExport_ADI;
        private ToolStripMenuItem menuGuide_ADI;
        private ToolStripMenuItem menuAbout_ADI;
        private ToolStripMenuItem menuExit_ADI;

        private Panel panelTop_ADI;
        private Label labelTable_ADI;
        private ComboBox comboBoxTable_ADI;
        private Label labelSearch_ADI;
        private TextBox textBoxSearch_ADI;
        private Button buttonResetSearch_ADI;

        private DataGridView dataGridViewMain_ADI;
    }
}
