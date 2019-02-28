
using AliensCombatSystemTest.src.models.targets;
using AliensCombatSystemTest.src.models.weapon;
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
        IList<ACWeapon> m_lWeapons;
        IList<ACTarget> m_lTargets;

        public CalculatorForm()
        {
            InitializeComponent();
            m_lWeapons = new List<ACWeapon>();
            m_lTargets = new List<ACTarget>();
            SetElementsInAlienMode();
        }
        private void SetResultTableByAliens()
        {
            m_dgvResultTable.Rows.Clear();
            m_dgvResultTable.ColumnCount = 14;
            m_dgvResultTable.Columns[0].HeaderText = "Название оружия";
            m_dgvResultTable.Columns[1].HeaderText = "Название класса цели";
            m_dgvResultTable.Columns[2].HeaderText = "ТТК с уровнем Брони 100% (все в голову)";
            m_dgvResultTable.Columns[3].HeaderText = "ТТК с уровнем Брони 0% (все в голову)";
            m_dgvResultTable.Columns[4].HeaderText = "ТТХ с уровнем Брони 100% (все в голову)";
            m_dgvResultTable.Columns[5].HeaderText = "ТТХ с уровнем Брони 0% (все в голову)";

            m_dgvResultTable.Columns[6].HeaderText = "ТТК с уровнем Брони 100% (1 попадание)";
            m_dgvResultTable.Columns[7].HeaderText = "ТТК с уровнем Брони 0% (1 попадание)";
            m_dgvResultTable.Columns[8].HeaderText = "ТТХ с уровнем Брони 100% (1 попадание)";
            m_dgvResultTable.Columns[9].HeaderText = "ТТХ с уровнем Брони 0% (1 попадание)";

            m_dgvResultTable.Columns[10].HeaderText = "ТТК с уровнем Брони 100% (среднее значение)";
            m_dgvResultTable.Columns[11].HeaderText = "ТТК с уровнем Брони 0% (среднее значение)";
            m_dgvResultTable.Columns[12].HeaderText = "ТТХ с уровнем Брони 100% (среднее значение)";
            m_dgvResultTable.Columns[13].HeaderText = "ТТХ с уровнем Брони 0% (среднее значение)";

        }
        private void SetResultTableByHumans()
        {
            m_dgvResultTable.Rows.Clear();
            m_dgvResultTable.ColumnCount = 17;
            m_dgvResultTable.Columns[0].HeaderText = "Название оружия";
            m_dgvResultTable.Columns[1].HeaderText = "Название класса цели";
            m_dgvResultTable.Columns[2].HeaderText = "ТТК с уровнем Крепости Тела 100% (стрельба в голову)";
            m_dgvResultTable.Columns[3].HeaderText = "ТТК с уровнем Крепости Тела 0% (стрельба в голову)";
            m_dgvResultTable.Columns[4].HeaderText = "Суммарный полученный урон кислоты (стрельба в голову)";
            m_dgvResultTable.Columns[5].HeaderText = "Суммарный урон кислоты по броне (стрельба в голову)";
            m_dgvResultTable.Columns[6].HeaderText = "Суммарный урон кислоты по здоровью (стрельба в голову)";

            m_dgvResultTable.Columns[7].HeaderText = "ТТК с уровнем Крепости Тела 100% (стрельба в конечности)";
            m_dgvResultTable.Columns[8].HeaderText = "ТТК с уровнем Крепости Тела 0% (стрельба в конечности)";
            m_dgvResultTable.Columns[9].HeaderText = "Суммарный полученный урон кислоты (стрельба в конечности)";
            m_dgvResultTable.Columns[10].HeaderText = "Суммарный урон кислоты по броне (стрельба в конечности)";
            m_dgvResultTable.Columns[11].HeaderText = "Суммарный урон кислоты по здоровью (стрельба в конечности)";

            m_dgvResultTable.Columns[12].HeaderText = "ТТК с уровнем Крепости Тела 100% (стрельба в тело)";
            m_dgvResultTable.Columns[13].HeaderText = "ТТК с уровнем Крепости Тела 0% (стрельба в тело)";
            m_dgvResultTable.Columns[14].HeaderText = "Суммарный полученный урон кислоты (стрельба в тело)";
            m_dgvResultTable.Columns[15].HeaderText = "Суммарный урон кислоты по броне (стрельба в тело)";
            m_dgvResultTable.Columns[16].HeaderText = "Суммарный урон кислоты по здоровью (стрельба в тело)";
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
            m_dgvWeapons.ColumnCount = 12;
            m_dgvWeapons.Columns[0].HeaderText = "Название оружия";
            m_dgvWeapons.Columns[1].HeaderText = "Векторов на удар";
            m_dgvWeapons.Columns[2].HeaderText = "Урон за вектор";
            m_dgvWeapons.Columns[3].HeaderText = "Коэффициент автоурона за вектор";
            m_dgvWeapons.Columns[4].HeaderText = "Количество ударов в атаке";
            m_dgvWeapons.Columns[5].HeaderText = "Время анимации удара";
            m_dgvWeapons.Columns[6].HeaderText = "Урон во времени";
            m_dgvWeapons.Columns[7].HeaderText = "Время урона во времени";
            m_dgvWeapons.Columns[8].HeaderText = "Сопротивление к урону (Люди)";
            m_dgvWeapons.Columns[9].HeaderText = "Сопротивление к урону (Синтетик)";
            m_dgvWeapons.Columns[10].HeaderText = "Коэффициент поглощения урона броней";
            m_dgvWeapons.Columns[11].HeaderText = "Порог здоровья для сбивания с ног";
        }

        private void SetWeaponTableByHumans()
        {
            m_lWeapons.Clear();
            m_dgvWeapons.Columns.Clear();
            m_dgvWeapons.ColumnCount = 15;
            m_dgvWeapons.Columns[0].HeaderText = "Название оружия";            
            m_dgvWeapons.Columns[1].HeaderText = "Боезапас";
            m_dgvWeapons.Columns[2].HeaderText = "Урон за пулю";
            m_dgvWeapons.Columns[3].HeaderText = "Скорострельность";
            m_dgvWeapons.Columns[4].HeaderText = "Урон от кислоты за пулю";            
            m_dgvWeapons.Columns[5].HeaderText = "Урон во времени";
            m_dgvWeapons.Columns[6].HeaderText = "Время урона во времени";
            m_dgvWeapons.Columns[7].HeaderText = "Коэффициент урона по Крепости Тела";
            m_dgvWeapons.Columns[8].HeaderText = "Модификатор бонус-урона по коэффициенту Крепости Тела";
            m_dgvWeapons.Columns[9].HeaderText = "Сопротивление к урону (Солдаты)";
            m_dgvWeapons.Columns[10].HeaderText = "Сопротивление к урону (Гварды)";
            m_dgvWeapons.Columns[11].HeaderText = "Сопротивление к урону (Ранеры)";
            m_dgvWeapons.Columns[12].HeaderText = "Сопротивление к урону (Рабочие)";
            m_dgvWeapons.Columns[13].HeaderText = "Модификатор урона кислоты";
            m_dgvWeapons.Columns[14].HeaderText = "Время до перегрева";
            AddHumanWeaponShootRows();

        }
        private void SetTargetTableByAliens()
        {
            m_lTargets.Clear();
            m_dgvTargets.Columns.Clear();
            m_dgvTargets.ColumnCount = 8;
            m_dgvTargets.Columns[0].HeaderText = "Название класса";
            m_dgvTargets.Columns[1].HeaderText = "Модификатор попадания в голову";
            m_dgvTargets.Columns[2].HeaderText = "Модификатор попадания в тело";
            m_dgvTargets.Columns[3].HeaderText = "Модификатор попадания в руки";
            m_dgvTargets.Columns[4].HeaderText = "Модификатор попадания в ноги";
            m_dgvTargets.Columns[5].HeaderText = "Тип оружия в руках (тяж\\срд\\лег)";
            m_dgvTargets.Columns[6].HeaderText = "Действие баррикады (да\\нет)";
            m_dgvTargets.Columns[7].HeaderText = "Действие слизи билдера (да\\нет)";
        }

        private void SetTargetTableByHumans()
        {
            m_lTargets.Clear();
            m_dgvTargets.Columns.Clear();
            m_dgvTargets.ColumnCount = 7;
            m_dgvTargets.Columns[0].HeaderText = "Название класса";
            m_dgvTargets.Columns[1].HeaderText = "Модификатор попадания в голову";
            m_dgvTargets.Columns[2].HeaderText = "Модификатор попадания в тело";
            m_dgvTargets.Columns[3].HeaderText = "Модификатор попадания в руки";
            m_dgvTargets.Columns[4].HeaderText = "Модификатор попадания в ноги";
            m_dgvTargets.Columns[5].HeaderText = "Расстояние до цели";
            m_dgvTargets.Columns[6].HeaderText = "Действие слизи билдера (да\\нет)";
            AddHumanTargetRows();
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
            CHumanTarget human = gen.generateWorkerClass();
            m_lTargets.Add(human);
            addTargetFrom(human);
            human = gen.generateBuilderClass();
            m_lTargets.Add(human);
            addTargetFrom(human);
            human = gen.generateScoutClass();
            m_lTargets.Add(human);
            addTargetFrom(human);

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
        private void AddAlienTargetRows()
        {
            CAlienTargetGenerator gen = new CAlienTargetGenerator();
            CAlienTarget alien;
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
        private void addWeaponFrom(ACWeapon weapon)
        {
            string[] tableFormat = weapon.TableFormat;
            m_dgvWeapons.RowCount += 1;
            int lastRow = m_dgvWeapons.RowCount - 1;
            int index = 0;
            foreach (string s in tableFormat)
            {
                m_dgvWeapons.Rows[lastRow].Cells[index++].Value = s;
            }
        }
        private void CalculateHumanWeaponAgainstTarget()
        {
            
            if (m_dgvWeapons.SelectedRows != null && m_dgvTargets.SelectedRows!=null)
            {
                int selectedWeapRow = m_dgvWeapons.SelectedRows[0].Index,
                selectedTargRow = m_dgvTargets.SelectedRows[0].Index;
                string weapName = m_dgvWeapons.Rows[selectedWeapRow].Cells[0].Value.ToString(),
                    targName = m_dgvTargets.Rows[selectedTargRow].Cells[0].Value.ToString();
                ACWeapon weap = getWeaponByName(weapName);
                ACTarget targ = getTargetByName(targName);



            }
            else
            {
                throw new FormatException("Для расчета необходимо выделить оружие и цель!");
            }

        }

        private void CalculateAlienWeaponAgainstTarget() { }
        private ACWeapon getWeaponByName(string name)
        {
            ACWeapon weap = null;
            foreach(ACWeapon w in m_lWeapons)
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
    }
}
