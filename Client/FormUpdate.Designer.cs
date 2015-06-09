namespace Client
{
    partial class FormUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdate));
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.textBoxNewAddr = new System.Windows.Forms.TextBox();
            this.textBoxNewDep = new System.Windows.Forms.TextBox();
            this.labelNameNew = new System.Windows.Forms.Label();
            this.labelAdrNew = new System.Windows.Forms.Label();
            this.labelDepNew = new System.Windows.Forms.Label();
            this.labelNew = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddCl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewName
            // 
            resources.ApplyResources(this.textBoxNewName, "textBoxNewName");
            this.textBoxNewName.Name = "textBoxNewName";
            // 
            // textBoxNewAddr
            // 
            resources.ApplyResources(this.textBoxNewAddr, "textBoxNewAddr");
            this.textBoxNewAddr.Name = "textBoxNewAddr";
            // 
            // textBoxNewDep
            // 
            resources.ApplyResources(this.textBoxNewDep, "textBoxNewDep");
            this.textBoxNewDep.Name = "textBoxNewDep";
            // 
            // labelNameNew
            // 
            resources.ApplyResources(this.labelNameNew, "labelNameNew");
            this.labelNameNew.BackColor = System.Drawing.Color.Transparent;
            this.labelNameNew.Name = "labelNameNew";
            // 
            // labelAdrNew
            // 
            resources.ApplyResources(this.labelAdrNew, "labelAdrNew");
            this.labelAdrNew.BackColor = System.Drawing.Color.Transparent;
            this.labelAdrNew.Name = "labelAdrNew";
            // 
            // labelDepNew
            // 
            resources.ApplyResources(this.labelDepNew, "labelDepNew");
            this.labelDepNew.BackColor = System.Drawing.Color.Transparent;
            this.labelDepNew.Name = "labelDepNew";
            // 
            // labelNew
            // 
            resources.ApplyResources(this.labelNew, "labelNew");
            this.labelNew.BackColor = System.Drawing.Color.Transparent;
            this.labelNew.ForeColor = System.Drawing.Color.Red;
            this.labelNew.Name = "labelNew";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddCl
            // 
            this.buttonAddCl.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.buttonAddCl, "buttonAddCl");
            this.buttonAddCl.Name = "buttonAddCl";
            this.buttonAddCl.UseVisualStyleBackColor = false;
            this.buttonAddCl.Click += new System.EventHandler(this.buttonAddCl_Click);
            // 
            // FormUpdate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.buttonAddCl);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelNew);
            this.Controls.Add(this.labelDepNew);
            this.Controls.Add(this.labelAdrNew);
            this.Controls.Add(this.labelNameNew);
            this.Controls.Add(this.textBoxNewDep);
            this.Controls.Add(this.textBoxNewAddr);
            this.Controls.Add(this.textBoxNewName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.TextBox textBoxNewAddr;
        private System.Windows.Forms.TextBox textBoxNewDep;
        private System.Windows.Forms.Label labelNameNew;
        private System.Windows.Forms.Label labelAdrNew;
        private System.Windows.Forms.Label labelDepNew;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddCl;
    }
}