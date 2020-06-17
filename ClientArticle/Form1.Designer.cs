namespace ClientArticle
{
    partial class Form1
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEntrezTitre = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(123, 65);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(443, 42);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Ajout d\'article au Serveur:";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(236, 156);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(157, 25);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Entrez votre Id:";
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Location = new System.Drawing.Point(153, 256);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(240, 25);
            this.lblArticle.TabIndex = 2;
            this.lblArticle.Text = "Soumettez votre Article:";
            this.lblArticle.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(408, 156);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 31);
            this.txtId.TabIndex = 3;
            // 
            // txtArticle
            // 
            this.txtArticle.Location = new System.Drawing.Point(408, 253);
            this.txtArticle.Multiline = true;
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(516, 539);
            this.txtArticle.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(789, 830);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 41);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Soumetter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEntrezTitre
            // 
            this.lblEntrezTitre.AutoSize = true;
            this.lblEntrezTitre.Location = new System.Drawing.Point(248, 205);
            this.lblEntrezTitre.Name = "lblEntrezTitre";
            this.lblEntrezTitre.Size = new System.Drawing.Size(145, 25);
            this.lblEntrezTitre.TabIndex = 6;
            this.lblEntrezTitre.Text = "Entrez le titre:";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(408, 205);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(516, 31);
            this.txtTitre.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1129, 1026);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.lblEntrezTitre);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitre);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEntrezTitre;
        private System.Windows.Forms.TextBox txtTitre;
    }
}

