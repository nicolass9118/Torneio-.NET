namespace Torneio
{
    partial class AdicionarGol
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
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.buttonAddGoal = new System.Windows.Forms.Button();
            this.maskedTextBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(46, 47);
            this.comboBoxPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(638, 30);
            this.comboBoxPlayer.TabIndex = 0;
            // 
            // buttonAddGoal
            // 
            this.buttonAddGoal.BackColor = System.Drawing.Color.MintCream;
            this.buttonAddGoal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGoal.Location = new System.Drawing.Point(513, 205);
            this.buttonAddGoal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddGoal.Name = "buttonAddGoal";
            this.buttonAddGoal.Size = new System.Drawing.Size(174, 61);
            this.buttonAddGoal.TabIndex = 1;
            this.buttonAddGoal.Text = "Adicionar";
            this.buttonAddGoal.UseVisualStyleBackColor = false;
            this.buttonAddGoal.Click += new System.EventHandler(this.buttonAddGoal_Click);
            // 
            // maskedTextBoxTime
            // 
            this.maskedTextBoxTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxTime.Location = new System.Drawing.Point(46, 142);
            this.maskedTextBoxTime.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.maskedTextBoxTime.Mask = "990";
            this.maskedTextBoxTime.Name = "maskedTextBoxTime";
            this.maskedTextBoxTime.Size = new System.Drawing.Size(76, 29);
            this.maskedTextBoxTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "\'";
            // 
            // AdicionarGol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(742, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxTime);
            this.Controls.Add(this.buttonAddGoal);
            this.Controls.Add(this.comboBoxPlayer);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdicionarGol";
            this.Text = "AdicionarGol";
            this.Load += new System.EventHandler(this.AdicionarGol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.Button buttonAddGoal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTime;
        private System.Windows.Forms.Label label1;
    }
}