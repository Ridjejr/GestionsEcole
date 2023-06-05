namespace GestionsEcole
{
    partial class Form_FicheProfesseur
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
            this.text_Id_prof = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.text_Nom = new System.Windows.Forms.TextBox();
            this.text_Prenom = new System.Windows.Forms.TextBox();
            this.text_Sexe = new System.Windows.Forms.TextBox();
            this.lb_id_prof = new System.Windows.Forms.Label();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.lb_Prenom = new System.Windows.Forms.Label();
            this.lb_Sexe = new System.Windows.Forms.Label();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Id_prof
            // 
            this.text_Id_prof.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Id_prof", true));
            this.text_Id_prof.Enabled = false;
            this.text_Id_prof.Location = new System.Drawing.Point(149, 49);
            this.text_Id_prof.Name = "text_Id_prof";
            this.text_Id_prof.Size = new System.Drawing.Size(100, 20);
            this.text_Id_prof.TabIndex = 0;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(GestionsEcole.Professeur);
            // 
            // text_Nom
            // 
            this.text_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nom", true));
            this.text_Nom.Location = new System.Drawing.Point(149, 98);
            this.text_Nom.Name = "text_Nom";
            this.text_Nom.Size = new System.Drawing.Size(100, 20);
            this.text_Nom.TabIndex = 1;
            // 
            // text_Prenom
            // 
            this.text_Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.text_Prenom.Location = new System.Drawing.Point(149, 144);
            this.text_Prenom.Name = "text_Prenom";
            this.text_Prenom.Size = new System.Drawing.Size(100, 20);
            this.text_Prenom.TabIndex = 2;
            // 
            // text_Sexe
            // 
            this.text_Sexe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Sexe", true));
            this.text_Sexe.Location = new System.Drawing.Point(149, 194);
            this.text_Sexe.Name = "text_Sexe";
            this.text_Sexe.Size = new System.Drawing.Size(100, 20);
            this.text_Sexe.TabIndex = 3;
            // 
            // lb_id_prof
            // 
            this.lb_id_prof.AutoSize = true;
            this.lb_id_prof.Location = new System.Drawing.Point(41, 52);
            this.lb_id_prof.Name = "lb_id_prof";
            this.lb_id_prof.Size = new System.Drawing.Size(53, 13);
            this.lb_id_prof.TabIndex = 5;
            this.lb_id_prof.Text = "Identifiant";
            // 
            // lb_Nom
            // 
            this.lb_Nom.AutoSize = true;
            this.lb_Nom.Location = new System.Drawing.Point(41, 101);
            this.lb_Nom.Name = "lb_Nom";
            this.lb_Nom.Size = new System.Drawing.Size(29, 13);
            this.lb_Nom.TabIndex = 6;
            this.lb_Nom.Text = "Nom";
            // 
            // lb_Prenom
            // 
            this.lb_Prenom.AutoSize = true;
            this.lb_Prenom.Location = new System.Drawing.Point(41, 147);
            this.lb_Prenom.Name = "lb_Prenom";
            this.lb_Prenom.Size = new System.Drawing.Size(43, 13);
            this.lb_Prenom.TabIndex = 7;
            this.lb_Prenom.Text = "Prenom";
            // 
            // lb_Sexe
            // 
            this.lb_Sexe.AutoSize = true;
            this.lb_Sexe.Location = new System.Drawing.Point(41, 197);
            this.lb_Sexe.Name = "lb_Sexe";
            this.lb_Sexe.Size = new System.Drawing.Size(31, 13);
            this.lb_Sexe.TabIndex = 8;
            this.lb_Sexe.Text = "Sexe";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(57, 258);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(100, 24);
            this.btn_Annuler.TabIndex = 9;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(203, 258);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(100, 24);
            this.btn_Valider.TabIndex = 10;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // Form_FicheProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 306);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.lb_Sexe);
            this.Controls.Add(this.lb_Prenom);
            this.Controls.Add(this.lb_Nom);
            this.Controls.Add(this.lb_id_prof);
            this.Controls.Add(this.text_Sexe);
            this.Controls.Add(this.text_Prenom);
            this.Controls.Add(this.text_Nom);
            this.Controls.Add(this.text_Id_prof);
            this.Name = "Form_FicheProfesseur";
            this.Text = "Form_FicheProfesseur";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Id_prof;
        private System.Windows.Forms.TextBox text_Nom;
        private System.Windows.Forms.TextBox text_Prenom;
        private System.Windows.Forms.TextBox text_Sexe;
        private System.Windows.Forms.Label lb_id_prof;
        private System.Windows.Forms.Label lb_Nom;
        private System.Windows.Forms.Label lb_Prenom;
        private System.Windows.Forms.Label lb_Sexe;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.BindingSource bs;
    }
}