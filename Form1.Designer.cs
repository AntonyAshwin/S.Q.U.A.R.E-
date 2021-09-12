
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.sideText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.areaLabel = new System.Windows.Forms.Label();
            this.alertText = new System.Windows.Forms.Label();
            this.sideCombo = new System.Windows.Forms.ComboBox();
            this.areaCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.diagnolLabel = new System.Windows.Forms.Label();
            this.diagnolCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cubeDiagnolLabel = new System.Windows.Forms.Label();
            this.cubeDiagnolCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sideText
            // 
            this.sideText.Location = new System.Drawing.Point(187, 78);
            this.sideText.Name = "sideText";
            this.sideText.Size = new System.Drawing.Size(164, 22);
            this.sideText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Face Area :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(220, 301);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(109, 34);
            this.calc.TabIndex = 4;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calcArea);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(187, 119);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(0, 17);
            this.areaLabel.TabIndex = 5;
            // 
            // alertText
            // 
            this.alertText.AutoSize = true;
            this.alertText.Location = new System.Drawing.Point(422, 78);
            this.alertText.Name = "alertText";
            this.alertText.Size = new System.Drawing.Size(0, 17);
            this.alertText.TabIndex = 6;
            // 
            // sideCombo
            // 
            this.sideCombo.FormattingEnabled = true;
            this.sideCombo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m",
            "km"});
            this.sideCombo.Location = new System.Drawing.Point(357, 75);
            this.sideCombo.Name = "sideCombo";
            this.sideCombo.Size = new System.Drawing.Size(54, 24);
            this.sideCombo.TabIndex = 7;
            // 
            // areaCombo
            // 
            this.areaCombo.FormattingEnabled = true;
            this.areaCombo.Items.AddRange(new object[] {
            "mm²",
            "cm²",
            "m²",
            "km²"});
            this.areaCombo.Location = new System.Drawing.Point(357, 116);
            this.areaCombo.Name = "areaCombo";
            this.areaCombo.Size = new System.Drawing.Size(54, 24);
            this.areaCombo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Face Diagnol :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // diagnolLabel
            // 
            this.diagnolLabel.AutoSize = true;
            this.diagnolLabel.Location = new System.Drawing.Point(187, 154);
            this.diagnolLabel.Name = "diagnolLabel";
            this.diagnolLabel.Size = new System.Drawing.Size(0, 17);
            this.diagnolLabel.TabIndex = 10;
            // 
            // diagnolCombo
            // 
            this.diagnolCombo.FormattingEnabled = true;
            this.diagnolCombo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m",
            "km"});
            this.diagnolCombo.Location = new System.Drawing.Point(357, 151);
            this.diagnolCombo.Name = "diagnolCombo";
            this.diagnolCombo.Size = new System.Drawing.Size(54, 24);
            this.diagnolCombo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cube Diagnol :";
            // 
            // cubeDiagnolLabel
            // 
            this.cubeDiagnolLabel.AutoSize = true;
            this.cubeDiagnolLabel.Location = new System.Drawing.Point(187, 186);
            this.cubeDiagnolLabel.Name = "cubeDiagnolLabel";
            this.cubeDiagnolLabel.Size = new System.Drawing.Size(0, 17);
            this.cubeDiagnolLabel.TabIndex = 13;
            // 
            // cubeDiagnolCombo
            // 
            this.cubeDiagnolCombo.FormattingEnabled = true;
            this.cubeDiagnolCombo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m",
            "km"});
            this.cubeDiagnolCombo.Location = new System.Drawing.Point(357, 183);
            this.cubeDiagnolCombo.Name = "cubeDiagnolCombo";
            this.cubeDiagnolCombo.Size = new System.Drawing.Size(54, 24);
            this.cubeDiagnolCombo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 347);
            this.Controls.Add(this.cubeDiagnolCombo);
            this.Controls.Add(this.cubeDiagnolLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diagnolCombo);
            this.Controls.Add(this.diagnolLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.areaCombo);
            this.Controls.Add(this.sideCombo);
            this.Controls.Add(this.alertText);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sideText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sideText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label alertText;
        private System.Windows.Forms.ComboBox sideCombo;
        private System.Windows.Forms.ComboBox areaCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label diagnolLabel;
        private System.Windows.Forms.ComboBox diagnolCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cubeDiagnolLabel;
        private System.Windows.Forms.ComboBox cubeDiagnolCombo;
    }
}

