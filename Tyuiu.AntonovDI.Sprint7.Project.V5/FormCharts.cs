using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5
{
    public partial class FormCharts : Form
    {
        private readonly DataTable productsTable;

        public FormCharts(DataTable table)
        {
            InitializeComponent();
            productsTable = table;
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (productsTable == null || productsTable.Rows.Count == 0)
                return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            DrawPriceChart(g);
            DrawQuantityHistogram(g);
        }

        // ======== ГРАФИК ЦЕН (ТОЛЬКО ЦИФРЫ) ========
        private void DrawPriceChart(Graphics g)
        {
            int startX = 60;
            int startY = 50;
            int width = ClientSize.Width - 100;
            int height = 200;

            Pen axisPen = new Pen(Color.Black, 2);
            Pen linePen = new Pen(Color.Blue, 2);
            Brush pointBrush = Brushes.Red;
            Font valueFont = new Font("Segoe UI", 8);

            // оси
            g.DrawLine(axisPen, startX, startY, startX, startY + height);
            g.DrawLine(axisPen, startX, startY + height, startX + width, startY + height);

            decimal maxPrice = productsTable.AsEnumerable()
                .Max(r => Convert.ToDecimal(r["Цена (руб)"]));

            int count = productsTable.Rows.Count;
            float stepX = count > 1 ? (float)width / (count - 1) : width;

            PointF? prev = null;

            for (int i = 0; i < count; i++)
            {
                decimal price = Convert.ToDecimal(productsTable.Rows[i]["Цена (руб)"]);

                float x = startX + i * stepX;
                float y = startY + height - (float)(price / maxPrice * height);

                if (prev != null)
                    g.DrawLine(linePen, prev.Value, new PointF(x, y));

                // точка
                g.FillEllipse(pointBrush, x - 3, y - 3, 6, 6);

                // ТОЛЬКО ЦИФРА
                g.DrawString(
                    price.ToString("0"),
                    valueFont,
                    Brushes.Black,
                    x - 10,
                    y - 18
                );

                prev = new PointF(x, y);
            }
        }

        // ======== ГИСТОГРАММА (ТОЛЬКО ЦИФРЫ) ========
        private void DrawQuantityHistogram(Graphics g)
        {
            int startX = 60;
            int startY = 320;
            int width = ClientSize.Width - 100;
            int height = 200;

            Pen axisPen = new Pen(Color.Black, 2);
            Brush barBrush = Brushes.Green;
            Font valueFont = new Font("Segoe UI", 8);

            // оси
            g.DrawLine(axisPen, startX, startY, startX, startY + height);
            g.DrawLine(axisPen, startX, startY + height, startX + width, startY + height);

            int maxQty = productsTable.AsEnumerable()
                .Max(r => Convert.ToInt32(r["Кол-во на складе"]));

            int count = productsTable.Rows.Count;
            float barWidth = (float)width / count;

            for (int i = 0; i < count; i++)
            {
                int qty = Convert.ToInt32(productsTable.Rows[i]["Кол-во на складе"]);
                float barHeight = (float)qty / maxQty * height;

                float x = startX + i * barWidth;
                float y = startY + height - barHeight;

                // столбец
                g.FillRectangle(
                    barBrush,
                    x + 3,
                    y,
                    barWidth - 6,
                    barHeight
                );

                // ТОЛЬКО ЦИФРА
                g.DrawString(
                    qty.ToString(),
                    valueFont,
                    Brushes.Black,
                    x + barWidth / 2 - 8,
                    y - 15
                );
            }
        }
    }
}
