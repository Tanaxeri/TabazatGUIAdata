namespace TabazatGUIAdata
{
    partial class TabzatGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Gyumolcsok = new System.Windows.Forms.DataGridView();
            this.groupBox_KivalGyumolcs = new System.Windows.Forms.GroupBox();
            this.textBox_Gyumazonosito = new System.Windows.Forms.TextBox();
            this.textBox_GyumNev = new System.Windows.Forms.TextBox();
            this.numericUpDown_EgysegAr = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.button_UjAdat = new System.Windows.Forms.Button();
            this.button_modosit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gyumolcsok)).BeginInit();
            this.groupBox_KivalGyumolcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EgysegAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Gyumolcsok
            // 
            this.dataGridView_Gyumolcsok.AllowUserToAddRows = false;
            this.dataGridView_Gyumolcsok.AllowUserToDeleteRows = false;
            this.dataGridView_Gyumolcsok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Gyumolcsok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Gyumolcsok.Location = new System.Drawing.Point(0, 268);
            this.dataGridView_Gyumolcsok.Name = "dataGridView_Gyumolcsok";
            this.dataGridView_Gyumolcsok.ReadOnly = true;
            this.dataGridView_Gyumolcsok.Size = new System.Drawing.Size(1200, 390);
            this.dataGridView_Gyumolcsok.TabIndex = 0;
            this.dataGridView_Gyumolcsok.SelectionChanged += new System.EventHandler(this.dataGridView_Gyumolcsok_SelectionChanged);
            // 
            // groupBox_KivalGyumolcs
            // 
            this.groupBox_KivalGyumolcs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_KivalGyumolcs.Controls.Add(this.label4);
            this.groupBox_KivalGyumolcs.Controls.Add(this.label3);
            this.groupBox_KivalGyumolcs.Controls.Add(this.label2);
            this.groupBox_KivalGyumolcs.Controls.Add(this.label1);
            this.groupBox_KivalGyumolcs.Controls.Add(this.button1);
            this.groupBox_KivalGyumolcs.Controls.Add(this.button_modosit);
            this.groupBox_KivalGyumolcs.Controls.Add(this.button_UjAdat);
            this.groupBox_KivalGyumolcs.Controls.Add(this.numericUpDown_Mennyiseg);
            this.groupBox_KivalGyumolcs.Controls.Add(this.numericUpDown_EgysegAr);
            this.groupBox_KivalGyumolcs.Controls.Add(this.textBox_GyumNev);
            this.groupBox_KivalGyumolcs.Controls.Add(this.textBox_Gyumazonosito);
            this.groupBox_KivalGyumolcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_KivalGyumolcs.Location = new System.Drawing.Point(0, 0);
            this.groupBox_KivalGyumolcs.Name = "groupBox_KivalGyumolcs";
            this.groupBox_KivalGyumolcs.Size = new System.Drawing.Size(1200, 268);
            this.groupBox_KivalGyumolcs.TabIndex = 1;
            this.groupBox_KivalGyumolcs.TabStop = false;
            this.groupBox_KivalGyumolcs.Text = "Kiválasztott Gyümölcs";
            // 
            // textBox_Gyumazonosito
            // 
            this.textBox_Gyumazonosito.Location = new System.Drawing.Point(46, 73);
            this.textBox_Gyumazonosito.Name = "textBox_Gyumazonosito";
            this.textBox_Gyumazonosito.ReadOnly = true;
            this.textBox_Gyumazonosito.Size = new System.Drawing.Size(83, 26);
            this.textBox_Gyumazonosito.TabIndex = 0;
            // 
            // textBox_GyumNev
            // 
            this.textBox_GyumNev.Location = new System.Drawing.Point(175, 73);
            this.textBox_GyumNev.Name = "textBox_GyumNev";
            this.textBox_GyumNev.Size = new System.Drawing.Size(100, 26);
            this.textBox_GyumNev.TabIndex = 1;
            // 
            // numericUpDown_EgysegAr
            // 
            this.numericUpDown_EgysegAr.DecimalPlaces = 2;
            this.numericUpDown_EgysegAr.Location = new System.Drawing.Point(319, 74);
            this.numericUpDown_EgysegAr.Name = "numericUpDown_EgysegAr";
            this.numericUpDown_EgysegAr.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_EgysegAr.TabIndex = 2;
            // 
            // numericUpDown_Mennyiseg
            // 
            this.numericUpDown_Mennyiseg.DecimalPlaces = 2;
            this.numericUpDown_Mennyiseg.Location = new System.Drawing.Point(510, 74);
            this.numericUpDown_Mennyiseg.Name = "numericUpDown_Mennyiseg";
            this.numericUpDown_Mennyiseg.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Mennyiseg.TabIndex = 3;
            // 
            // button_UjAdat
            // 
            this.button_UjAdat.Location = new System.Drawing.Point(745, 135);
            this.button_UjAdat.Name = "button_UjAdat";
            this.button_UjAdat.Size = new System.Drawing.Size(89, 61);
            this.button_UjAdat.TabIndex = 4;
            this.button_UjAdat.Text = "Új Adat";
            this.button_UjAdat.UseVisualStyleBackColor = true;
            // 
            // button_modosit
            // 
            this.button_modosit.Location = new System.Drawing.Point(745, 34);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(89, 66);
            this.button_modosit.TabIndex = 5;
            this.button_modosit.Text = "Módosítás";
            this.button_modosit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "Törlés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gyümölcs azonosítója";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gyümölcs neve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gyümölcs egységára";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gyümölcs mennyisége";
            // 
            // TabzatGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.groupBox_KivalGyumolcs);
            this.Controls.Add(this.dataGridView_Gyumolcsok);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TabzatGUI";
            this.Text = "TabzatGUI";
            this.Load += new System.EventHandler(this.TabzatGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gyumolcsok)).EndInit();
            this.groupBox_KivalGyumolcs.ResumeLayout(false);
            this.groupBox_KivalGyumolcs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EgysegAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Gyumolcsok;
        private System.Windows.Forms.GroupBox groupBox_KivalGyumolcs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.Button button_UjAdat;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mennyiseg;
        private System.Windows.Forms.NumericUpDown numericUpDown_EgysegAr;
        private System.Windows.Forms.TextBox textBox_GyumNev;
        private System.Windows.Forms.TextBox textBox_Gyumazonosito;
    }
}

