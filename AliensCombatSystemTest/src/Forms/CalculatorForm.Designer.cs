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
            this.m_rbtnHumanMode = new System.Windows.Forms.RadioButton();
            this.m_rbtnAlienMode = new System.Windows.Forms.RadioButton();
            this.gbxWeaponTable = new System.Windows.Forms.GroupBox();
            this.m_btnCalculateTotalResult = new System.Windows.Forms.Button();
            this.m_btnCalculateResult = new System.Windows.Forms.Button();
            this.m_dgvWeapons = new System.Windows.Forms.DataGridView();
            this.gbxTargetTable = new System.Windows.Forms.GroupBox();
            this.m_dgvTargets = new System.Windows.Forms.DataGridView();
            this.gbxStrikeBlock = new System.Windows.Forms.GroupBox();
            this.m_numRestHP = new System.Windows.Forms.NumericUpDown();
            this.m_btnAtackUntil = new System.Windows.Forms.Button();
            this.m_btnAtack = new System.Windows.Forms.Button();
            this.m_lblBPorAP = new System.Windows.Forms.Label();
            this.m_numBPorAP = new System.Windows.Forms.NumericUpDown();
            this.m_numHP = new System.Windows.Forms.NumericUpDown();
            this.m_lblHP = new System.Windows.Forms.Label();
            this.m_numTotalHits = new System.Windows.Forms.NumericUpDown();
            this.m_lblTotalHits = new System.Windows.Forms.Label();
            this.m_lblMiss = new System.Windows.Forms.Label();
            this.m_numMissCount = new System.Windows.Forms.NumericUpDown();
            this.m_lblLegs = new System.Windows.Forms.Label();
            this.m_lblArms = new System.Windows.Forms.Label();
            this.m_lblBody = new System.Windows.Forms.Label();
            this.m_lblHead = new System.Windows.Forms.Label();
            this.m_numLegsCount = new System.Windows.Forms.NumericUpDown();
            this.m_numArmsCount = new System.Windows.Forms.NumericUpDown();
            this.m_numBodyCount = new System.Windows.Forms.NumericUpDown();
            this.m_numHeadCount = new System.Windows.Forms.NumericUpDown();
            this.gbxCombatLog = new System.Windows.Forms.GroupBox();
            this.m_btnClearLog = new System.Windows.Forms.Button();
            this.m_tbxCombatLog = new System.Windows.Forms.TextBox();
            this.gbxResultsTable = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxCalculatorMode.SuspendLayout();
            this.gbxWeaponTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvWeapons)).BeginInit();
            this.gbxTargetTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTargets)).BeginInit();
            this.gbxStrikeBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numRestHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numBPorAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numTotalHits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numMissCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numLegsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numArmsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numBodyCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numHeadCount)).BeginInit();
            this.gbxCombatLog.SuspendLayout();
            this.gbxResultsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCalculatorMode
            // 
            this.gbxCalculatorMode.Controls.Add(this.m_rbtnHumanMode);
            this.gbxCalculatorMode.Controls.Add(this.m_rbtnAlienMode);
            this.gbxCalculatorMode.Location = new System.Drawing.Point(12, 12);
            this.gbxCalculatorMode.Name = "gbxCalculatorMode";
            this.gbxCalculatorMode.Size = new System.Drawing.Size(543, 49);
            this.gbxCalculatorMode.TabIndex = 0;
            this.gbxCalculatorMode.TabStop = false;
            this.gbxCalculatorMode.Text = "Режим калькулятора";
            // 
            // m_rbtnHumanMode
            // 
            this.m_rbtnHumanMode.AutoSize = true;
            this.m_rbtnHumanMode.Location = new System.Drawing.Point(160, 19);
            this.m_rbtnHumanMode.Name = "m_rbtnHumanMode";
            this.m_rbtnHumanMode.Size = new System.Drawing.Size(153, 17);
            this.m_rbtnHumanMode.TabIndex = 1;
            this.m_rbtnHumanMode.Text = "Режим \"Морпех атакует\"";
            this.m_rbtnHumanMode.UseVisualStyleBackColor = true;
            this.m_rbtnHumanMode.CheckedChanged += new System.EventHandler(this.m_rbtnHumanMode_CheckedChanged);
            // 
            // m_rbtnAlienMode
            // 
            this.m_rbtnAlienMode.AutoSize = true;
            this.m_rbtnAlienMode.Checked = true;
            this.m_rbtnAlienMode.Location = new System.Drawing.Point(6, 19);
            this.m_rbtnAlienMode.Name = "m_rbtnAlienMode";
            this.m_rbtnAlienMode.Size = new System.Drawing.Size(148, 17);
            this.m_rbtnAlienMode.TabIndex = 0;
            this.m_rbtnAlienMode.TabStop = true;
            this.m_rbtnAlienMode.Text = "Режим \"Чужой атакует\"";
            this.m_rbtnAlienMode.UseVisualStyleBackColor = true;
            this.m_rbtnAlienMode.CheckedChanged += new System.EventHandler(this.m_rbtnAlienMode_CheckedChanged);
            // 
            // gbxWeaponTable
            // 
            this.gbxWeaponTable.Controls.Add(this.m_btnCalculateTotalResult);
            this.gbxWeaponTable.Controls.Add(this.m_btnCalculateResult);
            this.gbxWeaponTable.Controls.Add(this.m_dgvWeapons);
            this.gbxWeaponTable.Location = new System.Drawing.Point(12, 67);
            this.gbxWeaponTable.Name = "gbxWeaponTable";
            this.gbxWeaponTable.Size = new System.Drawing.Size(543, 335);
            this.gbxWeaponTable.TabIndex = 1;
            this.gbxWeaponTable.TabStop = false;
            this.gbxWeaponTable.Text = "Таблица типов оружия";
            // 
            // m_btnCalculateTotalResult
            // 
            this.m_btnCalculateTotalResult.Location = new System.Drawing.Point(349, 291);
            this.m_btnCalculateTotalResult.Name = "m_btnCalculateTotalResult";
            this.m_btnCalculateTotalResult.Size = new System.Drawing.Size(188, 38);
            this.m_btnCalculateTotalResult.TabIndex = 28;
            this.m_btnCalculateTotalResult.Text = "Рассчитать показатели типов оружия против всех целей";
            this.m_btnCalculateTotalResult.UseVisualStyleBackColor = true;
            // 
            // m_btnCalculateResult
            // 
            this.m_btnCalculateResult.Location = new System.Drawing.Point(6, 288);
            this.m_btnCalculateResult.Name = "m_btnCalculateResult";
            this.m_btnCalculateResult.Size = new System.Drawing.Size(214, 38);
            this.m_btnCalculateResult.TabIndex = 27;
            this.m_btnCalculateResult.Text = "Рассчитать показатели выбранного оружия против выбранной цели";
            this.m_btnCalculateResult.UseVisualStyleBackColor = true;
            // 
            // m_dgvWeapons
            // 
            this.m_dgvWeapons.AllowUserToAddRows = false;
            this.m_dgvWeapons.AllowUserToDeleteRows = false;
            this.m_dgvWeapons.AllowUserToResizeRows = false;
            this.m_dgvWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvWeapons.Location = new System.Drawing.Point(6, 19);
            this.m_dgvWeapons.MultiSelect = false;
            this.m_dgvWeapons.Name = "m_dgvWeapons";
            this.m_dgvWeapons.RowHeadersVisible = false;
            this.m_dgvWeapons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvWeapons.Size = new System.Drawing.Size(531, 263);
            this.m_dgvWeapons.TabIndex = 0;
            // 
            // gbxTargetTable
            // 
            this.gbxTargetTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTargetTable.Controls.Add(this.m_dgvTargets);
            this.gbxTargetTable.Location = new System.Drawing.Point(561, 12);
            this.gbxTargetTable.Name = "gbxTargetTable";
            this.gbxTargetTable.Size = new System.Drawing.Size(461, 202);
            this.gbxTargetTable.TabIndex = 2;
            this.gbxTargetTable.TabStop = false;
            this.gbxTargetTable.Text = "Таблица целей";
            // 
            // m_dgvTargets
            // 
            this.m_dgvTargets.AllowUserToAddRows = false;
            this.m_dgvTargets.AllowUserToDeleteRows = false;
            this.m_dgvTargets.AllowUserToResizeRows = false;
            this.m_dgvTargets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvTargets.Location = new System.Drawing.Point(6, 19);
            this.m_dgvTargets.MultiSelect = false;
            this.m_dgvTargets.Name = "m_dgvTargets";
            this.m_dgvTargets.RowHeadersVisible = false;
            this.m_dgvTargets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvTargets.Size = new System.Drawing.Size(449, 177);
            this.m_dgvTargets.TabIndex = 1;
            // 
            // gbxStrikeBlock
            // 
            this.gbxStrikeBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxStrikeBlock.Controls.Add(this.m_numRestHP);
            this.gbxStrikeBlock.Controls.Add(this.m_btnAtackUntil);
            this.gbxStrikeBlock.Controls.Add(this.m_btnAtack);
            this.gbxStrikeBlock.Controls.Add(this.m_lblBPorAP);
            this.gbxStrikeBlock.Controls.Add(this.m_numBPorAP);
            this.gbxStrikeBlock.Controls.Add(this.m_numHP);
            this.gbxStrikeBlock.Controls.Add(this.m_lblHP);
            this.gbxStrikeBlock.Controls.Add(this.m_numTotalHits);
            this.gbxStrikeBlock.Controls.Add(this.m_lblTotalHits);
            this.gbxStrikeBlock.Controls.Add(this.m_lblMiss);
            this.gbxStrikeBlock.Controls.Add(this.m_numMissCount);
            this.gbxStrikeBlock.Controls.Add(this.m_lblLegs);
            this.gbxStrikeBlock.Controls.Add(this.m_lblArms);
            this.gbxStrikeBlock.Controls.Add(this.m_lblBody);
            this.gbxStrikeBlock.Controls.Add(this.m_lblHead);
            this.gbxStrikeBlock.Controls.Add(this.m_numLegsCount);
            this.gbxStrikeBlock.Controls.Add(this.m_numArmsCount);
            this.gbxStrikeBlock.Controls.Add(this.m_numBodyCount);
            this.gbxStrikeBlock.Controls.Add(this.m_numHeadCount);
            this.gbxStrikeBlock.Location = new System.Drawing.Point(561, 220);
            this.gbxStrikeBlock.Name = "gbxStrikeBlock";
            this.gbxStrikeBlock.Size = new System.Drawing.Size(461, 182);
            this.gbxStrikeBlock.TabIndex = 3;
            this.gbxStrikeBlock.TabStop = false;
            this.gbxStrikeBlock.Text = "Параметры атаки";
            // 
            // m_numRestHP
            // 
            this.m_numRestHP.Location = new System.Drawing.Point(396, 153);
            this.m_numRestHP.Name = "m_numRestHP";
            this.m_numRestHP.Size = new System.Drawing.Size(59, 20);
            this.m_numRestHP.TabIndex = 28;
            // 
            // m_btnAtackUntil
            // 
            this.m_btnAtackUntil.Location = new System.Drawing.Point(303, 98);
            this.m_btnAtackUntil.Name = "m_btnAtackUntil";
            this.m_btnAtackUntil.Size = new System.Drawing.Size(87, 75);
            this.m_btnAtackUntil.TabIndex = 27;
            this.m_btnAtackUntil.Text = "Атаковать, пока HP не станет равным...";
            this.m_btnAtackUntil.UseVisualStyleBackColor = true;
            // 
            // m_btnAtack
            // 
            this.m_btnAtack.Location = new System.Drawing.Point(303, 66);
            this.m_btnAtack.Name = "m_btnAtack";
            this.m_btnAtack.Size = new System.Drawing.Size(152, 23);
            this.m_btnAtack.TabIndex = 26;
            this.m_btnAtack.Text = "Атаковать один раз";
            this.m_btnAtack.UseVisualStyleBackColor = true;
            // 
            // m_lblBPorAP
            // 
            this.m_lblBPorAP.Location = new System.Drawing.Point(300, 42);
            this.m_lblBPorAP.Name = "m_lblBPorAP";
            this.m_lblBPorAP.Size = new System.Drawing.Size(90, 18);
            this.m_lblBPorAP.TabIndex = 25;
            this.m_lblBPorAP.Text = "Количество AP";
            // 
            // m_numBPorAP
            // 
            this.m_numBPorAP.Location = new System.Drawing.Point(396, 40);
            this.m_numBPorAP.Name = "m_numBPorAP";
            this.m_numBPorAP.Size = new System.Drawing.Size(59, 20);
            this.m_numBPorAP.TabIndex = 24;
            // 
            // m_numHP
            // 
            this.m_numHP.Location = new System.Drawing.Point(396, 14);
            this.m_numHP.Name = "m_numHP";
            this.m_numHP.Size = new System.Drawing.Size(59, 20);
            this.m_numHP.TabIndex = 23;
            // 
            // m_lblHP
            // 
            this.m_lblHP.Location = new System.Drawing.Point(300, 16);
            this.m_lblHP.Name = "m_lblHP";
            this.m_lblHP.Size = new System.Drawing.Size(90, 18);
            this.m_lblHP.TabIndex = 22;
            this.m_lblHP.Text = "Количество HP";
            // 
            // m_numTotalHits
            // 
            this.m_numTotalHits.Location = new System.Drawing.Point(206, 14);
            this.m_numTotalHits.Name = "m_numTotalHits";
            this.m_numTotalHits.Size = new System.Drawing.Size(73, 20);
            this.m_numTotalHits.TabIndex = 21;
            // 
            // m_lblTotalHits
            // 
            this.m_lblTotalHits.Location = new System.Drawing.Point(6, 16);
            this.m_lblTotalHits.Name = "m_lblTotalHits";
            this.m_lblTotalHits.Size = new System.Drawing.Size(194, 18);
            this.m_lblTotalHits.TabIndex = 20;
            this.m_lblTotalHits.Text = "Количество возможных попаданий";
            // 
            // m_lblMiss
            // 
            this.m_lblMiss.Location = new System.Drawing.Point(6, 155);
            this.m_lblMiss.Name = "m_lblMiss";
            this.m_lblMiss.Size = new System.Drawing.Size(194, 18);
            this.m_lblMiss.TabIndex = 19;
            this.m_lblMiss.Text = "Количество промахов";
            // 
            // m_numMissCount
            // 
            this.m_numMissCount.Location = new System.Drawing.Point(206, 153);
            this.m_numMissCount.Name = "m_numMissCount";
            this.m_numMissCount.Size = new System.Drawing.Size(73, 20);
            this.m_numMissCount.TabIndex = 18;
            // 
            // m_lblLegs
            // 
            this.m_lblLegs.Location = new System.Drawing.Point(6, 129);
            this.m_lblLegs.Name = "m_lblLegs";
            this.m_lblLegs.Size = new System.Drawing.Size(194, 18);
            this.m_lblLegs.TabIndex = 17;
            this.m_lblLegs.Text = "Количество попаданий в ноги";
            // 
            // m_lblArms
            // 
            this.m_lblArms.Location = new System.Drawing.Point(6, 103);
            this.m_lblArms.Name = "m_lblArms";
            this.m_lblArms.Size = new System.Drawing.Size(194, 18);
            this.m_lblArms.TabIndex = 16;
            this.m_lblArms.Text = "Количество попаданий в руку";
            // 
            // m_lblBody
            // 
            this.m_lblBody.Location = new System.Drawing.Point(6, 79);
            this.m_lblBody.Name = "m_lblBody";
            this.m_lblBody.Size = new System.Drawing.Size(194, 20);
            this.m_lblBody.TabIndex = 15;
            this.m_lblBody.Text = "Количество попаданий в тело";
            // 
            // m_lblHead
            // 
            this.m_lblHead.Location = new System.Drawing.Point(6, 53);
            this.m_lblHead.Name = "m_lblHead";
            this.m_lblHead.Size = new System.Drawing.Size(194, 18);
            this.m_lblHead.TabIndex = 14;
            this.m_lblHead.Text = "Количество попаданий в голову";
            // 
            // m_numLegsCount
            // 
            this.m_numLegsCount.Location = new System.Drawing.Point(206, 127);
            this.m_numLegsCount.Name = "m_numLegsCount";
            this.m_numLegsCount.Size = new System.Drawing.Size(73, 20);
            this.m_numLegsCount.TabIndex = 13;
            // 
            // m_numArmsCount
            // 
            this.m_numArmsCount.Location = new System.Drawing.Point(206, 101);
            this.m_numArmsCount.Name = "m_numArmsCount";
            this.m_numArmsCount.Size = new System.Drawing.Size(73, 20);
            this.m_numArmsCount.TabIndex = 12;
            // 
            // m_numBodyCount
            // 
            this.m_numBodyCount.Location = new System.Drawing.Point(206, 77);
            this.m_numBodyCount.Name = "m_numBodyCount";
            this.m_numBodyCount.Size = new System.Drawing.Size(73, 20);
            this.m_numBodyCount.TabIndex = 11;
            // 
            // m_numHeadCount
            // 
            this.m_numHeadCount.Location = new System.Drawing.Point(206, 51);
            this.m_numHeadCount.Name = "m_numHeadCount";
            this.m_numHeadCount.Size = new System.Drawing.Size(73, 20);
            this.m_numHeadCount.TabIndex = 10;
            // 
            // gbxCombatLog
            // 
            this.gbxCombatLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCombatLog.Controls.Add(this.m_btnClearLog);
            this.gbxCombatLog.Controls.Add(this.m_tbxCombatLog);
            this.gbxCombatLog.Location = new System.Drawing.Point(561, 408);
            this.gbxCombatLog.Name = "gbxCombatLog";
            this.gbxCombatLog.Size = new System.Drawing.Size(461, 160);
            this.gbxCombatLog.TabIndex = 4;
            this.gbxCombatLog.TabStop = false;
            this.gbxCombatLog.Text = "Лог боя";
            // 
            // m_btnClearLog
            // 
            this.m_btnClearLog.Location = new System.Drawing.Point(6, 127);
            this.m_btnClearLog.Name = "m_btnClearLog";
            this.m_btnClearLog.Size = new System.Drawing.Size(152, 23);
            this.m_btnClearLog.TabIndex = 27;
            this.m_btnClearLog.Text = "Очистить лог";
            this.m_btnClearLog.UseVisualStyleBackColor = true;
            // 
            // m_tbxCombatLog
            // 
            this.m_tbxCombatLog.Location = new System.Drawing.Point(6, 19);
            this.m_tbxCombatLog.Multiline = true;
            this.m_tbxCombatLog.Name = "m_tbxCombatLog";
            this.m_tbxCombatLog.ReadOnly = true;
            this.m_tbxCombatLog.Size = new System.Drawing.Size(449, 102);
            this.m_tbxCombatLog.TabIndex = 0;
            // 
            // gbxResultsTable
            // 
            this.gbxResultsTable.Controls.Add(this.dataGridView1);
            this.gbxResultsTable.Location = new System.Drawing.Point(12, 408);
            this.gbxResultsTable.Name = "gbxResultsTable";
            this.gbxResultsTable.Size = new System.Drawing.Size(543, 160);
            this.gbxResultsTable.TabIndex = 5;
            this.gbxResultsTable.TabStop = false;
            this.gbxResultsTable.Text = "Таблица результатов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(531, 135);
            this.dataGridView1.TabIndex = 1;
            // 
            // CalculatorForm
            // 
            this.ClientSize = new System.Drawing.Size(1029, 580);
            this.Controls.Add(this.gbxResultsTable);
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
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvTargets)).EndInit();
            this.gbxStrikeBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_numRestHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numBPorAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numTotalHits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numMissCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numLegsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numArmsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numBodyCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numHeadCount)).EndInit();
            this.gbxCombatLog.ResumeLayout(false);
            this.gbxCombatLog.PerformLayout();
            this.gbxResultsTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button m_btnCalculateResult;
        private System.Windows.Forms.NumericUpDown m_numRestHP;
        private System.Windows.Forms.Button m_btnAtackUntil;
        private System.Windows.Forms.Button m_btnAtack;
        private System.Windows.Forms.Label m_lblBPorAP;
        private System.Windows.Forms.NumericUpDown m_numBPorAP;
        private System.Windows.Forms.NumericUpDown m_numHP;
        private System.Windows.Forms.Label m_lblHP;
        private System.Windows.Forms.NumericUpDown m_numTotalHits;
        private System.Windows.Forms.Label m_lblTotalHits;
        private System.Windows.Forms.Label m_lblMiss;
        private System.Windows.Forms.NumericUpDown m_numMissCount;
        private System.Windows.Forms.Label m_lblLegs;
        private System.Windows.Forms.Label m_lblArms;
        private System.Windows.Forms.Label m_lblBody;
        private System.Windows.Forms.Label m_lblHead;
        private System.Windows.Forms.NumericUpDown m_numLegsCount;
        private System.Windows.Forms.NumericUpDown m_numArmsCount;
        private System.Windows.Forms.NumericUpDown m_numBodyCount;
        private System.Windows.Forms.NumericUpDown m_numHeadCount;
        private System.Windows.Forms.GroupBox gbxResultsTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox m_tbxCombatLog;
        private System.Windows.Forms.Button m_btnCalculateTotalResult;
        private System.Windows.Forms.Button m_btnClearLog;
    }
}

