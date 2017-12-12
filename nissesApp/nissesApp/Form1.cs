using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nissesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bilBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bilBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nissesDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nissesDBDataSet.bil' table. You can move, or remove it, as needed.
            this.bilTableAdapter.Fill(this.nissesDBDataSet.bil);

        }
    }
}
