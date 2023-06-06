namespace GestionsEcole
{
    partial class FicheClasse
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
            this.components = new System.ComponentModel.Container();
            this.text_Id_classe = new System.Windows.Forms.TextBox();
            this.text_Niveau = new System.Windows.Forms.TextBox();
            this.lb_id_Classe = new System.Windows.Forms.Label();
            this.lb_Niveau = new System.Windows.Forms.Label();
            this.lb_prof_principal = new System.Windows.Forms.Label();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.bsProfesseur = new System.Windows.Forms.BindingSource(this.components);
            this.comboProfesseur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Id_classe
            // 
            this.text_Id_classe.Location = new System.Drawing.Point(126, 38);
            this.text_Id_classe.Name = "text_Id_classe";
            this.text_Id_classe.Size = new System.Drawing.Size(121, 20);
            this.text_Id_classe.TabIndex = 0;
            // 
            // text_Niveau
            // 
            this.text_Niveau.Location = new System.Drawing.Point(126, 84);
            this.text_Niveau.Name = "text_Niveau";
            this.text_Niveau.Size = new System.Drawing.Size(121, 20);
            this.text_Niveau.TabIndex = 3;
            // 
            // lb_id_Classe
            // 
            this.lb_id_Classe.AutoSize = true;
            this.lb_id_Classe.Location = new System.Drawing.Point(35, 41);
            this.lb_id_Classe.Name = "lb_id_Classe";
            this.lb_id_Classe.Size = new System.Drawing.Size(53, 13);
            this.lb_id_Classe.TabIndex = 4;
            this.lb_id_Classe.Text = "Identifiant";
            // 
            // lb_Niveau
            // 
            this.lb_Niveau.AutoSize = true;
            this.lb_Niveau.Location = new System.Drawing.Point(35, 87);
            this.lb_Niveau.Name = "lb_Niveau";
            this.lb_Niveau.Size = new System.Drawing.Size(41, 13);
            this.lb_Niveau.TabIndex = 5;
            this.lb_Niveau.Text = "Niveau";
            // 
            // lb_prof_principal
            // 
            this.lb_prof_principal.AutoSize = true;
            this.lb_prof_principal.Location = new System.Drawing.Point(35, 129);
            this.lb_prof_principal.Name = "lb_prof_principal";
            this.lb_prof_principal.Size = new System.Drawing.Size(68, 13);
            this.lb_prof_principal.TabIndex = 6;
            this.lb_prof_principal.Text = "Prof principal";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(28, 216);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(89, 22);
            this.btn_Annuler.TabIndex = 7;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(165, 216);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(93, 22);
            this.btn_Valider.TabIndex = 8;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // bs
            // 
            this.bs.DataSource = typeof(GestionsEcole.Classe);
            // 
            // bsProfesseur
            // 
            this.bsProfesseur.DataSource = typeof(GestionsEcole.Professeur);
            // 
            // comboProfesseur
            // 
            this.comboProfesseur.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bs, "LeProfesseur", true));
            this.comboProfesseur.DataSource = this.bsProfesseur;
            this.comboProfesseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfesseur.FormattingEnabled = true;
            this.comboProfesseur.Location = new System.Drawing.Point(126, 129);
            this.comboProfesseur.Name = "comboProfesseur";
            this.comboProfesseur.Size = new System.Drawing.Size(121, 21);
            this.comboProfesseur.TabIndex = 9;
            // 
            // FicheClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 275);
            this.Controls.Add(this.comboProfesseur);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.lb_prof_principal);
            this.Controls.Add(this.lb_Niveau);
            this.Controls.Add(this.lb_id_Classe);
            this.Controls.Add(this.text_Niveau);
            this.Controls.Add(this.text_Id_classe);
            this.Name = "FicheClasse";
            this.Text = "FicheClasse";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProfesseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Id_classe;
        private System.Windows.Forms.TextBox text_Niveau;
        private System.Windows.Forms.Label lb_id_Classe;
        private System.Windows.Forms.Label lb_Niveau;
        private System.Windows.Forms.Label lb_prof_principal;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingSource bsProfesseur;
        private System.Windows.Forms.ComboBox comboProfesseur;
    }
}