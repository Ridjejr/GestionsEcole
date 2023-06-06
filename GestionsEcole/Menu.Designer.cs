namespace GestionsEcole
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matièreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enseignantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.basesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // basesToolStripMenuItem
            // 
            this.basesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elèvesToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.professeursToolStripMenuItem,
            this.matièreToolStripMenuItem,
            this.enseignantToolStripMenuItem});
            this.basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            this.basesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.basesToolStripMenuItem.Text = "Bases";
            // 
            // elèvesToolStripMenuItem
            // 
            this.elèvesToolStripMenuItem.Name = "elèvesToolStripMenuItem";
            this.elèvesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elèvesToolStripMenuItem.Text = "Elèves";
            this.elèvesToolStripMenuItem.Click += new System.EventHandler(this.elèvesToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // professeursToolStripMenuItem
            // 
            this.professeursToolStripMenuItem.Name = "professeursToolStripMenuItem";
            this.professeursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professeursToolStripMenuItem.Text = "Professeurs";
            this.professeursToolStripMenuItem.Click += new System.EventHandler(this.professeursToolStripMenuItem_Click);
            // 
            // matièreToolStripMenuItem
            // 
            this.matièreToolStripMenuItem.Name = "matièreToolStripMenuItem";
            this.matièreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matièreToolStripMenuItem.Text = "Matière";
            this.matièreToolStripMenuItem.Click += new System.EventHandler(this.matièreToolStripMenuItem_Click);
            // 
            // enseignantToolStripMenuItem
            // 
            this.enseignantToolStripMenuItem.Name = "enseignantToolStripMenuItem";
            this.enseignantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enseignantToolStripMenuItem.Text = "Enseignant";
            this.enseignantToolStripMenuItem.Click += new System.EventHandler(this.enseignantToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matièreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enseignantToolStripMenuItem;
    }
}