using System.Data;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public DataTable LoadCsv(string path, string[] columnNames)
        {
            DataTable table = new DataTable();

            foreach (string column in columnNames)
            {
                table.Columns.Add(column);
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                table.Rows.Add(values);
            }

            return table;
        }

        public DataView Search(DataTable table, string columnName, string searchText)
        {
            DataView view = table.DefaultView;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                view.RowFilter = "";
            }
            else
            {
                view.RowFilter = $"{columnName} LIKE '%{searchText}%'";
            }

            return view;
        }
    }
}
