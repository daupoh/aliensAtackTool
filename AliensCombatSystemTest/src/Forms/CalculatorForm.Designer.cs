namespace AliensCombatSystemTest
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCalculatorMode = new System.Windows.Forms.GroupBox();
            this.gbxWeaponTable = new System.Windows.Forms.GroupBox();
            this.m_dgvWeapons = new System.Windows.Forms.DataGridView();
            this.gbxTargetTable = new System.Windows.Forms.GroupBox();
            this.gbxStrikeBlock = new System.Windows.Forms.GroupBox();
            this.gbxCombatLog = new System.Windows.Forms.GroupBox();
            this.m_dgvTargets = new System.Windows.Forms.DataGridView();
            this.m_rbtnAlienMode = new System.Windows.Forms.RadioButton();
            this.m_rbtnHumanMode = new System.Windows.Forms.RadioButton();
            this.gbxHitMods = new System.Windows.Forms.GroupBox();
            this.m_numHeadModHit = new System.Windows.Forms.NumericUpDown();
            this.m_numBodyModHit = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.gbxCalculatorMode.SuspendLayout();
            this.gbxWeaponTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvWeapons)).BeginInit();
            this.gbxTargetTable.SuspendLayout();
            this.gbxStrikeBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTargets)).BeginInit();
            this.gbxHitMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numHeadModHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numBodyModHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCalculatorMode
            // 
            this.gbxCalculatorMode.Controls.Add(this.m_rbtnHumanMode);
            this.gbxCalculatorMode.Controls.Add(this.m_rbtnAlienMode);
            this.gbxCalculatorMode.Location = new System.Drawing.Point(12, 12);
            this.gbxCalculatorMode.Name = "gbxCalculatorMode";
            this.gbxCalculatorMode.Size = new System.Drawing.Size(323, 49);
            this.gbxCalculatorMode.TabIndex = 0;
            this.gbxCalculatorMode.TabStop = false;
            this.gbxCalculatorMode.Text = "Режим калькулятора";
            // 
            // gbxWeaponTable
            // 
            this.gbxWeaponTable.Controls.Add(this.m_dgvWeapons);
            this.gbxWeaponTable.Location = new System.Drawing.Point(12, 67);
            this.gbxWeaponTable.Name = "gbxWeaponTable";
            this.gbxWeaponTable.Size = new System.Drawing.Size(323, 322);
            this.gbxWeaponTable.TabIndex = 1;
            this.gbxWeaponTable.TabStop = false;
            this.gbxWeaponTable.Text = "Таблица типов оружия";
            // 
            // m_dgvWeapons
            // 
            this.m_dgvWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvWeapons.Location = new System.Drawing.Point(6, 19);
            this.m_dgvWeapons.Name = "m_dgvWeapons";
            this.m_dgvWeapons.Size = new System.Drawing.Size(311, 218);
            this.m_dgvWeapons.TabIndex = 0;
            // 
            // gbxTargetTable
            // 
            this.gbxTargetTable.Controls.Add(this.m_dgvTargets);
            this.gbxTargetTable.Location = new System.Drawing.Point(341, 12);
            this.gbxTargetTable.Name = "gbxTargetTable";
            this.gbxTargetTable.Size = new System.Drawing.Size(491, 202);
            this.gbxTargetTable.TabIndex = 2;
            this.gbxTargetTable.TabStop = false;
            this.gbxTargetTable.Text = "Таблица целей";
            // 
            // gbxStrikeBlock
            // 
            this.gbxStrikeBlock.Controls.Add(this.gbxHitMods);
            this.gbxStrikeBlock.Location = new System.Drawing.Point(341, 220);
            this.gbxStrikeBlock.Name = "gbxStrikeBlock";
            this.gbxStrikeBlock.Size = new System.Drawing.Size(491, 169);
            this.gbxStrikeBlock.TabIndex = 3;
            this.gbxStrikeBlock.TabStop = false;
            this.gbxStrikeBlock.Text = "Параметры атаки";
            // 
            // gbxCombatLog
            // 
            this.gbxCombatLog.Location = new System.Drawing.Point(12, 395);
            this.gbxCombatLog.Name = "gbxCombatLog";
            this.gbxCombatLog.Size = new System.Drawing.Size(820, 138);
            this.gbxCombatLog.TabIndex = 4;
            this.gbxCombatLog.TabStop = false;
            this.gbxCombatLog.Text = "Лог боя";
            // 
            // m_dgvTargets
            // 
            this.m_dgvTargets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvTargets.Location = new System.Drawing.Point(6, 19);
            this.m_dgvTargets.Name = "m_dgvTargets";
            this.m_dgvTargets.Size = new System.Drawing.Size(479, 177);
            this.m_dgvTargets.TabIndex = 1;
            // 
            // m_rbtnAlienMode
            // 
            this.m_rbtnAlienMode.AutoSize = true;
            this.m_rbtnAlienMode.Location = new System.Drawing.Point(6, 19);
            this.m_rbtnAlienMode.Name = "m_rbtnAlienMode";
            this.m_rbtnAlienMode.Size = new System.Drawing.Size(148, 17);
            this.m_rbtnAlienMode.TabIndex = 0;
            this.m_rbtnAlienMode.TabStop = true;
            this.m_rbtnAlienMode.Text = "Режим \"Чужой атакует\"";
            this.m_rbtnAlienMode.UseVisualStyleBackColor = true;
            // 
            // m_rbtnHumanMode
            // 
            this.m_rbtnHumanMode.AutoSize = true;
            this.m_rbtnHumanMode.Location = new System.Drawing.Point(160, 19);
            this.m_rbtnHumanMode.Name = "m_rbtnHumanMode";
            this.m_rbtnHumanMode.Size = new System.Drawing.Size(153, 17);
            this.m_rbtnHumanMode.TabIndex = 1;
            this.m_rbtnHumanMode.TabStop = true;
            this.m_rbtnHumanMode.Text = "Режим \"Морпех атакует\"";
            this.m_rbtnHumanMode.UseVisualStyleBackColor = true;
            // 
            // gbxHitMods
            // 
            this.gbxHitMods.Controls.Add(this.numericUpDown2);
            this.gbxHitMods.Controls.Add(this.numericUpDown1);
            this.gbxHitMods.Controls.Add(this.m_numBodyModHit);
            this.gbxHitMods.Controls.Add(this.m_numHeadModHit);
            this.gbxHitMods.Location = new System.Drawing.Point(235, 19);
            this.gbxHitMods.Name = "gbxHitMods";
            this.gbxHitMods.Size = new System.Drawing.Size(250, 144);
            this.gbxHitMods.TabIndex = 0;
            this.gbxHitMods.TabStop = false;
            this.gbxHitMods.Text = "Модификаторы урона по конечностям";
            // 
            // m_numHeadModHit
            // 
            this.m_numHeadModHit.Location = new System.Drawing.Point(124, 19);
            this.m_numHeadModHit.Name = "m_numHeadModHit";
            this.m_numHeadModHit.Size = new System.Drawing.Size(120, 20);
            this.m_numHeadModHit.TabIndex = 0;
            // 
            // m_numBodyModHit
            // 
            this.m_numBodyModHit.Location = new System.Drawing.Point(124, 45);
            this.m_numBodyModHit.Name = "m_numBodyModHit";
            this.m_numBodyModHit.Size = new System.Drawing.Size(120, 20);
            this.m_numBodyModHit.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(124, 71);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(124, 97);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // CalculatorForm
            // 
            this.ClientSize = new System.Drawing.Size(844, 545);
            this.Controls.Add(this.gbxCombatLog);
            this.Controls.Add(this.gbxStrikeBlock);
            this.Controls.Add(this.gbxTargetTable);
            this.Controls.Add(this.gbxWeaponTable);
            this.Controls.Add(this.gbxCalculatorMode);
            this.MinimumSize = new System.Drawing.Size(786, 524);
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор боевой системы";
            this.gbxCalculatorMode.ResumeLayout(false);
            this.gbxCalculatorMode.PerformLayout();
            this.gbxWeaponTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvWeapons)).EndInit();
            this.gbxTargetTable.ResumeLayout(false);
            this.gbxStrikeBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTargets)).EndInit();
            this.gbxHitMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_numHeadModHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numBodyModHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCalculatorMode;
        private System.Windows.Forms.GroupBox gbxWeaponTable;
        private System.Windows.Forms.DataGridView m_dgvWeapons;
        private System.Windows.Forms.GroupBox gbxTargetTable;
        private System.Windows.Forms.GroupBox gbxStrikeBlock;
        private System.Windows.Forms.GroupBox gbxCombatLog;
        private System.Windows.Forms.RadioButton m_rbtnHumanMode;
        private System.Windows.Forms.RadioButton m_rbtnAlienMode;
        private System.Windows.Forms.DataGridView m_dgvTargets;
        private System.Windows.Forms.GroupBox gbxHitMods;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown m_numBodyModHit;
        private System.Windows.Forms.NumericUpDown m_numHeadModHit;
    }
}

