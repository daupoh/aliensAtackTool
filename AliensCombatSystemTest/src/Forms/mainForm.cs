using AliensCombatSystemTest.src.Controllers;
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
        IFormController m_pFormController;
        public mainForm()
        {
            InitializeComponent();
        }
        
        private void alienClassIsSelected()
        {
            cmbxAlienWeapons.Enabled = true;
            foreach(string s in m_pFormController.getAliensWeapons())
                {
                    cmbxAlienWeapons.Items.Add(s);
                }
            
        }
        private void marineClassIsSelected()
        {
            pnlSetArmorAndHealth.Enabled = true;
            btnSetArmorAndHealth.Enabled = true;
            pnlHitBoxes.Enabled = true;
        }
        private void alienWeaponIsSelected()
        {
            pnlHits.Enabled = true;
            pnlWeaponParameters.Enabled = true;

            numCountOfVectors.Value = m_pFormController.getCountOfVectors();
            numDmgOnVector.Value = (byte)m_pFormController.getDamageOfVector();
            numAutoDmgMod.Value = (decimal)m_pFormController.getAutoDamageMod();
            numTimeToAtack.Value = (decimal)m_pFormController.getTimeOnAnimation();

            numHeadHitsCount.Value = m_pFormController.getHeadHitsCount();
            numBodyHitsCount.Value = m_pFormController.getBodyHitsCount();
            numArmsHitsCount.Value = m_pFormController.getArmsHitsCount();
            numLegsHitsCount.Value = m_pFormController.getLegsHitsCount();
            numMissHitsCount.Value = m_pFormController.getMissHitsCount();


        }
      

        private void mainForm_Load(object sender, EventArgs e)
        {
            m_pFormController = new CFormController();
            foreach(string s in m_pFormController.getAliensClasses())
            {
                cmbxAliensList.Items.Add(s);
            }
            foreach (string s in m_pFormController.getMarinesClasses())
            {
                try
                {
                    cmbxMarinesList.Items.Add(s);
                }
                catch (FormatException formatExc)
                {
                    MessageBox.Show(formatExc.Message);
                }
            }
        }

        private void cmbxAliensList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbxAliensList.SelectedIndex;
            try
            {
                m_pFormController.selectAlien((byte)selectedIndex);
                alienClassIsSelected();
            }
            catch (FormatException formatExc)
            {
                MessageBox.Show(formatExc.Message);
            }
        }

        private void cmbxMarinesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbxMarinesList.SelectedIndex;
            try
            {
                m_pFormController.selectMarine((byte)selectedIndex);
                marineClassIsSelected();
            }
            catch (FormatException formatExc)
            {
                MessageBox.Show(formatExc.Message);
            }
        }

        private void cmbxAlienWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbxAlienWeapons.SelectedIndex;
            try
            {
                m_pFormController.selectAlienWeapon((byte)selectedIndex);
                alienWeaponIsSelected();
            }
            catch (FormatException formatExc)
            {
                MessageBox.Show(formatExc.Message);
            }
        }

        private void btnSaveWeaponSettings_Click(object sender, EventArgs e)
        {
            decimal countOfVector = numCountOfVectors.Value,
                dmgOfVector = numDmgOnVector.Value,
                autoDmgMod = numAutoDmgMod.Value,
                time = numTimeToAtack.Value;

            try
            {
                m_pFormController.setWeaponParameters((byte)countOfVector, (double)dmgOfVector, (double)autoDmgMod, (uint)time);
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnSaveHits_Click(object sender, EventArgs e)
        {
            decimal headHits = numHeadHitsCount.Value,
                bodyHits = numBodyHitsCount.Value,
                armsHits = numArmsHitsCount.Value,
                legsHits = numLegsHitsCount.Value,
                missHits = numMissHitsCount.Value;
            try
            {
                m_pFormController.setWeaponHits((byte)headHits, (byte)bodyHits, (byte)armsHits, (byte)legsHits, (byte)missHits);
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void getArmorAndHealth()
        {
            tbxHealth.Text = Convert.ToString(m_pFormController.getMarineHealthPoints());
            tbxArmor.Text = Convert.ToString(m_pFormController.getMarineArmorPoints());
        }
        private void btnSetArmorAndHealth_Click(object sender, EventArgs e)
        {
            decimal healthPoints = numSetHP.Value,armorPoints=numsetAP.Value;
            try
            {
                m_pFormController.setArmorAndHealth((byte)healthPoints, (byte)armorPoints, "composit");
                
                getArmorAndHealth();
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAllHeadHits_Click(object sender, EventArgs e)
        {
            numHitsToZero();
            try
            {
                numHeadHitsCount.Value = m_pFormController.getCountOfVectors();
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAlmostMissHits_Click(object sender, EventArgs e)
        {
            int restOfHits = m_pFormController.getCountOfVectors() - 1;
            numHitsToZero();
            try
            {
                numArmsHitsCount.Value = 1;
                numMissHitsCount.Value = restOfHits;
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void numHitsToZero()
        {
            numHeadHitsCount.Value = 0;
            numBodyHitsCount.Value = 0;
            numArmsHitsCount.Value = 0;
            numLegsHitsCount.Value = 0;
            numMissHitsCount.Value = 0;
        }
        private void btnRandomHits_Click(object sender, EventArgs e)
        {
            int equivalHits = m_pFormController.getCountOfVectors() / 5,
                restOfHits = m_pFormController.getCountOfVectors() % 5;
            numHitsToZero();
            try
            {
                numHeadHitsCount.Value = equivalHits;
                numBodyHitsCount.Value = equivalHits;
                numArmsHitsCount.Value = equivalHits;
                numLegsHitsCount.Value = equivalHits;                
                numMissHitsCount.Value = equivalHits + restOfHits;
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
