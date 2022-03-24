using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//the order of the columns inserted in the CSV file is different in the practice SAC
namespace MichaelSACtask_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                float total = 0f;

                foreach (string line in lines)
                {
                    List<string> fields = line.Split(',').ToList();
                    float profit;
                    float purchasedPrice = float.Parse(fields[4]);
                    string salePrice = fields[5];
                    //calculate the profit
                    if (float.TryParse(salePrice, out float _salePrice))
                    {
                        profit = _salePrice - purchasedPrice;
                    }
                    else
                    {
                        profit = purchasedPrice * -1;
                    }
                    total += profit;

                    fields.Add(profit.ToString());

                    dgvSales.Rows.Add(fields.ToArray());
                }
                foreach (string line in lines)

                dgvSales.Rows.Add();
                int rowCount = dgvSales.Rows.Count;
                dgvSales.Rows[rowCount - 1].Cells[5].Value = "Total";
                dgvSales.Rows[rowCount - 1].Cells[6].Value = $"${total.ToString()}";




            }
        }
    }
}
