
using AliensCombatSystemTest.src.models.calculator;
using AliensCombatSystemTest.src.models.targets;
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
        IList<CWeapon> m_lWeapons;
        IList<ACTarget> m_lTargets;

        public CalculatorForm()
        {
            InitializeComponent();
            m_lWeapons = new List<CWeapon>();
            m_lTargets = new List<ACTarget>();
            SetElementsInAlienMode();
        }
        private void SetResultTableByAliens()
        {
            m_dgvResultTable.Columns.Clear();
            m_dgvResultTable.ColumnCount = SCXmlHelper.CountOfAlienResultRows;

            for (int i = 0; i < m_dgvResultTable.Columns.Count; i++)
            {
                m_dgvResultTable.Columns[i].HeaderText = SCXmlHelper.RowFromAliensResult(i);
            }

        }
        private void SetResultTableByHumans()
        {            
            m_dgvResultTable.Columns.Clear();
            m_dgvResultTable.ColumnCount = SCXmlHelper.CountOfHumanResultRows;

            for (int i = 0; i < m_dgvResultTable.Columns.Count; i++)
            {
                m_dgvResultTable.Columns[i].HeaderText = SCXmlHelper.RowFromHumansResult(i);
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
            m_dgvWeapons.ColumnCount = SCXmlHelper.CountOfAlienWeaponRows;

            for (int i = 0; i < m_dgvWeapons.Columns.Count; i++)
            {
                m_dgvWeapons.Columns[i].HeaderText = SCXmlHelper.RowFromAliensWeapon(i);
            }
        }

        private void SetWeaponTableByHumans()
        {
            m_lWeapons.Clear();
            m_dgvWeapons.Columns.Clear();
            m_dgvWeapons.ColumnCount = SCXmlHelper.CountOfHumanWeaponRows;
            
            for (int i = 0; i < m_dgvWeapons.Columns.Count; i++)
            {
                m_dgvWeapons.Columns[i].HeaderText = SCXmlHelper.RowFromHymansWeapon(i);
            }
           

        }
        private void SetTargetTableByAliens()
        {
            m_lTargets.Clear();
            m_dgvTargets.Columns.Clear();
            m_dgvTargets.ColumnCount = SCXmlHelper.CountOfHumanTargetRows;

            for (int i = 0; i < m_dgvTargets.Columns.Count; i++)
            {
                m_dgvTargets.Columns[i].HeaderText = SCXmlHelper.RowFromHumansTarget(i);
            }

        }

        private void SetTargetTableByHumans()
        {
            m_lTargets.Clear();
            m_dgvTargets.Columns.Clear();
            m_dgvTargets.ColumnCount = SCXmlHelper.CountOfAlienTargetRows;

            for (int i = 0; i < m_dgvTargets.Columns.Count; i++)
            {
                m_dgvTargets.Columns[i].HeaderText = SCXmlHelper.RowFromAliensTarget(i);
            }
        }

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
        private void AddHumanTargetRows()
        {
            CHumanTargetGenerator gen = new CHumanTargetGenerator();
            CHumanTarget target = gen.generateWorkerClass();
            m_lTargets.Add(target);
            addTargetFrom(target);
            target = gen.generateBuilderClass();
            m_lTargets.Add(target);
            addTargetFrom(target);
            target = gen.generateScoutClass();
            m_lTargets.Add(target);
            addTargetFrom(target);

        }
        private void AddHumanWeaponShootRows()
        {
            CHumanShootWeaponGenerator gen = new CHumanShootWeaponGenerator();
            CHumanShootWeapon weapon = gen.generatePistolSC();
            m_lWeapons.Add(weapon);
            addWeaponFrom(weapon);
            weapon = gen.generatePistolSCAuto();
            m_lWeapons.Add(weapon);
            addWeaponFrom(weapon);
            weapon = gen.generatePistolHC();
            m_lWeapons.Add(weapon);
            addWeaponFrom(weapon);
        }
       
        private void addTargetFrom(ACTarget target)
        {
            string[] tableFormat = target.TableFormat;
            m_dgvTargets.RowCount += 1;
            int lastRow = m_dgvTargets.RowCount - 1;
            int index = 0;
            foreach (string s in tableFormat)
            {
                m_dgvTargets.Rows[lastRow].Cells[index++].Value = s;
            }
        }
        private void addWeaponFrom(CWeapon weapon)
        {
            //string[] tableFormat = weapon.TableFormat;
            m_dgvWeapons.RowCount += 1;
            int lastRow = m_dgvWeapons.RowCount - 1;
            int index = 0;
            foreach (string s in tableFormat)
            {
                m_dgvWeapons.Rows[lastRow].Cells[index++].Value = s;
            }
        }
        private void addResultsFrom(string[] results)
        {            
            m_dgvResultTable.RowCount += 1;
            int lastRow = m_dgvResultTable.RowCount - 1;
            int index = 0;
            foreach (string s in results)
            {
                m_dgvResultTable.Rows[lastRow].Cells[index++].Value = s;
            }
        }

        private void CalculateHumanWeaponAgainstTarget()
        {
            
            if (m_dgvWeapons.SelectedRows.Count != 0 && m_dgvTargets.SelectedRows.Count!=0)
            {
                int selectedWeapRow = m_dgvWeapons.SelectedRows[0].Index,
                selectedTargRow = m_dgvTargets.SelectedRows[0].Index;
                string weapName = m_dgvWeapons.Rows[selectedWeapRow].Cells[0].Value.ToString(),
                    targName = m_dgvTargets.Rows[selectedTargRow].Cells[0].Value.ToString();
                CWeapon weap = getWeaponByName(weapName);
                ACTarget targ = getTargetByName(targName);
                CHumanCalculator humCalc = new CHumanCalculator(targ, weap);
                string[] results = humCalc.getCalculate();
                addResultsFrom(results);
            }
            else
            {
                throw new FormatException("Для расчета необходимо выделить оружие и цель!");
            }

        }

        private void CalculateAlienWeaponAgainstTarget()
        {
            if (m_dgvWeapons.SelectedRows.Count != 0 && m_dgvTargets.SelectedRows.Count != 0)
            {
                int selectedWeapRow = m_dgvWeapons.SelectedRows[0].Index,
                selectedTargRow = m_dgvTargets.SelectedRows[0].Index;
                string weapName = m_dgvWeapons.Rows[selectedWeapRow].Cells[0].Value.ToString(),
                    targName = m_dgvTargets.Rows[selectedTargRow].Cells[0].Value.ToString();
                CWeapon weap = getWeaponByName(weapName);
                ACTarget targ = getTargetByName(targName);
                CAlienCalculator alCalc = new CAlienCalculator(targ, weap);
                string[] results = alCalc.getCalculate();

            }
            else
            {
                throw new FormatException("Для расчета необходимо выделить оружие и цель!");
            }
        }
        private CWeapon getWeaponByName(string name)
        {
            CWeapon weap = null;
            foreach(CWeapon w in m_lWeapons)
            {
                if (w.Name==name)
                {
                    weap = w;
                    break;
                }
            }
            if (weap==null)
            {
                throw new FormatException("Оружие с таким именем не найдено");
            }
            return weap;

        }
        private ACTarget getTargetByName(string name)
        {
            ACTarget targ =null;
            foreach (ACTarget t in m_lTargets)
            {
                if (t.NameOfClass == name)
                {
                    targ = t;
                    break;
                }
            }
            if (targ == null)
            {
                throw new FormatException("Цель с таким именем класса не найдена");
            }
            return targ;

        }
        private void m_btnCalculateResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_eMode == CalculatorMode.alienMode)
                {
                    CalculateAlienWeaponAgainstTarget();
                }
                else
                {
                    CalculateHumanWeaponAgainstTarget();
                }
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
