using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullStackSQLExercise
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(patClothesShopDataSet1.Customer);
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter1.FillBy(this.patClothesShopDataSet1.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
