

using AliensCombatSystemTest.src.models.combatBuilder;
using AliensCombatSystemTest.src.models.weapon;
using gravityPrototype.models;
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
        IList<CCombatEntity> m_lWeapons;
        IList<CCombatEntity> m_lTargets;

        public CalculatorForm()
        {
            InitializeComponent();
            m_lWeapons = new List<CCombatEntity>();
            m_lTargets = new List<CCombatEntity>();
            SetElementsInAlienMode();
        }
        private void SetResultTableByAliens()
        {
            m_dgvResultTable.Columns.Clear();
            m_dgvResultTable.ColumnCount = SCXmlHelper.CountRowsFromXml("ARP","PP");

            for (int i = 0; i < m_dgvResultTable.Columns.Count; i++)
            {
                m_dgvResultTable.Columns[i].HeaderText = SCXmlHelper.RowFromXml(i, "ARP", "PP");
            }

        }
        private void SetResultTableByHumans()
        {            
            m_dgvResultTable.Columns.Clear();
            m_dgvResultTable.ColumnCount = SCXmlHelper.CountRowsFromXml("HRP", "PP"); 

            for (int i = 0; i < m_dgvResultTable.Columns.Count; i++)
            {
                m_dgvResultTable.Columns[i].HeaderText = SCXmlHelper.RowFromXml(i, "HRP", "PP");
            }
        }

        private void SetElementsInAlienMode()
        {
            m_eMode = CalculatorMode.alienMode;
            SetWeaponTableByAliens();
            SetTargetTableByAliens();
            SetResultTableByAliens();
        }
        private void SetElementsInMarinesMode()
        {
            m_eMode = CalculatorMode.humanMode;
            SetWeaponTableByHumans();
            SetTargetTableByHumans();
            SetResultTableByHumans();
        }
        private void SetWeaponTableByAliens()
        {
            m_lWeapons.Clear();
            m_dgvWeapons.Columns.Clear();
            int parametersCount = SCXmlHelper.CountRowsFromXml("AWP", "PP");
            m_dgvWeapons.ColumnCount = parametersCount + 1;

            m_dgvWeapons.Columns[0].HeaderText = "Название оружия";
            for (int i = 0; i < parametersCount; i++)
            {
                m_dgvWeapons.Columns[i+1].HeaderText = SCXmlHelper.RowFromXml(i, "AWP", "PP");
            }

            AddAlienWeapons();
        }

        private void SetWeaponTableByHumans()
        {
            m_lWeapons.Clear();
            m_dgvWeapons.Columns.Clear();
            m_dgvWeapons.ColumnCount = SCXmlHelper.CountRowsFromXml("HWP", "PP"); ;
            
            for (int i = 0; i < m_dgvWeapons.Columns.Count; i++)
            {
                m_dgvWeapons.Columns[i].HeaderText = SCXmlHelper.RowFromXml(i, "HWP", "PP");
            }
           

        }
        private void SetTargetTableByAliens()
        {
            m_lTargets.Clear();
            m_dgvTargets.Columns.Clear();
            m_dgvTargets.ColumnCount = SCXmlHelper.CountRowsFromXml("HTP", "PP"); ;

            for (int i = 0; i < m_dgvTargets.Columns.Count; i++)
            {
                m_dgvTargets.Columns[i].HeaderText = SCXmlHelper.RowFromXml(i, "HTP", "PP");
            }

        }

        private void SetTargetTableByHumans()
        {
            m_lTargets.Clear();
            m_dgvTargets.Columns.Clear();
            m_dgvTargets.ColumnCount = SCXmlHelper.CountRowsFromXml("ATP", "PP"); ;

            for (int i = 0; i < m_dgvTargets.Columns.Count; i++)
            {
                m_dgvTargets.Columns[i].HeaderText = SCXmlHelper.RowFromXml(i, "ATP", "PP");
            }
        }
        //--------------------
        private void AddAlienWeapons()
        {
            ICombatBuilder alienBuilder = new CAlienWeaponBuilder();
            IList<ICombatEntity> combatEntities = alienBuilder.CombatEntities;
            m_dgvWeapons.RowCount += combatEntities.Count;
            int parametersCount = SCXmlHelper.CountRowsFromXml("AWP", "PP"),
                indexRows=0;

            foreach (ICombatEntity combat in combatEntities)
            {
                m_dgvWeapons.Rows[indexRows].Cells[0].Value = combat.Name;
                for (int i = 0; i < parametersCount; i++)
                {
                    m_dgvWeapons.Rows[indexRows].Cells[i+1].Value = combat.getParameterPoolViewByName(SCXmlHelper.RowFromXml(i, "AWP", "PP"));
                }
                indexRows++;
            }
        }
        //---------------------


        private void m_rbtnAlienMode_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetElementsInAlienMode();
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void m_rbtnHumanMode_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetElementsInMarinesMode();
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void m_btnClearResults_Click(object sender, EventArgs e)
        {
            m_dgvResultTable.Rows.Clear();
        }
    }
}
