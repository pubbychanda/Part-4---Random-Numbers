
namespace Part_4___Random_Assignment
{
    partial class frmMain
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.numMinimum = new System.Windows.Forms.NumericUpDown();
            this.rdoIntegers = new System.Windows.Forms.RadioButton();
            this.rdoDoubles = new System.Windows.Forms.RadioButton();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.lblDecimalInterval = new System.Windows.Forms.Label();
            this.numDecimalInterval = new System.Windows.Forms.NumericUpDown();
            this.lblGetResult = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecimalInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(644, 24);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Please select a numeric type, then enter a minimum and maximum number:";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMinimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMinimum.Location = new System.Drawing.Point(432, 45);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(76, 20);
            this.lblMinimum.TabIndex = 1;
            this.lblMinimum.Text = "Minimum:";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaximum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMaximum.Location = new System.Drawing.Point(432, 82);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(84, 20);
            this.lblMaximum.TabIndex = 2;
            this.lblMaximum.Text = "Maximum: ";
            // 
            // numMinimum
            // 
            this.numMinimum.Location = new System.Drawing.Point(521, 45);
            this.numMinimum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMinimum.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numMinimum.Name = "numMinimum";
            this.numMinimum.Size = new System.Drawing.Size(120, 20);
            this.numMinimum.TabIndex = 4;
            this.numMinimum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numMinimum_MouseDown);
            this.numMinimum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numMinimum_MouseUp);
            // 
            // rdoIntegers
            // 
            this.rdoIntegers.AutoSize = true;
            this.rdoIntegers.Checked = true;
            this.rdoIntegers.Location = new System.Drawing.Point(16, 48);
            this.rdoIntegers.Name = "rdoIntegers";
            this.rdoIntegers.Size = new System.Drawing.Size(63, 17);
            this.rdoIntegers.TabIndex = 5;
            this.rdoIntegers.TabStop = true;
            this.rdoIntegers.Text = "Integers";
            this.rdoIntegers.UseVisualStyleBackColor = true;
            // 
            // rdoDoubles
            // 
            this.rdoDoubles.AutoSize = true;
            this.rdoDoubles.Location = new System.Drawing.Point(15, 71);
            this.rdoDoubles.Name = "rdoDoubles";
            this.rdoDoubles.Size = new System.Drawing.Size(64, 17);
            this.rdoDoubles.TabIndex = 6;
            this.rdoDoubles.Text = "Doubles";
            this.rdoDoubles.UseVisualStyleBackColor = true;
            // 
            // txtMaximum
            // 
            this.txtMaximum.Location = new System.Drawing.Point(522, 82);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.Size = new System.Drawing.Size(119, 20);
            this.txtMaximum.TabIndex = 7;
            // 
            // lblDecimalInterval
            // 
            this.lblDecimalInterval.AutoSize = true;
            this.lblDecimalInterval.Location = new System.Drawing.Point(12, 105);
            this.lblDecimalInterval.Name = "lblDecimalInterval";
            this.lblDecimalInterval.Size = new System.Drawing.Size(136, 13);
            this.lblDecimalInterval.TabIndex = 8;
            this.lblDecimalInterval.Text = "Decimal places to round to:";
            // 
            // numDecimalInterval
            // 
            this.numDecimalInterval.Location = new System.Drawing.Point(154, 103);
            this.numDecimalInterval.Name = "numDecimalInterval";
            this.numDecimalInterval.Size = new System.Drawing.Size(38, 20);
            this.numDecimalInterval.TabIndex = 9;
            this.numDecimalInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGetResult
            // 
            this.lblGetResult.Location = new System.Drawing.Point(485, 120);
            this.lblGetResult.Name = "lblGetResult";
            this.lblGetResult.Size = new System.Drawing.Size(156, 42);
            this.lblGetResult.TabIndex = 10;
            this.lblGetResult.Text = "Get Number!";
            this.lblGetResult.UseVisualStyleBackColor = true;
            this.lblGetResult.Click += new System.EventHandler(this.lblGetResult_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Location = new System.Drawing.Point(336, 131);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(143, 23);
            this.lblAnswer.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 174);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblGetResult);
            this.Controls.Add(this.numDecimalInterval);
            this.Controls.Add(this.lblDecimalInterval);
            this.Controls.Add(this.txtMaximum);
            this.Controls.Add(this.rdoDoubles);
            this.Controls.Add(this.rdoIntegers);
            this.Controls.Add(this.numMinimum);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblInstructions);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMain";
            this.Text = "Number Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecimalInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.NumericUpDown numMinimum;
        private System.Windows.Forms.RadioButton rdoIntegers;
        private System.Windows.Forms.RadioButton rdoDoubles;
        private System.Windows.Forms.TextBox txtMaximum;
        private System.Windows.Forms.Label lblDecimalInterval;
        private System.Windows.Forms.NumericUpDown numDecimalInterval;
        private System.Windows.Forms.Button lblGetResult;
        private System.Windows.Forms.Label lblAnswer;
    }
}

