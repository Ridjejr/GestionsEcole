namespace GestionsEcole
{
    partial class Form_listeEnseigner
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.laMatiereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leProfesseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laMatiereDataGridViewTextBoxColumn,
            this.leProfesseurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bs;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(395, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(GestionsEcole.Enseigner);
            // 
            // laMatiereDataGridViewTextBoxColumn
            // 
            this.laMatiereDataGridViewTextBoxColumn.DataPropertyName = "LaMatiere";
            this.laMatiereDataGridViewTextBoxColumn.HeaderText = "Matiere";
            this.laMatiereDataGridViewTextBoxColumn.Name = "laMatiereDataGridViewTextBoxColumn";
            this.laMatiereDataGridViewTextBoxColumn.ReadOnly = true;
            this.laMatiereDataGridViewTextBoxColumn.Width = 200;
            // 
            // leProfesseurDataGridViewTextBoxColumn
            // 
            this.leProfesseurDataGridViewTextBoxColumn.DataPropertyName = "LeProfesseur";
            this.leProfesseurDataGridViewTextBoxColumn.HeaderText = "Professeur";
            this.leProfesseurDataGridViewTextBoxColumn.Name = "leProfesseurDataGridViewTextBoxColumn";
            this.leProfesseurDataGridViewTextBoxColumn.ReadOnly = true;
            this.leProfesseurDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form_listeEnseigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 407);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_listeEnseigner";
            this.Text = "Form_listeEnseigner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn laMatiereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leProfesseurDataGridViewTextBoxColumn;
    }
}