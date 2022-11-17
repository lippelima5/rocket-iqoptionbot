using IqOptionApiDotNet.Models.BinaryOptions;
using IqOptionApiDotNet.Models.DigitalOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketBuy
{
    public partial class F_LOG : Form
    {
        public F_LOG()
        {
            InitializeComponent();
        }

        private void F_LOG_Load(object sender, EventArgs e)
        {
            var source = new BindingSource(Base.LOGS, null);
            G_LOGS.DataSource = source;
        }

        private void G_LOGS_Click(object sender, EventArgs e)
        {
            if (G_LOGS.SelectedCells.Count > 0)
            {
                int selectedrowindex = G_LOGS.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = G_LOGS.Rows[selectedrowindex];



                try
                {
                    if (selectedRow.Cells["BinaryResult"].Value != null)
                    {
                        BinaryOptionsResult cellValue = (BinaryOptionsResult)selectedRow.Cells["BinaryResult"].Value;

                        var source = new BindingSource(cellValue, null);

                        G_RESULT.DataSource = source;
                    }
                    else if (selectedRow.Cells["DigitalResult"].Value != null)
                    {
                        DigitalOptionsPlacedResult cellValue = (DigitalOptionsPlacedResult)selectedRow.Cells["DigitalResult"].Value;

                        var source = new BindingSource(cellValue, null);

                        G_RESULT.DataSource = source;
                    }
                    else
                    {
                        G_RESULT.DataSource = null;
                        G_RESULT.Rows.Clear();
                        G_RESULT.Refresh();
                    }

                }
                catch (Exception)
                {
                    G_RESULT.DataSource = null;
                    G_RESULT.Rows.Clear();
                    G_RESULT.Refresh();
                }





            }
        }
    }
}
