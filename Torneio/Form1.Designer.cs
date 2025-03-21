namespace Torneio
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabCntrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewJogos = new System.Windows.Forms.DataGridView();
            this.btnGameDel = new System.Windows.Forms.Button();
            this.btnGameAlter = new System.Windows.Forms.Button();
            this.btnGameAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClubDel = new System.Windows.Forms.Button();
            this.btnClubAlter = new System.Windows.Forms.Button();
            this.btnClubAdd = new System.Windows.Forms.Button();
            this.dataGridViewClubes = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewJogadores = new System.Windows.Forms.DataGridView();
            this.btnPlayerDel = new System.Windows.Forms.Button();
            this.btnPlayerAlter = new System.Windows.Forms.Button();
            this.btnPlayerAdd = new System.Windows.Forms.Button();
            this.TabCntrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJogos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubes)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCntrl
            // 
            this.TabCntrl.Controls.Add(this.tabPage1);
            this.TabCntrl.Controls.Add(this.tabPage2);
            this.TabCntrl.Controls.Add(this.tabPage3);
            this.TabCntrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCntrl.Location = new System.Drawing.Point(2, 1);
            this.TabCntrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabCntrl.Name = "TabCntrl";
            this.TabCntrl.SelectedIndex = 0;
            this.TabCntrl.Size = new System.Drawing.Size(1200, 619);
            this.TabCntrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCntrl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage1.Controls.Add(this.dataGridViewJogos);
            this.tabPage1.Controls.Add(this.btnGameDel);
            this.tabPage1.Controls.Add(this.btnGameAlter);
            this.tabPage1.Controls.Add(this.btnGameAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1192, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jogos";
            // 
            // dataGridViewJogos
            // 
            this.dataGridViewJogos.AllowUserToAddRows = false;
            this.dataGridViewJogos.AllowUserToDeleteRows = false;
            this.dataGridViewJogos.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewJogos.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewJogos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewJogos.Name = "dataGridViewJogos";
            this.dataGridViewJogos.ReadOnly = true;
            this.dataGridViewJogos.RowHeadersWidth = 51;
            this.dataGridViewJogos.Size = new System.Drawing.Size(1184, 461);
            this.dataGridViewJogos.TabIndex = 3;
            // 
            // btnGameDel
            // 
            this.btnGameDel.BackColor = System.Drawing.Color.MintCream;
            this.btnGameDel.Location = new System.Drawing.Point(720, 503);
            this.btnGameDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGameDel.Name = "btnGameDel";
            this.btnGameDel.Size = new System.Drawing.Size(182, 44);
            this.btnGameDel.TabIndex = 2;
            this.btnGameDel.Text = "Excluir";
            this.btnGameDel.UseVisualStyleBackColor = false;
            this.btnGameDel.Click += new System.EventHandler(this.btnGameDel_Click);
            // 
            // btnGameAlter
            // 
            this.btnGameAlter.BackColor = System.Drawing.Color.MintCream;
            this.btnGameAlter.Location = new System.Drawing.Point(502, 503);
            this.btnGameAlter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGameAlter.Name = "btnGameAlter";
            this.btnGameAlter.Size = new System.Drawing.Size(182, 44);
            this.btnGameAlter.TabIndex = 1;
            this.btnGameAlter.Text = "Alterar";
            this.btnGameAlter.UseVisualStyleBackColor = false;
            this.btnGameAlter.Click += new System.EventHandler(this.btnGameAlter_Click);
            // 
            // btnGameAdd
            // 
            this.btnGameAdd.BackColor = System.Drawing.Color.MintCream;
            this.btnGameAdd.Location = new System.Drawing.Point(285, 503);
            this.btnGameAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGameAdd.Name = "btnGameAdd";
            this.btnGameAdd.Size = new System.Drawing.Size(182, 44);
            this.btnGameAdd.TabIndex = 0;
            this.btnGameAdd.Text = "Adicionar";
            this.btnGameAdd.UseVisualStyleBackColor = false;
            this.btnGameAdd.Click += new System.EventHandler(this.btnGameAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage2.Controls.Add(this.btnClubDel);
            this.tabPage2.Controls.Add(this.btnClubAlter);
            this.tabPage2.Controls.Add(this.btnClubAdd);
            this.tabPage2.Controls.Add(this.dataGridViewClubes);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1192, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clubes";
            // 
            // btnClubDel
            // 
            this.btnClubDel.BackColor = System.Drawing.Color.MintCream;
            this.btnClubDel.Location = new System.Drawing.Point(720, 503);
            this.btnClubDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClubDel.Name = "btnClubDel";
            this.btnClubDel.Size = new System.Drawing.Size(182, 44);
            this.btnClubDel.TabIndex = 3;
            this.btnClubDel.Text = "Excluir";
            this.btnClubDel.UseVisualStyleBackColor = false;
            this.btnClubDel.Click += new System.EventHandler(this.btnClubDel_Click);
            // 
            // btnClubAlter
            // 
            this.btnClubAlter.BackColor = System.Drawing.Color.MintCream;
            this.btnClubAlter.Location = new System.Drawing.Point(502, 503);
            this.btnClubAlter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClubAlter.Name = "btnClubAlter";
            this.btnClubAlter.Size = new System.Drawing.Size(182, 44);
            this.btnClubAlter.TabIndex = 2;
            this.btnClubAlter.Text = "Alterar";
            this.btnClubAlter.UseVisualStyleBackColor = false;
            this.btnClubAlter.Click += new System.EventHandler(this.btnClubAlter_Click);
            // 
            // btnClubAdd
            // 
            this.btnClubAdd.BackColor = System.Drawing.Color.MintCream;
            this.btnClubAdd.Location = new System.Drawing.Point(285, 503);
            this.btnClubAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClubAdd.Name = "btnClubAdd";
            this.btnClubAdd.Size = new System.Drawing.Size(182, 44);
            this.btnClubAdd.TabIndex = 1;
            this.btnClubAdd.Text = "Adicionar";
            this.btnClubAdd.UseVisualStyleBackColor = false;
            this.btnClubAdd.Click += new System.EventHandler(this.btnClubAdd_Click);
            // 
            // dataGridViewClubes
            // 
            this.dataGridViewClubes.AllowUserToAddRows = false;
            this.dataGridViewClubes.AllowUserToDeleteRows = false;
            this.dataGridViewClubes.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewClubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClubes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewClubes.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewClubes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewClubes.Name = "dataGridViewClubes";
            this.dataGridViewClubes.ReadOnly = true;
            this.dataGridViewClubes.RowHeadersWidth = 51;
            this.dataGridViewClubes.Size = new System.Drawing.Size(1184, 461);
            this.dataGridViewClubes.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.dataGridViewJogadores);
            this.tabPage3.Controls.Add(this.btnPlayerDel);
            this.tabPage3.Controls.Add(this.btnPlayerAlter);
            this.tabPage3.Controls.Add(this.btnPlayerAdd);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1192, 588);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Jogadores";
            // 
            // dataGridViewJogadores
            // 
            this.dataGridViewJogadores.AllowUserToAddRows = false;
            this.dataGridViewJogadores.AllowUserToDeleteRows = false;
            this.dataGridViewJogadores.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJogadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewJogadores.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewJogadores.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewJogadores.Name = "dataGridViewJogadores";
            this.dataGridViewJogadores.ReadOnly = true;
            this.dataGridViewJogadores.RowHeadersWidth = 51;
            this.dataGridViewJogadores.Size = new System.Drawing.Size(1184, 461);
            this.dataGridViewJogadores.TabIndex = 7;
            // 
            // btnPlayerDel
            // 
            this.btnPlayerDel.BackColor = System.Drawing.Color.MintCream;
            this.btnPlayerDel.Location = new System.Drawing.Point(720, 503);
            this.btnPlayerDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayerDel.Name = "btnPlayerDel";
            this.btnPlayerDel.Size = new System.Drawing.Size(182, 44);
            this.btnPlayerDel.TabIndex = 6;
            this.btnPlayerDel.Text = "Excluir";
            this.btnPlayerDel.UseVisualStyleBackColor = false;
            this.btnPlayerDel.Click += new System.EventHandler(this.btnPlayerDel_Click);
            // 
            // btnPlayerAlter
            // 
            this.btnPlayerAlter.BackColor = System.Drawing.Color.MintCream;
            this.btnPlayerAlter.Location = new System.Drawing.Point(502, 503);
            this.btnPlayerAlter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayerAlter.Name = "btnPlayerAlter";
            this.btnPlayerAlter.Size = new System.Drawing.Size(182, 44);
            this.btnPlayerAlter.TabIndex = 5;
            this.btnPlayerAlter.Text = "Alterar";
            this.btnPlayerAlter.UseVisualStyleBackColor = false;
            this.btnPlayerAlter.Click += new System.EventHandler(this.btnPlayerAlter_Click);
            // 
            // btnPlayerAdd
            // 
            this.btnPlayerAdd.BackColor = System.Drawing.Color.MintCream;
            this.btnPlayerAdd.Location = new System.Drawing.Point(285, 503);
            this.btnPlayerAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayerAdd.Name = "btnPlayerAdd";
            this.btnPlayerAdd.Size = new System.Drawing.Size(182, 44);
            this.btnPlayerAdd.TabIndex = 4;
            this.btnPlayerAdd.Text = "Adicionar";
            this.btnPlayerAdd.UseVisualStyleBackColor = false;
            this.btnPlayerAdd.Click += new System.EventHandler(this.btnPlayerAdd_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.TabCntrl);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Torneio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabCntrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJogos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubes)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJogadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCntrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGameDel;
        private System.Windows.Forms.Button btnGameAlter;
        private System.Windows.Forms.Button btnGameAdd;
        private System.Windows.Forms.DataGridView dataGridViewJogos;
        private System.Windows.Forms.Button btnClubDel;
        private System.Windows.Forms.Button btnClubAlter;
        private System.Windows.Forms.Button btnClubAdd;
        private System.Windows.Forms.DataGridView dataGridViewClubes;
        private System.Windows.Forms.DataGridView dataGridViewJogadores;
        private System.Windows.Forms.Button btnPlayerDel;
        private System.Windows.Forms.Button btnPlayerAlter;
        private System.Windows.Forms.Button btnPlayerAdd;
    }
}

