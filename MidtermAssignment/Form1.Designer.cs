using System;

namespace MidtermAssignment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.txtNumYears = new System.Windows.Forms.TextBox();
            this.txtAnnualGrowthRate = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPopulationChangeOutput = new System.Windows.Forms.Label();
            this.lblPopulationOutput = new System.Windows.Forms.Label();
            this.lblYearOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPopchange = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 108);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 61);
            this.label2.TabIndex = 5;
            this.label2.Text = "Population Growth Rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(37, 42);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(172, 23);
            this.txtPopulation.TabIndex = 1;
            // 
            // txtNumYears
            // 
            this.txtNumYears.Location = new System.Drawing.Point(37, 125);
            this.txtNumYears.Name = "txtNumYears";
            this.txtNumYears.Size = new System.Drawing.Size(172, 23);
            this.txtNumYears.TabIndex = 2;
            // 
            // txtAnnualGrowthRate
            // 
            this.txtAnnualGrowthRate.Location = new System.Drawing.Point(37, 218);
            this.txtAnnualGrowthRate.Name = "txtAnnualGrowthRate";
            this.txtAnnualGrowthRate.Size = new System.Drawing.Size(172, 23);
            this.txtAnnualGrowthRate.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblPopulation);
            this.panel2.Controls.Add(this.txtPopulation);
            this.panel2.Controls.Add(this.txtAnnualGrowthRate);
            this.panel2.Controls.Add(this.txtNumYears);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(28, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 275);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Chartreuse;
            this.label5.Location = new System.Drawing.Point(34, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter Annual Growth Rate : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(34, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Number of Years :";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPopulation.Location = new System.Drawing.Point(34, 18);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(105, 15);
            this.lblPopulation.TabIndex = 4;
            this.lblPopulation.Text = "Enter Population :";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(214)))));
            this.panel3.Controls.Add(this.lblPopulationChangeOutput);
            this.panel3.Controls.Add(this.lblPopulationOutput);
            this.panel3.Controls.Add(this.lblYearOutput);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblPopchange);
            this.panel3.Controls.Add(this.lblResults);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(545, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 381);
            this.panel3.TabIndex = 5;
            // 
            // lblPopulationChangeOutput
            // 
            this.lblPopulationChangeOutput.AutoSize = true;
            this.lblPopulationChangeOutput.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulationChangeOutput.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblPopulationChangeOutput.Location = new System.Drawing.Point(262, 42);
            this.lblPopulationChangeOutput.Name = "lblPopulationChangeOutput";
            this.lblPopulationChangeOutput.Size = new System.Drawing.Size(39, 15);
            this.lblPopulationChangeOutput.TabIndex = 7;
            this.lblPopulationChangeOutput.Text = "label8";
            this.lblPopulationChangeOutput.Visible = false;
            // 
            // lblPopulationOutput
            // 
            this.lblPopulationOutput.AutoSize = true;
            this.lblPopulationOutput.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulationOutput.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPopulationOutput.Location = new System.Drawing.Point(131, 42);
            this.lblPopulationOutput.Name = "lblPopulationOutput";
            this.lblPopulationOutput.Size = new System.Drawing.Size(38, 15);
            this.lblPopulationOutput.TabIndex = 6;
            this.lblPopulationOutput.Text = "label7";
            this.lblPopulationOutput.Visible = false;
            // 
            // lblYearOutput
            // 
            this.lblYearOutput.AutoSize = true;
            this.lblYearOutput.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearOutput.ForeColor = System.Drawing.Color.Aqua;
            this.lblYearOutput.Location = new System.Drawing.Point(20, 42);
            this.lblYearOutput.Name = "lblYearOutput";
            this.lblYearOutput.Size = new System.Drawing.Size(37, 15);
            this.lblYearOutput.TabIndex = 5;
            this.lblYearOutput.Text = "label1";
            this.lblYearOutput.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(20, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Year : ";
            // 
            // lblPopchange
            // 
            this.lblPopchange.AutoSize = true;
            this.lblPopchange.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopchange.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblPopchange.Location = new System.Drawing.Point(214, 16);
            this.lblPopchange.Name = "lblPopchange";
            this.lblPopchange.Size = new System.Drawing.Size(131, 17);
            this.lblPopchange.TabIndex = 3;
            this.lblPopchange.Text = "Population Change";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblResults.Location = new System.Drawing.Point(113, 16);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(82, 17);
            this.lblResults.TabIndex = 2;
            this.lblResults.Text = "Population ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCalculate);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnClearResults);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(311, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 275);
            this.panel5.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(17, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 42);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear All Entries";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(133)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(23, 423);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 84);
            this.panel4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imtiaz Rayman";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(17, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 42);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnClearResults
            // 
            this.btnClearResults.BackColor = System.Drawing.Color.Chartreuse;
            this.btnClearResults.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearResults.FlatAppearance.BorderSize = 3;
            this.btnClearResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClearResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnClearResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearResults.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearResults.ForeColor = System.Drawing.Color.Black;
            this.btnClearResults.Location = new System.Drawing.Point(17, 151);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(183, 42);
            this.btnClearResults.TabIndex = 10;
            this.btnClearResults.Text = "Clear Results";
            this.btnClearResults.UseVisualStyleBackColor = false;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Population Growth Rate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.TextBox txtNumYears;
        private System.Windows.Forms.TextBox txtAnnualGrowthRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPopchange;
        private System.Windows.Forms.Label lblPopulationChangeOutput;
        private System.Windows.Forms.Label lblPopulationOutput;
        private System.Windows.Forms.Label lblYearOutput;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearResults;
    }
}

