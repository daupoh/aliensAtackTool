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
            this.gbxWeaponTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvWeapons)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCalculatorMode
            // 
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
            this.gbxTargetTable.Location = new System.Drawing.Point(341, 12);
            this.gbxTargetTable.Name = "gbxTargetTable";
            this.gbxTargetTable.Size = new System.Drawing.Size(491, 202);
            this.gbxTargetTable.TabIndex = 2;
            this.gbxTargetTable.TabStop = false;
            this.gbxTargetTable.Text = "Таблица целей";
            // 
            // gbxStrikeBlock
            // 
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
            this.gbxWeaponTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvWeapons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCalculatorMode;
        private System.Windows.Forms.GroupBox gbxWeaponTable;
        private System.Windows.Forms.DataGridView m_dgvWeapons;
        private System.Windows.Forms.GroupBox gbxTargetTable;
        private System.Windows.Forms.GroupBox gbxStrikeBlock;
        private System.Windows.Forms.GroupBox gbxCombatLog;
    }
}

