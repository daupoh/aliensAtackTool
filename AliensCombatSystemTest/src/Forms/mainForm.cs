using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliensCombatSystemTest
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        public ComboBox getMarineList()
        {
            return cmbxMarinesList;
        }

        private void numCountOfVectors_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numDmgOnVector_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numAutoDmgMod_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
