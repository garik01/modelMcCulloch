using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Dynamic;
using System.Data;

namespace modelMcCulloch
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable dataTable = new DataTable();
        int count = 0;
        int rows = 0;
        public MainWindow()
        {
            InitializeComponent();
            buildTable();
        }

        private void buildTable()
        {
            // Пробник
            //dataTable.Columns.Add("experience", Type.GetType("System.Int32"));
            //dataTable.Columns.Add("u", Type.GetType("System.Double"));
            //dataTable.Columns.Add("y", Type.GetType("System.Double"));
            //dataTable.Columns.Add("d", Type.GetType("System.Double"));
            //DataTable employeeData = CreateDataTable();
            //gridEmployees.DataContext = employeeData.DefaultView;

            DataGridTextColumn experience = new DataGridTextColumn();
            experience.Header = "Опыт";
            experience.Binding = new Binding("experience");
            dataGrid.Columns.Add(experience);

            DataGridTextColumn u = new DataGridTextColumn();
            u.Header = "U";
            u.Binding = new Binding("u");
            dataGrid.Columns.Add(u);

            DataGridTextColumn y = new DataGridTextColumn();
            y.Header = "Y";
            y.Binding = new Binding("y");
            dataGrid.Columns.Add(y);

            DataGridTextColumn d = new DataGridTextColumn();
            d.Header = "D";
            d.Binding = new Binding("d");
            dataGrid.Columns.Add(d);
        }

        private void addX(int size)
        {
            do
            {
                DataGridTextColumn x = new DataGridTextColumn();
                x.Header = "X" + ++count;
                x.Binding = new Binding("x" + count);
                dataGrid.Columns.Insert(count * 2 - 1, x);

                DataGridTextColumn w = new DataGridTextColumn();
                w.Header = "W" + count;
                w.Binding = new Binding("w" + count);
                dataGrid.Columns.Insert(count * 2, w);
            } while (--size > 0);

        }

        private void delX()
        {
            if (count > 1)
            {
                dataGrid.Columns.RemoveAt(count * 2);
                dataGrid.Columns.RemoveAt(count-- * 2 - 1);
            }
        }

        private void addRow(int size)
        {
            do
            {
                dataGrid.Items.Add(new Models.Table() { experience = ++rows });
            } while (--size > 0);
        }

        private void removeRow()
        {
            if (rows > 0)
            {
                dataGrid.Items.RemoveAt(rows-- - 1);
            }
        }

        private void clearTable()
        {
            dataGrid.Columns.Clear();
            buildTable();
            count = 0;
            rows = 0;
        }

        private void addDebugData()
        {
            List<Models.Table> table = Models.Table.getDebugData();
            addX(3);
            for (int i = 0; i < 8; i++)
            {
                dataGrid.Items.Add(table.ElementAt(i));
            }
        }

        private void toCountU()
        {

        }

        private void addX_Click(object sender, RoutedEventArgs e)
        {
            addX(1);
        }

        private void delX_Click(object sender, RoutedEventArgs e)
        {
            delX();
        }

        private void addRow_Click(object sender, RoutedEventArgs e)
        {
            addRow(1);
        }

        private void removeRow_Click(object sender, RoutedEventArgs e)
        {
            removeRow();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            clearTable();
        }

        private void debug_Click(object sender, RoutedEventArgs e)
        {
            addDebugData();
        }

        private void toCountU_Click(object sender, RoutedEventArgs e)
        {
            toCountU();
        }

        private void dataGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string a = dataGrid.Columns[0].GetCellContent(0).ToString();
            MessageBox.Show(a);
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //e.Handled = true;
            //string a = dataGrid.Columns[0].GetCellContent(0).ToString();
            //MessageBox.Show(a);
        }
    }
}
