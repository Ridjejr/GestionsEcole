namespace GestionsEcole
{
    partial class Form_FicheMatiere
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
            this.text_Id_matiere = new System.Windows.Forms.TextBox();
            this.text_Nom = new System.Windows.Forms.TextBox();
            this.lb_Matiere = new System.Windows.Forms.Label();
            this.lb_id_matiere = new System.Windows.Forms.Label();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Id_matiere
            // 
            this.text_Id_matiere.Enabled = false;
            this.text_Id_matiere.Location = new System.Drawing.Point(157, 47);
            this.text_Id_matiere.Name = "text_Id_matiere";
            this.text_Id_matiere.Size = new System.Drawing.Size(111, 20);
            this.text_Id_matiere.TabIndex = 0;
            // 
            // text_Nom
            // 
            this.text_Nom.Location = new System.Drawing.Point(157, 106);
            this.text_Nom.Name = "text_Nom";
            this.text_Nom.Size = new System.Drawing.Size(111, 20);
            this.text_Nom.TabIndex = 1;
            // 
            // lb_Matiere
            // 
            this.lb_Matiere.AutoSize = true;
            this.lb_Matiere.Location = new System.Drawing.Point(77, 109);
            this.lb_Matiere.Name = "lb_Matiere";
            this.lb_Matiere.Size = new System.Drawing.Size(42, 13);
            this.lb_Matiere.TabIndex = 2;
            this.lb_Matiere.Text = "Matière";
            // 
            // lb_id_matiere
            // 
            this.lb_id_matiere.AutoSize = true;
            this.lb_id_matiere.Location = new System.Drawing.Point(66, 50);
            this.lb_id_matiere.Name = "lb_id_matiere";
            this.lb_id_matiere.Size = new System.Drawing.Size(53, 13);
            this.lb_id_matiere.TabIndex = 3;
            this.lb_id_matiere.Text = "Identifiant";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(56, 198);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(101, 28);
            this.btn_Annuler.TabIndex = 4;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(242, 198);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(101, 28);
            this.btn_Valider.TabIndex = 5;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // Form_FicheMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 257);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.lb_id_matiere);
            this.Controls.Add(this.lb_Matiere);
            this.Controls.Add(this.text_Nom);
            this.Controls.Add(this.text_Id_matiere);
            this.Name = "Form_FicheMatiere";
            this.Text = "Form_FicheMatiere";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Id_matiere;
        private System.Windows.Forms.TextBox text_Nom;
        private System.Windows.Forms.Label lb_Matiere;
        private System.Windows.Forms.Label lb_id_matiere;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.BindingSource bs;
    }
}