using System.Windows.Forms;

namespace WinFormsApp1
{

    class Product
    {
        double price;
        string country;
        string name;
        string date;
        string description;
        void addProduct()
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = "aq";
            row.Cells[1].Value = 40.1;
            yourDataGridView.Rows.Add(row);
        }
    }

    class Food : Product
    {
        string expiry;
        int quantity;
        string measure;
    }

    class Book : Product
    {
        int pages;
        string publisher;
        string author;
    }




    internal static class Program
    {
      
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}