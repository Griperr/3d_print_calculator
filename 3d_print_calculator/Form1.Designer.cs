
namespace _3d_print_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CaltulatorPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelCurrency4 = new System.Windows.Forms.Label();
            this.labelCurrency2 = new System.Windows.Forms.Label();
            this.labelCurrency3 = new System.Windows.Forms.Label();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.labelPriceFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.buttonLoadPreset = new System.Windows.Forms.Button();
            this.buttonSavePreset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProfit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrinterName = new System.Windows.Forms.TextBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.labelMaterialPrice = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.textBoxCurency = new System.Windows.Forms.TextBox();
            this.textBoxMaterialPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.textBoxPrice4Kwh = new System.Windows.Forms.TextBox();
            this.labelPrice4kwh = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.CaltulatorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CaltulatorPage);
            this.tabControl1.Controls.Add(this.SettingsPage);
            this.tabControl1.Location = new System.Drawing.Point(92, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // CaltulatorPage
            // 
            this.CaltulatorPage.Controls.Add(this.splitContainer1);
            this.CaltulatorPage.Controls.Add(this.label1);
            this.CaltulatorPage.Controls.Add(this.label2);
            this.CaltulatorPage.Controls.Add(this.labelWeight);
            this.CaltulatorPage.Controls.Add(this.labelTime);
            this.CaltulatorPage.Controls.Add(this.textBoxWeight);
            this.CaltulatorPage.Controls.Add(this.textBoxTime);
            this.CaltulatorPage.Location = new System.Drawing.Point(4, 22);
            this.CaltulatorPage.Name = "CaltulatorPage";
            this.CaltulatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.CaltulatorPage.Size = new System.Drawing.Size(738, 393);
            this.CaltulatorPage.TabIndex = 0;
            this.CaltulatorPage.Text = "Caltulator";
            this.CaltulatorPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(91, 139);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCalculate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelResult);
            this.splitContainer1.Panel2.Controls.Add(this.labelCurrency4);
            this.splitContainer1.Panel2.Controls.Add(this.labelCurrency2);
            this.splitContainer1.Panel2.Controls.Add(this.labelCurrency3);
            this.splitContainer1.Panel2.Controls.Add(this.labelPrice1);
            this.splitContainer1.Panel2.Controls.Add(this.labelPriceFull);
            this.splitContainer1.Size = new System.Drawing.Size(574, 233);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Price brutto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price netto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cost:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(52, 187);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Gray;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelResult.Location = new System.Drawing.Point(39, 26);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(20, 24);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "0";
            // 
            // labelCurrency4
            // 
            this.labelCurrency4.AutoSize = true;
            this.labelCurrency4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCurrency4.Location = new System.Drawing.Point(110, 148);
            this.labelCurrency4.Name = "labelCurrency4";
            this.labelCurrency4.Size = new System.Drawing.Size(0, 20);
            this.labelCurrency4.TabIndex = 13;
            // 
            // labelCurrency2
            // 
            this.labelCurrency2.AutoSize = true;
            this.labelCurrency2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCurrency2.Location = new System.Drawing.Point(110, 25);
            this.labelCurrency2.Name = "labelCurrency2";
            this.labelCurrency2.Size = new System.Drawing.Size(0, 20);
            this.labelCurrency2.TabIndex = 9;
            // 
            // labelCurrency3
            // 
            this.labelCurrency3.AutoSize = true;
            this.labelCurrency3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCurrency3.Location = new System.Drawing.Point(110, 86);
            this.labelCurrency3.Name = "labelCurrency3";
            this.labelCurrency3.Size = new System.Drawing.Size(0, 20);
            this.labelCurrency3.TabIndex = 12;
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPrice1.Location = new System.Drawing.Point(39, 86);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(20, 24);
            this.labelPrice1.TabIndex = 10;
            this.labelPrice1.Text = "0";
            // 
            // labelPriceFull
            // 
            this.labelPriceFull.AutoSize = true;
            this.labelPriceFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPriceFull.Location = new System.Drawing.Point(39, 148);
            this.labelPriceFull.Name = "labelPriceFull";
            this.labelPriceFull.Size = new System.Drawing.Size(20, 24);
            this.labelPriceFull.TabIndex = 11;
            this.labelPriceFull.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "g";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(458, 43);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(81, 13);
            this.labelWeight.TabIndex = 3;
            this.labelWeight.Text = "Material Weight";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(45, 44);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(50, 13);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Print time";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(545, 37);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 1;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(115, 41);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(87, 20);
            this.textBoxTime.TabIndex = 0;
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.textBoxTax);
            this.SettingsPage.Controls.Add(this.buttonLoadPreset);
            this.SettingsPage.Controls.Add(this.buttonSavePreset);
            this.SettingsPage.Controls.Add(this.label5);
            this.SettingsPage.Controls.Add(this.textBoxProfit);
            this.SettingsPage.Controls.Add(this.label4);
            this.SettingsPage.Controls.Add(this.label3);
            this.SettingsPage.Controls.Add(this.textBoxPrinterName);
            this.SettingsPage.Controls.Add(this.labelPower);
            this.SettingsPage.Controls.Add(this.labelCurrency);
            this.SettingsPage.Controls.Add(this.labelMaterialPrice);
            this.SettingsPage.Controls.Add(this.labelMaterial);
            this.SettingsPage.Controls.Add(this.textBoxPower);
            this.SettingsPage.Controls.Add(this.textBoxCurency);
            this.SettingsPage.Controls.Add(this.textBoxMaterialPrice);
            this.SettingsPage.Controls.Add(this.textBoxMaterial);
            this.SettingsPage.Controls.Add(this.textBoxPrice4Kwh);
            this.SettingsPage.Controls.Add(this.labelPrice4kwh);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(738, 393);
            this.SettingsPage.TabIndex = 1;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(496, 58);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(100, 20);
            this.textBoxTax.TabIndex = 18;
            this.textBoxTax.Text = "0";
            // 
            // buttonLoadPreset
            // 
            this.buttonLoadPreset.Location = new System.Drawing.Point(637, 355);
            this.buttonLoadPreset.Name = "buttonLoadPreset";
            this.buttonLoadPreset.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadPreset.TabIndex = 12;
            this.buttonLoadPreset.Text = "Load Preset";
            this.buttonLoadPreset.UseVisualStyleBackColor = true;
            this.buttonLoadPreset.Click += new System.EventHandler(this.buttonLoadPreset_Click);
            // 
            // buttonSavePreset
            // 
            this.buttonSavePreset.Location = new System.Drawing.Point(540, 355);
            this.buttonSavePreset.Name = "buttonSavePreset";
            this.buttonSavePreset.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePreset.TabIndex = 11;
            this.buttonSavePreset.Text = "Save Preset";
            this.buttonSavePreset.UseVisualStyleBackColor = true;
            this.buttonSavePreset.Click += new System.EventHandler(this.buttonSavePreset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tax";
            // 
            // textBoxProfit
            // 
            this.textBoxProfit.Location = new System.Drawing.Point(496, 26);
            this.textBoxProfit.Name = "textBoxProfit";
            this.textBoxProfit.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfit.TabIndex = 16;
            this.textBoxProfit.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Profit margin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Printer name";
            // 
            // textBoxPrinterName
            // 
            this.textBoxPrinterName.Location = new System.Drawing.Point(164, 26);
            this.textBoxPrinterName.Name = "textBoxPrinterName";
            this.textBoxPrinterName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrinterName.TabIndex = 13;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(80, 233);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(69, 13);
            this.labelPower.TabIndex = 9;
            this.labelPower.Text = "Printer power";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(80, 190);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(49, 13);
            this.labelCurrency.TabIndex = 8;
            this.labelCurrency.Text = "Currency";
            // 
            // labelMaterialPrice
            // 
            this.labelMaterialPrice.AutoSize = true;
            this.labelMaterialPrice.Location = new System.Drawing.Point(32, 144);
            this.labelMaterialPrice.Name = "labelMaterialPrice";
            this.labelMaterialPrice.Size = new System.Drawing.Size(121, 13);
            this.labelMaterialPrice.TabIndex = 7;
            this.labelMaterialPrice.Text = "Price of material per 1kg";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(80, 99);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(73, 13);
            this.labelMaterial.TabIndex = 6;
            this.labelMaterial.Text = "Material name";
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(164, 233);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(100, 20);
            this.textBoxPower.TabIndex = 5;
            this.textBoxPower.Text = "360";
            // 
            // textBoxCurency
            // 
            this.textBoxCurency.Location = new System.Drawing.Point(164, 190);
            this.textBoxCurency.Name = "textBoxCurency";
            this.textBoxCurency.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurency.TabIndex = 4;
            this.textBoxCurency.Text = "zł";
            // 
            // textBoxMaterialPrice
            // 
            this.textBoxMaterialPrice.Location = new System.Drawing.Point(164, 144);
            this.textBoxMaterialPrice.Name = "textBoxMaterialPrice";
            this.textBoxMaterialPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaterialPrice.TabIndex = 3;
            this.textBoxMaterialPrice.Text = "60";
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(164, 99);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaterial.TabIndex = 2;
            // 
            // textBoxPrice4Kwh
            // 
            this.textBoxPrice4Kwh.Location = new System.Drawing.Point(164, 58);
            this.textBoxPrice4Kwh.Name = "textBoxPrice4Kwh";
            this.textBoxPrice4Kwh.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice4Kwh.TabIndex = 1;
            this.textBoxPrice4Kwh.Text = "0,70";
            // 
            // labelPrice4kwh
            // 
            this.labelPrice4kwh.AutoSize = true;
            this.labelPrice4kwh.Location = new System.Drawing.Point(80, 66);
            this.labelPrice4kwh.Name = "labelPrice4kwh";
            this.labelPrice4kwh.Size = new System.Drawing.Size(72, 13);
            this.labelPrice4kwh.TabIndex = 0;
            this.labelPrice4kwh.Text = "Price for kWh";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\";  ";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save your preset";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Prints Price Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.CaltulatorPage.ResumeLayout(false);
            this.CaltulatorPage.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CaltulatorPage;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelMaterialPrice;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.TextBox textBoxCurency;
        private System.Windows.Forms.TextBox textBoxMaterialPrice;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxPrice4Kwh;
        private System.Windows.Forms.Label labelPrice4kwh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrency2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrinterName;
        private System.Windows.Forms.Button buttonLoadPreset;
        private System.Windows.Forms.Button buttonSavePreset;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurrency4;
        private System.Windows.Forms.Label labelCurrency3;
        private System.Windows.Forms.Label labelPriceFull;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

