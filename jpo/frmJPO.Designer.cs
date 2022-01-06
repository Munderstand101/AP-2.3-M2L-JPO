namespace jpo
{
    partial class frmJPO
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripJPO = new System.Windows.Forms.MenuStrip();
            this.membresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrementLiguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionLiguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrementMembresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionMembresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripJPO.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripJPO
            // 
            this.menuStripJPO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membresToolStripMenuItem,
            this.liguesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStripJPO.Location = new System.Drawing.Point(0, 0);
            this.menuStripJPO.Name = "menuStripJPO";
            this.menuStripJPO.Size = new System.Drawing.Size(1014, 24);
            this.menuStripJPO.TabIndex = 7;
            this.menuStripJPO.Text = "menuStrip1";
            // 
            // membresToolStripMenuItem
            // 
            this.membresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrementLiguesToolStripMenuItem,
            this.inscriptionLiguesToolStripMenuItem});
            this.membresToolStripMenuItem.Name = "membresToolStripMenuItem";
            this.membresToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.membresToolStripMenuItem.Text = "Ligues";
            // 
            // enregistrementLiguesToolStripMenuItem
            // 
            this.enregistrementLiguesToolStripMenuItem.Name = "enregistrementLiguesToolStripMenuItem";
            this.enregistrementLiguesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.enregistrementLiguesToolStripMenuItem.Text = "Enregistrement ligues";
            this.enregistrementLiguesToolStripMenuItem.Click += new System.EventHandler(this.enregistrementLiguesToolStripMenuItem_Click);
            // 
            // inscriptionLiguesToolStripMenuItem
            // 
            this.inscriptionLiguesToolStripMenuItem.Name = "inscriptionLiguesToolStripMenuItem";
            this.inscriptionLiguesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.inscriptionLiguesToolStripMenuItem.Text = "Inscription Ligues";
            this.inscriptionLiguesToolStripMenuItem.Click += new System.EventHandler(this.inscriptionLiguesToolStripMenuItem_Click);
            // 
            // liguesToolStripMenuItem
            // 
            this.liguesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrementMembresToolStripMenuItem,
            this.inscriptionMembresToolStripMenuItem});
            this.liguesToolStripMenuItem.Name = "liguesToolStripMenuItem";
            this.liguesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.liguesToolStripMenuItem.Text = "Membres";
            // 
            // enregistrementMembresToolStripMenuItem
            // 
            this.enregistrementMembresToolStripMenuItem.Name = "enregistrementMembresToolStripMenuItem";
            this.enregistrementMembresToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.enregistrementMembresToolStripMenuItem.Text = "Enregistrement membres";
            this.enregistrementMembresToolStripMenuItem.Click += new System.EventHandler(this.enregistrementMembresToolStripMenuItem_Click);
            // 
            // inscriptionMembresToolStripMenuItem
            // 
            this.inscriptionMembresToolStripMenuItem.Name = "inscriptionMembresToolStripMenuItem";
            this.inscriptionMembresToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.inscriptionMembresToolStripMenuItem.Text = "Inscription membres";
            this.inscriptionMembresToolStripMenuItem.Click += new System.EventHandler(this.inscriptionMembresToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // frmJPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 528);
            this.Controls.Add(this.menuStripJPO);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripJPO;
            this.Name = "frmJPO";
            this.Text = "JPO";
            this.Load += new System.EventHandler(this.frmJPO_Load);
            this.menuStripJPO.ResumeLayout(false);
            this.menuStripJPO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripJPO;
        private System.Windows.Forms.ToolStripMenuItem membresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrementLiguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionLiguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrementMembresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionMembresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

