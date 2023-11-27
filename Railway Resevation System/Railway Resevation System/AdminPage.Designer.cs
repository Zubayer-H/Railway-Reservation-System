
namespace Railway_Resevation_System
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.managerid = new System.Windows.Forms.Label();
            this.MaName = new System.Windows.Forms.TextBox();
            this.MaAddress = new System.Windows.Forms.TextBox();
            this.MaContact = new System.Windows.Forms.TextBox();
            this.Mid = new System.Windows.Forms.TextBox();
            this.MaUsername = new System.Windows.Forms.TextBox();
            this.MaPassword = new System.Windows.Forms.TextBox();
            this.ManagerInsert = new System.Windows.Forms.Button();
            this.ManagerUpdate = new System.Windows.Forms.Button();
            this.ManagerReset = new System.Windows.Forms.Button();
            this.ManagerDelete = new System.Windows.Forms.Button();
            this.showall = new System.Windows.Forms.Button();
            this.ManagerSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // managerid
            // 
            this.managerid.AutoSize = true;
            this.managerid.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerid.ForeColor = System.Drawing.Color.White;
            this.managerid.Location = new System.Drawing.Point(56, 90);
            this.managerid.Name = "managerid";
            this.managerid.Size = new System.Drawing.Size(89, 20);
            this.managerid.TabIndex = 7;
            this.managerid.Text = "Manager Id";
            // 
            // MaName
            // 
            this.MaName.Location = new System.Drawing.Point(161, 122);
            this.MaName.Name = "MaName";
            this.MaName.Size = new System.Drawing.Size(118, 20);
            this.MaName.TabIndex = 12;
            // 
            // MaAddress
            // 
            this.MaAddress.Location = new System.Drawing.Point(161, 152);
            this.MaAddress.Name = "MaAddress";
            this.MaAddress.Size = new System.Drawing.Size(118, 20);
            this.MaAddress.TabIndex = 13;
            // 
            // MaContact
            // 
            this.MaContact.Location = new System.Drawing.Point(161, 188);
            this.MaContact.Name = "MaContact";
            this.MaContact.Size = new System.Drawing.Size(118, 20);
            this.MaContact.TabIndex = 14;
            // 
            // Mid
            // 
            this.Mid.Location = new System.Drawing.Point(161, 90);
            this.Mid.Name = "Mid";
            this.Mid.Size = new System.Drawing.Size(118, 20);
            this.Mid.TabIndex = 11;
            // 
            // MaUsername
            // 
            this.MaUsername.Location = new System.Drawing.Point(161, 224);
            this.MaUsername.Name = "MaUsername";
            this.MaUsername.Size = new System.Drawing.Size(118, 20);
            this.MaUsername.TabIndex = 15;
            // 
            // MaPassword
            // 
            this.MaPassword.Location = new System.Drawing.Point(161, 263);
            this.MaPassword.Name = "MaPassword";
            this.MaPassword.Size = new System.Drawing.Size(118, 20);
            this.MaPassword.TabIndex = 16;
            // 
            // ManagerInsert
            // 
            this.ManagerInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerInsert.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerInsert.ForeColor = System.Drawing.Color.White;
            this.ManagerInsert.Location = new System.Drawing.Point(21, 305);
            this.ManagerInsert.Name = "ManagerInsert";
            this.ManagerInsert.Size = new System.Drawing.Size(77, 31);
            this.ManagerInsert.TabIndex = 17;
            this.ManagerInsert.Text = "Insert";
            this.ManagerInsert.UseVisualStyleBackColor = true;
            this.ManagerInsert.Click += new System.EventHandler(this.ManagerInsert_Click);
            // 
            // ManagerUpdate
            // 
            this.ManagerUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerUpdate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerUpdate.ForeColor = System.Drawing.Color.White;
            this.ManagerUpdate.Location = new System.Drawing.Point(115, 305);
            this.ManagerUpdate.Name = "ManagerUpdate";
            this.ManagerUpdate.Size = new System.Drawing.Size(87, 31);
            this.ManagerUpdate.TabIndex = 18;
            this.ManagerUpdate.Text = "Update";
            this.ManagerUpdate.UseVisualStyleBackColor = true;
            this.ManagerUpdate.Click += new System.EventHandler(this.ManagerUpdate_Click);
            // 
            // ManagerReset
            // 
            this.ManagerReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerReset.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerReset.ForeColor = System.Drawing.Color.White;
            this.ManagerReset.Location = new System.Drawing.Point(219, 305);
            this.ManagerReset.Name = "ManagerReset";
            this.ManagerReset.Size = new System.Drawing.Size(69, 31);
            this.ManagerReset.TabIndex = 19;
            this.ManagerReset.Text = "Reset";
            this.ManagerReset.UseVisualStyleBackColor = true;
            this.ManagerReset.Click += new System.EventHandler(this.ManagerReset_Click);
            // 
            // ManagerDelete
            // 
            this.ManagerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerDelete.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerDelete.ForeColor = System.Drawing.Color.White;
            this.ManagerDelete.Location = new System.Drawing.Point(396, 305);
            this.ManagerDelete.Name = "ManagerDelete";
            this.ManagerDelete.Size = new System.Drawing.Size(73, 31);
            this.ManagerDelete.TabIndex = 21;
            this.ManagerDelete.Text = "Delete";
            this.ManagerDelete.UseVisualStyleBackColor = true;
            this.ManagerDelete.Click += new System.EventHandler(this.ManagerDelete_Click);
            // 
            // showall
            // 
            this.showall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showall.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showall.ForeColor = System.Drawing.Color.White;
            this.showall.Location = new System.Drawing.Point(486, 305);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(109, 31);
            this.showall.TabIndex = 22;
            this.showall.Text = "Show All";
            this.showall.UseVisualStyleBackColor = true;
            this.showall.Click += new System.EventHandler(this.showall_Click);
            // 
            // ManagerSearch
            // 
            this.ManagerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerSearch.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerSearch.ForeColor = System.Drawing.Color.White;
            this.ManagerSearch.Location = new System.Drawing.Point(304, 305);
            this.ManagerSearch.Name = "ManagerSearch";
            this.ManagerSearch.Size = new System.Drawing.Size(77, 31);
            this.ManagerSearch.TabIndex = 20;
            this.ManagerSearch.Text = "Search";
            this.ManagerSearch.UseVisualStyleBackColor = true;
            this.ManagerSearch.Click += new System.EventHandler(this.ManagerSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(387, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 193);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 30);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(214, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "Manager Information";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(644, 548);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ManagerSearch);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.ManagerDelete);
            this.Controls.Add(this.ManagerReset);
            this.Controls.Add(this.ManagerUpdate);
            this.Controls.Add(this.ManagerInsert);
            this.Controls.Add(this.MaPassword);
            this.Controls.Add(this.MaUsername);
            this.Controls.Add(this.Mid);
            this.Controls.Add(this.MaContact);
            this.Controls.Add(this.MaAddress);
            this.Controls.Add(this.MaName);
            this.Controls.Add(this.managerid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label managerid;
        private System.Windows.Forms.TextBox MaName;
        private System.Windows.Forms.TextBox MaAddress;
        private System.Windows.Forms.TextBox MaContact;
        private System.Windows.Forms.TextBox Mid;
        private System.Windows.Forms.TextBox MaUsername;
        private System.Windows.Forms.TextBox MaPassword;
        private System.Windows.Forms.Button ManagerInsert;
        private System.Windows.Forms.Button ManagerUpdate;
        private System.Windows.Forms.Button ManagerReset;
        private System.Windows.Forms.Button ManagerDelete;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Button ManagerSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}