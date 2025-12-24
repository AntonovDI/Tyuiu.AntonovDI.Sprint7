using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AntonovDI.Sprint7.Project.V5.Lib;
using System.Data;
using System.IO;

namespace Tyuiu.AntonovDI.Sprint7.Project.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadCsv_ReturnsDataTable()
        {
            string path = "test.csv";
            File.WriteAllText(path, "1,Test,Россия");

            DataService ds = new DataService();
            string[] columns = { "ID", "Название", "Страна" };

            DataTable table = ds.LoadCsv(path, columns);

            Assert.AreEqual(1, table.Rows.Count);
            Assert.AreEqual("Test", table.Rows[0][1]);
        }

        [TestMethod]
        public void Search_ReturnsFilteredRows()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Название");
            table.Rows.Add("Телефон");
            table.Rows.Add("Ноутбук");

            DataService ds = new DataService();
            var view = ds.Search(table, "Название", "Тел");

            Assert.AreEqual(1, view.Count);
        }
    }
}
