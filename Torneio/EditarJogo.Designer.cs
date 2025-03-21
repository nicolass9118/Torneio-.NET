namespace Torneio
{
    partial class EditarJogo
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
            this.labelClubeFora = new System.Windows.Forms.Label();
            this.labelClubeCasa = new System.Windows.Forms.Label();
            this.labelGolCasa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGolFora = new System.Windows.Forms.Label();
            this.buttonAddGoalH = new System.Windows.Forms.Button();
            this.buttonAddGoalA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelClubeFora
            // 
            this.labelClubeFora.AutoSize = true;
            this.labelClubeFora.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClubeFora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClubeFora.Location = new System.Drawing.Point(643, 77);
            this.labelClubeFora.Name = "labelClubeFora";
            this.labelClubeFora.Size = new System.Drawing.Size(193, 38);
            this.labelClubeFora.TabIndex = 0;
            this.labelClubeFora.Text = "Placeholder";
            // 
            // labelClubeCasa
            // 
            this.labelClubeCasa.AutoSize = true;
            this.labelClubeCasa.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClubeCasa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClubeCasa.Location = new System.Drawing.Point(95, 77);
            this.labelClubeCasa.Name = "labelClubeCasa";
            this.labelClubeCasa.Size = new System.Drawing.Size(193, 38);
            this.labelClubeCasa.TabIndex = 0;
            this.labelClubeCasa.Text = "Placeholder";
            // 
            // labelGolCasa
            // 
            this.labelGolCasa.AutoSize = true;
            this.labelGolCasa.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGolCasa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGolCasa.Location = new System.Drawing.Point(294, 69);
            this.labelGolCasa.Name = "labelGolCasa";
            this.labelGolCasa.Size = new System.Drawing.Size(121, 136);
            this.labelGolCasa.TabIndex = 1;
            this.labelGolCasa.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(410, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 136);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            // 
            // labelGolFora
            // 
            this.labelGolFora.AutoSize = true;
            this.labelGolFora.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGolFora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGolFora.Location = new System.Drawing.Point(523, 69);
            this.labelGolFora.Name = "labelGolFora";
            this.labelGolFora.Size = new System.Drawing.Size(121, 136);
            this.labelGolFora.TabIndex = 1;
            this.labelGolFora.Text = "0";
            // 
            // buttonAddGoalH
            // 
            this.buttonAddGoalH.BackColor = System.Drawing.Color.MintCream;
            this.buttonAddGoalH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAddGoalH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddGoalH.Location = new System.Drawing.Point(102, 135);
            this.buttonAddGoalH.Name = "buttonAddGoalH";
            this.buttonAddGoalH.Size = new System.Drawing.Size(186, 44);
            this.buttonAddGoalH.TabIndex = 2;
            this.buttonAddGoalH.Text = "+";
            this.buttonAddGoalH.UseVisualStyleBackColor = false;
            this.buttonAddGoalH.Click += new System.EventHandler(this.buttonAddGoalH_Click);
            // 
            // buttonAddGoalA
            // 
            this.buttonAddGoalA.BackColor = System.Drawing.Color.MintCream;
            this.buttonAddGoalA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAddGoalA.Location = new System.Drawing.Point(650, 135);
            this.buttonAddGoalA.Name = "buttonAddGoalA";
            this.buttonAddGoalA.Size = new System.Drawing.Size(186, 44);
            this.buttonAddGoalA.TabIndex = 2;
            this.buttonAddGoalA.Text = "+";
            this.buttonAddGoalA.UseVisualStyleBackColor = false;
            this.buttonAddGoalA.Click += new System.EventHandler(this.buttonAddGoalA_Click);
            // 
            // EditarJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(940, 284);
            this.Controls.Add(this.buttonAddGoalA);
            this.Controls.Add(this.buttonAddGoalH);
            this.Controls.Add(this.labelGolFora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelGolCasa);
            this.Controls.Add(this.labelClubeCasa);
            this.Controls.Add(this.labelClubeFora);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditarJogo";
            this.Text = "EditarJogo";
            this.Load += new System.EventHandler(this.EditarJogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClubeFora;
        private System.Windows.Forms.Label labelClubeCasa;
        private System.Windows.Forms.Label labelGolCasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGolFora;
        private System.Windows.Forms.Button buttonAddGoalH;
        private System.Windows.Forms.Button buttonAddGoalA;
    }
}