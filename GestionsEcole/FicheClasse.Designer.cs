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
            this.text_Id_prof = new System.Windows.Forms.TextBox();
            this.text_Niveau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Niveau = new System.Windows.Forms.Label();
            this.lb_prof_principal = new System.Windows.Forms.Label();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Id_classe
            // 
            this.text_Id_classe.Location = new System.Drawing.Point(126, 38);
            this.text_Id_classe.Name = "text_Id_classe";
            this.text_Id_classe.Size = new System.Drawing.Size(94, 20);
            this.text_Id_classe.TabIndex = 0;
            // 
            // text_Id_prof
            // 
            this.text_Id_prof.Location = new System.Drawing.Point(126, 126);
            this.text_Id_prof.Name = "text_Id_prof";
            this.text_Id_prof.Size = new System.Drawing.Size(94, 20);
            this.text_Id_prof.TabIndex = 1;
            // 
            // text_Niveau
            // 
            this.text_Niveau.Location = new System.Drawing.Point(126, 84);
            this.text_Niveau.Name = "text_Niveau";
            this.text_Niveau.Size = new System.Drawing.Size(94, 20);
            this.text_Niveau.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identifiant";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // bs
            // 
            this.bs.DataSource = typeof(GestionsEcole.Classe);
            // 
            // FicheClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 275);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.lb_prof_principal);
            this.Controls.Add(this.lb_Niveau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Niveau);
            this.Controls.Add(this.text_Id_prof);
            this.Controls.Add(this.text_Id_classe);
            this.Name = "FicheClasse";
            this.Text = "FicheClasse";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Id_classe;
        private System.Windows.Forms.TextBox text_Id_prof;
        private System.Windows.Forms.TextBox text_Niveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Niveau;
        private System.Windows.Forms.Label lb_prof_principal;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bs;
    }
}