namespace Fiscal
{
    partial class Fiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiscal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLcdpr = new System.Windows.Forms.Button();
            this.btnSpedContribuicoes = new System.Windows.Forms.Button();
            this.btnSpedFiscal = new System.Windows.Forms.Button();
            this.btnSintegra = new System.Windows.Forms.Button();
            this.btnContabilista = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnLcdpr);
            this.groupBox1.Controls.Add(this.btnSpedContribuicoes);
            this.groupBox1.Controls.Add(this.btnSpedFiscal);
            this.groupBox1.Controls.Add(this.btnSintegra);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o arquivo a ser gerado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)), true);
            this.groupBox2.Location = new System.Drawing.Point(17, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 91);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status da Geração";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0,00%";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Scheherazade", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(67, 58);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(453, 18);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(67, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(453, 18);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLcdpr
            // 
            this.btnLcdpr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLcdpr.BackgroundImage")));
            this.btnLcdpr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLcdpr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLcdpr.FlatAppearance.BorderSize = 0;
            this.btnLcdpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLcdpr.Location = new System.Drawing.Point(491, 20);
            this.btnLcdpr.Name = "btnLcdpr";
            this.btnLcdpr.Size = new System.Drawing.Size(95, 95);
            this.btnLcdpr.TabIndex = 7;
            this.btnLcdpr.UseVisualStyleBackColor = true;
            this.btnLcdpr.Click += new System.EventHandler(this.btnLcdpr_Click);
            // 
            // btnSpedContribuicoes
            // 
            this.btnSpedContribuicoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpedContribuicoes.BackgroundImage")));
            this.btnSpedContribuicoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpedContribuicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpedContribuicoes.FlatAppearance.BorderSize = 0;
            this.btnSpedContribuicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpedContribuicoes.Location = new System.Drawing.Point(330, 20);
            this.btnSpedContribuicoes.Name = "btnSpedContribuicoes";
            this.btnSpedContribuicoes.Size = new System.Drawing.Size(95, 95);
            this.btnSpedContribuicoes.TabIndex = 6;
            this.btnSpedContribuicoes.UseVisualStyleBackColor = true;
            this.btnSpedContribuicoes.Click += new System.EventHandler(this.btnSpedContribuicoes_Click);
            // 
            // btnSpedFiscal
            // 
            this.btnSpedFiscal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpedFiscal.BackgroundImage")));
            this.btnSpedFiscal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpedFiscal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpedFiscal.FlatAppearance.BorderSize = 0;
            this.btnSpedFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpedFiscal.Location = new System.Drawing.Point(179, 20);
            this.btnSpedFiscal.Name = "btnSpedFiscal";
            this.btnSpedFiscal.Size = new System.Drawing.Size(95, 95);
            this.btnSpedFiscal.TabIndex = 5;
            this.btnSpedFiscal.UseVisualStyleBackColor = true;
            this.btnSpedFiscal.Click += new System.EventHandler(this.btnSpedFiscal_Click);
            // 
            // btnSintegra
            // 
            this.btnSintegra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSintegra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSintegra.BackgroundImage")));
            this.btnSintegra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSintegra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSintegra.FlatAppearance.BorderSize = 0;
            this.btnSintegra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSintegra.Location = new System.Drawing.Point(34, 20);
            this.btnSintegra.Margin = new System.Windows.Forms.Padding(0);
            this.btnSintegra.Name = "btnSintegra";
            this.btnSintegra.Size = new System.Drawing.Size(95, 95);
            this.btnSintegra.TabIndex = 4;
            this.btnSintegra.UseVisualStyleBackColor = true;
            this.btnSintegra.Click += new System.EventHandler(this.btnSintegra_Click);
            // 
            // btnContabilista
            // 
            this.btnContabilista.BackColor = System.Drawing.Color.Blue;
            this.btnContabilista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContabilista.BackgroundImage")));
            this.btnContabilista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContabilista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContabilista.FlatAppearance.BorderSize = 0;
            this.btnContabilista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContabilista.Font = new System.Drawing.Font("Noto Sans Georgian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContabilista.ForeColor = System.Drawing.Color.White;
            this.btnContabilista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContabilista.Location = new System.Drawing.Point(12, 315);
            this.btnContabilista.Margin = new System.Windows.Forms.Padding(0);
            this.btnContabilista.Name = "btnContabilista";
            this.btnContabilista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnContabilista.Size = new System.Drawing.Size(139, 28);
            this.btnContabilista.TabIndex = 1;
            this.btnContabilista.Text = "Contabilista - F12";
            this.btnContabilista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContabilista.UseVisualStyleBackColor = false;
            this.btnContabilista.Click += new System.EventHandler(this.btnContabilista_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Blue;
            this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Noto Sans Georgian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(157, 315);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(149, 28);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "Configurações - F11";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Blue;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Noto Sans Georgian", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(538, 315);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair.Size = new System.Drawing.Size(95, 28);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair - F10";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Fiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 355);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnContabilista);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscal SG Master | | SGBR SISTEMAS EIRELI";
            this.Load += new System.EventHandler(this.Fiscal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContabilista;
        private System.Windows.Forms.Button btnSpedFiscal;
        private System.Windows.Forms.Button btnSintegra;
        private System.Windows.Forms.Button btnLcdpr;
        private System.Windows.Forms.Button btnSpedContribuicoes;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

