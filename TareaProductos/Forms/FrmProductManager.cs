using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaProductos.Forms
{
    public partial class FrmProductManager : Form
    {
        public FrmProductManager()
        {
            InitializeComponent();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbSearch.SelectedIndex)
            {
                case 0:
                    pnlByMeasurement.Visible = true;
                    pnlCaducity.Visible = false;
                    pnlId.Visible = false;
                    pnlPriceRange.Visible = false;
                        break;
                case 1:
                    pnlByMeasurement.Visible = false;
                    pnlCaducity.Visible = true;
                    pnlId.Visible = false;
                    pnlPriceRange.Visible = false;
                    break;
                case 2:
                    pnlByMeasurement.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlId.Visible = true ;
                    pnlPriceRange.Visible = false;
                    break;
                case 3:
                    pnlByMeasurement.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlId.Visible = false;
                    pnlPriceRange.Visible = true;
                    break;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
