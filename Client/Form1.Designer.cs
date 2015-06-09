namespace Client
{
    partial class ClientClass
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientClass));
            this.ButtonTitle = new System.Windows.Forms.Button();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonTitle
            // 
            this.ButtonTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonTitle.BackgroundImage")));
            this.ButtonTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonTitle.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonTitle.Location = new System.Drawing.Point(254, 392);
            this.ButtonTitle.Name = "ButtonTitle";
            this.ButtonTitle.Size = new System.Drawing.Size(167, 31);
            this.ButtonTitle.TabIndex = 13;
            this.ButtonTitle.Text = "Refresh Title";
            this.ButtonTitle.UseVisualStyleBackColor = false;
            this.ButtonTitle.Click += new System.EventHandler(this.Title_Click);
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonAddClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddClient.BackgroundImage")));
            this.ButtonAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAddClient.FlatAppearance.BorderSize = 0;
            this.ButtonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddClient.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddClient.Location = new System.Drawing.Point(563, 12);
            this.ButtonAddClient.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(135, 31);
            this.ButtonAddClient.TabIndex = 6;
            this.ButtonAddClient.Text = " Add  new client";
            this.ButtonAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAddClient.UseVisualStyleBackColor = false;
            this.ButtonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(62, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 211);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(289, 113);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(271, 21);
            this.textBoxSearch.TabIndex = 19;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(135)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.ImageKey = "(none)";
            this.buttonSearch.Location = new System.Drawing.Point(563, 110);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 31);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Search!";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearh
            // 
            this.labelSearh.AutoSize = true;
            this.labelSearh.BackColor = System.Drawing.Color.Transparent;
            this.labelSearh.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearh.ForeColor = System.Drawing.Color.Red;
            this.labelSearh.Location = new System.Drawing.Point(30, 115);
            this.labelSearh.Name = "labelSearh";
            this.labelSearh.Size = new System.Drawing.Size(253, 19);
            this.labelSearh.TabIndex = 22;
            this.labelSearh.Text = "Please, input in searching client name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 91);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ClientClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSearh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonAddClient);
            this.Controls.Add(this.ButtonTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClientClass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonTitle;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearh;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.DataGridView dataGridView1;



    }
}

