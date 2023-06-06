namespace GestionsEcole
{
    partial class Form_ListeMatieres
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
            this.dgv_ListeMatieres = new System.Windows.Forms.DataGridView();
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.id_matiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeMatieres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListeMatieres
            // 
            this.dgv_ListeMatieres.AllowUserToAddRows = false;
            this.dgv_ListeMatieres.AllowUserToDeleteRows = false;
            this.dgv_ListeMatieres.AutoGenerateColumns = false;
            this.dgv_ListeMatieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeMatieres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_matiere,
            this.Matiere});
            this.dgv_ListeMatieres.DataSource = this.bs;
            this.dgv_ListeMatieres.Location = new System.Drawing.Point(12, 12);
            this.dgv_ListeMatieres.Name = "dgv_ListeMatieres";
            this.dgv_ListeMatieres.ReadOnly = true;
            this.dgv_ListeMatieres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeMatieres.Size = new System.Drawing.Size(294, 249);
            this.dgv_ListeMatieres.TabIndex = 0;
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Location = new System.Drawing.Point(336, 45);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(99, 27);
            this.btn_Afficher.TabIndex = 1;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(336, 98);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(99, 27);
            this.btn_Modifier.TabIndex = 2;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(336, 148);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(99, 27);
            this.btn_Supprimer.TabIndex = 3;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Suppression_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(336, 195);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(99, 27);
            this.btn_Nouveau.TabIndex = 4;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // id_matiere
            // 
            this.id_matiere.DataPropertyName = "id_matiere";
            this.id_matiere.HeaderText = "Identifiant";
            this.id_matiere.Name = "id_matiere";
            this.id_matiere.ReadOnly = true;
            // 
            // Matiere
            // 
            this.Matiere.DataPropertyName = "Nom";
            this.Matiere.HeaderText = "Matière";
            this.Matiere.Name = "Matiere";
            this.Matiere.ReadOnly = true;
            this.Matiere.Width = 150;
            // 
            // Form_ListeMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 272);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_ListeMatieres);
            this.Name = "Form_ListeMatieres";
            this.Text = "Form_ListeMatieres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeMatieres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListeMatieres;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_matiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matiere;
    }
}