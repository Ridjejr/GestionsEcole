namespace GestionsEcole
{
    partial class Form_FicheNote
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
            this.comboEleve = new System.Windows.Forms.ComboBox();
            this.comboMatiere = new System.Windows.Forms.ComboBox();
            this.lb_matiere = new System.Windows.Forms.Label();
            this.lb_eleve = new System.Windows.Forms.Label();
            this.text_Valeur = new System.Windows.Forms.TextBox();
            this.text_id_note = new System.Windows.Forms.TextBox();
            this.lb_Valeur = new System.Windows.Forms.Label();
            this.lb_id_note = new System.Windows.Forms.Label();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.bsEleve = new System.Windows.Forms.BindingSource(this.components);
            this.bsMatiere = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // comboEleve
            // 
            this.comboEleve.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bs, "LEleve", true));
            this.comboEleve.DataSource = this.bsEleve;
            this.comboEleve.FormattingEnabled = true;
            this.comboEleve.Location = new System.Drawing.Point(172, 172);
            this.comboEleve.Name = "comboEleve";
            this.comboEleve.Size = new System.Drawing.Size(121, 21);
            this.comboEleve.TabIndex = 0;
            // 
            // comboMatiere
            // 
            this.comboMatiere.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bs, "LaMatiere", true));
            this.comboMatiere.DataSource = this.bsMatiere;
            this.comboMatiere.FormattingEnabled = true;
            this.comboMatiere.Location = new System.Drawing.Point(172, 228);
            this.comboMatiere.Name = "comboMatiere";
            this.comboMatiere.Size = new System.Drawing.Size(121, 21);
            this.comboMatiere.TabIndex = 1;
            // 
            // lb_matiere
            // 
            this.lb_matiere.AutoSize = true;
            this.lb_matiere.Location = new System.Drawing.Point(68, 231);
            this.lb_matiere.Name = "lb_matiere";
            this.lb_matiere.Size = new System.Drawing.Size(42, 13);
            this.lb_matiere.TabIndex = 2;
            this.lb_matiere.Text = "Matière";
            // 
            // lb_eleve
            // 
            this.lb_eleve.AutoSize = true;
            this.lb_eleve.Location = new System.Drawing.Point(68, 175);
            this.lb_eleve.Name = "lb_eleve";
            this.lb_eleve.Size = new System.Drawing.Size(34, 13);
            this.lb_eleve.TabIndex = 3;
            this.lb_eleve.Text = "Elève";
            // 
            // text_Valeur
            // 
            this.text_Valeur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Valeur", true));
            this.text_Valeur.Location = new System.Drawing.Point(172, 112);
            this.text_Valeur.Name = "text_Valeur";
            this.text_Valeur.Size = new System.Drawing.Size(121, 20);
            this.text_Valeur.TabIndex = 4;
            // 
            // text_id_note
            // 
            this.text_id_note.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Id_note", true));
            this.text_id_note.Location = new System.Drawing.Point(172, 53);
            this.text_id_note.Name = "text_id_note";
            this.text_id_note.Size = new System.Drawing.Size(121, 20);
            this.text_id_note.TabIndex = 5;
            // 
            // lb_Valeur
            // 
            this.lb_Valeur.AutoSize = true;
            this.lb_Valeur.Location = new System.Drawing.Point(68, 115);
            this.lb_Valeur.Name = "lb_Valeur";
            this.lb_Valeur.Size = new System.Drawing.Size(78, 13);
            this.lb_Valeur.TabIndex = 6;
            this.lb_Valeur.Text = "Note de l\'élève";
            // 
            // lb_id_note
            // 
            this.lb_id_note.AutoSize = true;
            this.lb_id_note.Location = new System.Drawing.Point(68, 56);
            this.lb_id_note.Name = "lb_id_note";
            this.lb_id_note.Size = new System.Drawing.Size(53, 13);
            this.lb_id_note.TabIndex = 7;
            this.lb_id_note.Text = "Identifiant";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(54, 307);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(96, 23);
            this.btn_Annuler.TabIndex = 8;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(243, 307);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(96, 23);
            this.btn_Valider.TabIndex = 9;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // bs
            // 
            this.bs.DataSource = typeof(GestionsEcole.Note);
            // 
            // bsEleve
            // 
            this.bsEleve.DataSource = typeof(GestionsEcole.Eleve);
            // 
            // bsMatiere
            // 
            this.bsMatiere.DataSource = typeof(GestionsEcole.Matiere);
            // 
            // Form_FicheNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 385);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.lb_id_note);
            this.Controls.Add(this.lb_Valeur);
            this.Controls.Add(this.text_id_note);
            this.Controls.Add(this.text_Valeur);
            this.Controls.Add(this.lb_eleve);
            this.Controls.Add(this.lb_matiere);
            this.Controls.Add(this.comboMatiere);
            this.Controls.Add(this.comboEleve);
            this.Name = "Form_FicheNote";
            this.Text = "Form_FicheNote";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEleve;
        private System.Windows.Forms.ComboBox comboMatiere;
        private System.Windows.Forms.Label lb_matiere;
        private System.Windows.Forms.Label lb_eleve;
        private System.Windows.Forms.TextBox text_Valeur;
        private System.Windows.Forms.TextBox text_id_note;
        private System.Windows.Forms.Label lb_Valeur;
        private System.Windows.Forms.Label lb_id_note;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingSource bsEleve;
        private System.Windows.Forms.BindingSource bsMatiere;
    }
}