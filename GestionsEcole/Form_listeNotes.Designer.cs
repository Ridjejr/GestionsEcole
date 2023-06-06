namespace GestionsEcole
{
    partial class Form_listeNotes
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
            this.dgv_listeNotes = new System.Windows.Forms.DataGridView();
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.id_valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaMatiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listeNotes
            // 
            this.dgv_listeNotes.AllowUserToAddRows = false;
            this.dgv_listeNotes.AllowUserToDeleteRows = false;
            this.dgv_listeNotes.AutoGenerateColumns = false;
            this.dgv_listeNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_valeur,
            this.valeur,
            this.LEleve,
            this.LaMatiere});
            this.dgv_listeNotes.DataSource = this.bs;
            this.dgv_listeNotes.Location = new System.Drawing.Point(12, 12);
            this.dgv_listeNotes.Name = "dgv_listeNotes";
            this.dgv_listeNotes.ReadOnly = true;
            this.dgv_listeNotes.Size = new System.Drawing.Size(554, 426);
            this.dgv_listeNotes.TabIndex = 0;
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Location = new System.Drawing.Point(592, 51);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(110, 26);
            this.btn_Afficher.TabIndex = 1;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(592, 107);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(110, 26);
            this.btn_Modifier.TabIndex = 2;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(592, 164);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(110, 26);
            this.btn_Supprimer.TabIndex = 3;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(592, 220);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(110, 26);
            this.btn_Nouveau.TabIndex = 4;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // id_valeur
            // 
            this.id_valeur.DataPropertyName = "id_valeur";
            this.id_valeur.HeaderText = "Identifiant";
            this.id_valeur.Name = "id_valeur";
            this.id_valeur.ReadOnly = true;
            // 
            // valeur
            // 
            this.valeur.DataPropertyName = "valeur";
            this.valeur.HeaderText = "Valeur";
            this.valeur.Name = "valeur";
            this.valeur.ReadOnly = true;
            // 
            // LEleve
            // 
            this.LEleve.DataPropertyName = "lEleve";
            this.LEleve.HeaderText = "Eleve";
            this.LEleve.Name = "LEleve";
            this.LEleve.ReadOnly = true;
            this.LEleve.Width = 160;
            // 
            // LaMatiere
            // 
            this.LaMatiere.DataPropertyName = "laMatiere";
            this.LaMatiere.HeaderText = "Matiere";
            this.LaMatiere.Name = "LaMatiere";
            this.LaMatiere.ReadOnly = true;
            this.LaMatiere.Width = 150;
            // 
            // Form_listeNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_listeNotes);
            this.Name = "Form_listeNotes";
            this.Text = "Form_listeNotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listeNotes;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_valeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn valeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaMatiere;
    }
}