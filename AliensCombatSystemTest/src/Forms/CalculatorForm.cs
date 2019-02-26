
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
            m_dgvWeapons.Columns.Clear();
            m_dgvWeapons.ColumnCount = 10;
            m_dgvWeapons.Columns[0].HeaderText = "Название оружия";
            m_dgvWeapons.Columns[1].HeaderText = "Векторов на удар";
            m_dgvWeapons.Columns[2].HeaderText = "Урон за вектор";
            m_dgvWeapons.Columns[3].HeaderText = "Коэффициент автоурона за вектор";
            m_dgvWeapons.Columns[4].HeaderText = "Количество ударов в атаке";
            m_dgvWeapons.Columns[5].HeaderText = "Время анимации удара";
            m_dgvWeapons.Columns[6].HeaderText = "Сопротивление к урону (Люди)";
            m_dgvWeapons.Columns[7].HeaderText = "Сопротивление к урону (Синтетик)";
            m_dgvWeapons.Columns[8].HeaderText = "Коэффициент поглощения урона броней";
            m_dgvWeapons.Columns[9].HeaderText = "Порог здоровья для сбивания с ног";
        }

        private void SetWeaponTableByHumans()
        {
            m_dgvWeapons.Columns.Clear();
            m_dgvWeapons.ColumnCount = 12;
            m_dgvWeapons.Columns[0].HeaderText = "Название оружия";            
            m_dgvWeapons.Columns[1].HeaderText = "Боезапас";
            m_dgvWeapons.Columns[2].HeaderText = "Урон за пулю";
            m_dgvWeapons.Columns[3].HeaderText = "Скорострельность";
            m_dgvWeapons.Columns[4].HeaderText = "Урон от кислоты за пулю";
            m_dgvWeapons.Columns[5].HeaderText = "Время до перегрева";
            m_dgvWeapons.Columns[6].HeaderText = "Коэффициент урона по Крепости Тела";
            m_dgvWeapons.Columns[7].HeaderText = "Модификатор бонус-урона по коэффициенту Крепости Тела";
            m_dgvWeapons.Columns[8].HeaderText = "Сопротивление к урону (Гварды)";
            m_dgvWeapons.Columns[9].HeaderText = "Сопротивление к урону (Ранеры)";
            m_dgvWeapons.Columns[10].HeaderText = "Сопротивление к урону (Рабочие)";
            m_dgvWeapons.Columns[11].HeaderText = "Сопротивление к урону (Солдаты)";
        }
        private void SetTargetTableByAliens()
        {
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
            m_dgvTargets.Columns.Clear();
            m_dgvTargets.ColumnCount = 7;
            m_dgvTargets.Columns[0].HeaderText = "Название класса";
            m_dgvTargets.Columns[1].HeaderText = "Модификатор попадания в голову";
            m_dgvTargets.Columns[2].HeaderText = "Модификатор попадания в тело";
            m_dgvTargets.Columns[3].HeaderText = "Модификатор попадания в руки";
            m_dgvTargets.Columns[4].HeaderText = "Модификатор попадания в ноги";
            m_dgvTargets.Columns[5].HeaderText = "Расстояние до цели";
            m_dgvTargets.Columns[6].HeaderText = "Действие слизи билдера (да\\нет)";
        }

        private void m_rbtnAlienMode_CheckedChanged(object sender, EventArgs e)
        {
            SetElementsInAlienMode();
        }

        private void m_rbtnHumanMode_CheckedChanged(object sender, EventArgs e)
        {
            SetElementsInMarinesMode();
        }
    }
}
