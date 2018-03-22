using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelMcCullochWinForms
{
    public partial class MainFrm : Form
    {
        int count = 0;
        int rows = 0;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            buildTable();
        }

        private void buildTable()
        {
            dataGridView1.Columns.Add("exp", "Опыт");
            addX(3);
            dataGridView1.Columns.Add("u", "U");
            dataGridView1.Columns.Add("y", "Y");
            dataGridView1.Columns.Add("d", "D");
            setWidthAllColumns(48, 36);
        }

        private void setWidthAllColumns(int widthFirstColumn, int widthAllColumns)
        {
            dataGridView1.Columns[0].Width = widthFirstColumn;
            int columns = count + 6;
            while (columns > 0)
            {
                dataGridView1.Columns[columns--].Width = widthAllColumns;
            }
        }

        private void addX(int size)
        {
            do
            {
                dataGridView1.Columns.Add("x"+ ++count, "X" + count);
                dataGridView1.Columns.Add("w" + count, "W" + count);
            } while (--size > 0);
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1.Rows[rows].Cells[0].Value = ++rows;
            setDefaultOfW();
        }

        private void setDefaultOfW()
        {
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < count; j++) 
                {
                    dataGridView1.Rows[i].Cells[2 * (j + 1)].Value = 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                double u = 0;
                for (int j = 0; j < count; j++)
                {
                    u += getU(i, j);
                }
                dataGridView1.Rows[i].Cells[1 + count * 2].Value = u;
            }
        }

        private double getU(int i, int j)
        {
            return Convert.ToDouble(dataGridView1.Rows[i].Cells[2 * (j + 1)].Value.ToString()) * 
                Convert.ToDouble(dataGridView1.Rows[i].Cells[2 * j + 1].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double t =  Convert.ToDouble(textBox1.Text);
            for (int i = 0; i < rows; i++)
            {
                double u = Convert.ToDouble(dataGridView1.Rows[i].Cells[1 + count * 2].Value.ToString());
                double y = 0;
                if (u < t)
                {
                    y = 0;
                } else
                {
                    y = 1;
                }
                dataGridView1.Rows[i].Cells[2 + count * 2].Value = y;
            }
        }
    }
}
