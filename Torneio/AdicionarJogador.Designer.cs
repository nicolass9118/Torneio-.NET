namespace Torneio
{
    partial class AdicionarJogador
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
            this.textBoxJogador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClubeJogador = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(58, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // textBoxJogador
            // 
            this.textBoxJogador.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJogador.Location = new System.Drawing.Point(68, 114);
            this.textBoxJogador.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxJogador.Name = "textBoxJogador";
            this.textBoxJogador.Size = new System.Drawing.Size(900, 32);
            this.textBoxJogador.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(58, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clube:";
            // 
            // comboBoxClubeJogador
            // 
            this.comboBoxClubeJogador.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClubeJogador.FormattingEnabled = true;
            this.comboBoxClubeJogador.Location = new System.Drawing.Point(68, 262);
            this.comboBoxClubeJogador.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxClubeJogador.Name = "comboBoxClubeJogador";
            this.comboBoxClubeJogador.Size = new System.Drawing.Size(700, 32);
            this.comboBoxClubeJogador.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MintCream;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(782, 262);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(190, 66);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AdicionarJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1070, 380);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxClubeJogador);
            this.Controls.Add(this.textBoxJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdicionarJogador";
            this.Text = "AdicionarJogador";
            this.Load += new System.EventHandler(this.AdicionarJogador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClubeJogador;
        private System.Windows.Forms.Button buttonAdd;
    }
}