namespace BMI計算機
{
    partial class frmBMI
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtStandar2 = new System.Windows.Forms.Label();
            this.txtStandar4 = new System.Windows.Forms.Label();
            this.txtStandar5 = new System.Windows.Forms.Label();
            this.txtStandar6 = new System.Windows.Forms.Label();
            this.txtStandar1 = new System.Windows.Forms.Label();
            this.txtStandar3 = new System.Windows.Forms.Label();
            this.lblBMICalculate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInput = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.lblResult.Location = new System.Drawing.Point(272, 91);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(252, 35);
            this.lblResult.TabIndex = 1;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.lblBMI.Location = new System.Drawing.Point(14, 92);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(234, 32);
            this.lblBMI.TabIndex = 0;
            this.lblBMI.Text = "身體質量指數(BMI)";
            // 
            // txtStandar2
            // 
            this.txtStandar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtStandar2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtStandar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.txtStandar2.Location = new System.Drawing.Point(698, 235);
            this.txtStandar2.Name = "txtStandar2";
            this.txtStandar2.Size = new System.Drawing.Size(373, 35);
            this.txtStandar2.TabIndex = 5;
            this.txtStandar2.Text = "健康體位：18.5 <= BMI < 24";
            this.txtStandar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStandar4
            // 
            this.txtStandar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtStandar4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtStandar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.txtStandar4.Location = new System.Drawing.Point(698, 315);
            this.txtStandar4.Name = "txtStandar4";
            this.txtStandar4.Size = new System.Drawing.Size(373, 35);
            this.txtStandar4.TabIndex = 7;
            this.txtStandar4.Text = "輕度肥胖：27 <= BMI < 30";
            this.txtStandar4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStandar5
            // 
            this.txtStandar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtStandar5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtStandar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.txtStandar5.Location = new System.Drawing.Point(698, 355);
            this.txtStandar5.Name = "txtStandar5";
            this.txtStandar5.Size = new System.Drawing.Size(373, 35);
            this.txtStandar5.TabIndex = 8;
            this.txtStandar5.Text = "中度肥胖：30 <= BMI < 35";
            this.txtStandar5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStandar6
            // 
            this.txtStandar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtStandar6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtStandar6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.txtStandar6.Location = new System.Drawing.Point(698, 395);
            this.txtStandar6.Name = "txtStandar6";
            this.txtStandar6.Size = new System.Drawing.Size(373, 35);
            this.txtStandar6.TabIndex = 9;
            this.txtStandar6.Text = "重度肥胖：BMI >= 35";
            this.txtStandar6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStandar1
            // 
            this.txtStandar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtStandar1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtStandar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.txtStandar1.Location = new System.Drawing.Point(698, 195);
            this.txtStandar1.Name = "txtStandar1";
            this.txtStandar1.Size = new System.Drawing.Size(373, 35);
            this.txtStandar1.TabIndex = 10;
            this.txtStandar1.Text = "體重過輕：BMI < 18.5";
            this.txtStandar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStandar3
            // 
            this.txtStandar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtStandar3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtStandar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.txtStandar3.Location = new System.Drawing.Point(698, 275);
            this.txtStandar3.Name = "txtStandar3";
            this.txtStandar3.Size = new System.Drawing.Size(373, 35);
            this.txtStandar3.TabIndex = 11;
            this.txtStandar3.Text = "體重過重：24 <= BMI < 27";
            this.txtStandar3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBMICalculate
            // 
            this.lblBMICalculate.AutoSize = true;
            this.lblBMICalculate.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMICalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.lblBMICalculate.Location = new System.Drawing.Point(73, 45);
            this.lblBMICalculate.Name = "lblBMICalculate";
            this.lblBMICalculate.Size = new System.Drawing.Size(250, 60);
            this.lblBMICalculate.TabIndex = 12;
            this.lblBMICalculate.Text = "BMI計算機";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(679, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 35);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(679, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 35);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(679, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 35);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(679, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 35);
            this.label4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(679, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 35);
            this.label5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(679, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 35);
            this.label6.TabIndex = 18;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.lblHeight.Location = new System.Drawing.Point(75, 81);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(118, 32);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "身高(cm)";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.lblWeight.Location = new System.Drawing.Point(75, 137);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(112, 32);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "體重(kg)";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtHeight.Location = new System.Drawing.Point(246, 78);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Multiline = true;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(215, 38);
            this.txtHeight.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.txtWeight.Location = new System.Drawing.Point(246, 134);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(215, 39);
            this.txtWeight.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.btnRun.Location = new System.Drawing.Point(81, 212);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(145, 48);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.btnClear.Location = new System.Drawing.Point(316, 212);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 48);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBMI_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lblInput);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblHeight);
            this.panel1.Controls.Add(this.lblWeight);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.txtHeight);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Location = new System.Drawing.Point(84, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 287);
            this.panel1.TabIndex = 19;
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.lblInput.Location = new System.Drawing.Point(12, 10);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(123, 49);
            this.lblInput.TabIndex = 20;
            this.lblInput.Text = "輸入";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.lblOutput);
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.lblBMI);
            this.panel2.Location = new System.Drawing.Point(83, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 159);
            this.panel2.TabIndex = 20;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.lblOutput.Location = new System.Drawing.Point(12, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(123, 49);
            this.lblOutput.TabIndex = 21;
            this.lblOutput.Text = "輸出";
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1123, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBMICalculate);
            this.Controls.Add(this.txtStandar3);
            this.Controls.Add(this.txtStandar1);
            this.Controls.Add(this.txtStandar6);
            this.Controls.Add(this.txtStandar5);
            this.Controls.Add(this.txtStandar4);
            this.Controls.Add(this.txtStandar2);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI計算機";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label txtStandar2;
        private System.Windows.Forms.Label txtStandar4;
        private System.Windows.Forms.Label txtStandar5;
        private System.Windows.Forms.Label txtStandar6;
        private System.Windows.Forms.Label txtStandar1;
        private System.Windows.Forms.Label txtStandar3;
        private System.Windows.Forms.Label lblBMICalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOutput;
    }
}

