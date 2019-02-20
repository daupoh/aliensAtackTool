
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
    public partial class CalculatorForm : Form
    {
        
        enum CalculatorMode
        {
            alienMode,humanMode
        }
        CalculatorMode m_eMode;
        public CalculatorForm()
        {
            InitializeComponent();
            SetElementsInAlienMode();
        }


        private void SetElementsInAlienMode()
        {
            m_eMode = CalculatorMode.alienMode;
            SetWeaponTableByAliens();
            SetTargetTableByAliens();
        }
        private void SetElementsInMarinesMode()
        {
            m_eMode = CalculatorMode.humanMode;
            SetWeaponTableByHumans();
            SetTargetTableByHumans();
        }
        private void SetWeaponTableByAliens()
        {

        }

        private void SetWeaponTableByHumans()
        {

        }
        private void SetTargetTableByAliens()
        {

        }

        private void SetTargetTableByHumans()
        {

        }

    }
}
