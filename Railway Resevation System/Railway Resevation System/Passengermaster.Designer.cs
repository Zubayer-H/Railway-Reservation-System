
namespace Railway_Resevation_System
{
    partial class Passengermaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passengermaster));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PMadd = new System.Windows.Forms.Button();
            this.PMedit = new System.Windows.Forms.Button();
            this.TMremove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.passname = new System.Windows.Forms.TextBox();
            this.passaddress = new System.Windows.Forms.TextBox();
            this.Passphone = new System.Windows.Forms.TextBox();
            this.Passgender = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PassShow = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passenger Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passenger Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Passenger Phone";
            // 
            // PMadd
            // 
            this.PMadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PMadd.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMadd.ForeColor = System.Drawing.Color.White;
            this.PMadd.Location = new System.Drawing.Point(468, 74);
            this.PMadd.Name = "PMadd";
            this.PMadd.Size = new System.Drawing.Size(80, 30);
            this.PMadd.TabIndex = 6;
            this.PMadd.Text = "Add";
            this.PMadd.UseVisualStyleBackColor = true;
            this.PMadd.Click += new System.EventHandler(this.PMadd_Click);
            // 
            // PMedit
            // 
            this.PMedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PMedit.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMedit.ForeColor = System.Drawing.Color.White;
            this.PMedit.Location = new System.Drawing.Point(468, 152);
            this.PMedit.Name = "PMedit";
            this.PMedit.Size = new System.Drawing.Size(80, 30);
            this.PMedit.TabIndex = 8;
            this.PMedit.Text = "Update";
            this.PMedit.UseVisualStyleBackColor = true;
            this.PMedit.Click += new System.EventHandler(this.btnedit);
            // 
            // TMremove
            // 
            this.TMremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMremove.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMremove.ForeColor = System.Drawing.Color.White;
            this.TMremove.Location = new System.Drawing.Point(554, 74);
            this.TMremove.Name = "TMremove";
            this.TMremove.Size = new System.Drawing.Size(80, 30);
            this.TMremove.TabIndex = 9;
            this.TMremove.Text = "Remove";
            this.TMremove.UseVisualStyleBackColor = true;
            this.TMremove.Click += new System.EventHandler(this.TMremove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(271, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Passenger List";
            // 
            // passname
            // 
            this.passname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passname.Location = new System.Drawing.Point(158, 75);
            this.passname.Name = "passname";
            this.passname.Size = new System.Drawing.Size(141, 29);
            this.passname.TabIndex = 12;
            // 
            // passaddress
            // 
            this.passaddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passaddress.Location = new System.Drawing.Point(158, 117);
            this.passaddress.Multiline = true;
            this.passaddress.Name = "passaddress";
            this.passaddress.Size = new System.Drawing.Size(141, 33);
            this.passaddress.TabIndex = 13;
            // 
            // Passphone
            // 
            this.Passphone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passphone.Location = new System.Drawing.Point(158, 166);
            this.Passphone.Name = "Passphone";
            this.Passphone.Size = new System.Drawing.Size(141, 29);
            this.Passphone.TabIndex = 14;
            // 
            // Passgender
            // 
            this.Passgender.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passgender.FormattingEnabled = true;
            this.Passgender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.Passgender.Location = new System.Drawing.Point(158, 209);
            this.Passgender.Name = "Passgender";
            this.Passgender.Size = new System.Drawing.Size(141, 29);
            this.Passgender.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 165);
            this.dataGridView1.TabIndex = 16;
            // 
            // PassShow
            // 
            this.PassShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassShow.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassShow.ForeColor = System.Drawing.Color.White;
            this.PassShow.Location = new System.Drawing.Point(554, 152);
            this.PassShow.Name = "PassShow";
            this.PassShow.Size = new System.Drawing.Size(80, 30);
            this.PassShow.TabIndex = 11;
            this.PassShow.Text = "Show";
            this.PassShow.UseVisualStyleBackColor = true;
            this.PassShow.Click += new System.EventHandler(this.PassShow_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(468, 111);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 30);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 25);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(554, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Passengermaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(665, 439);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.PassShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Passgender);
            this.Controls.Add(this.Passphone);
            this.Controls.Add(this.passaddress);
            this.Controls.Add(this.passname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TMremove);
            this.Controls.Add(this.PMedit);
            this.Controls.Add(this.PMadd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Passengermaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passengermaster";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PMadd;
        private System.Windows.Forms.Button PMedit;
        private System.Windows.Forms.Button TMremove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passname;
        private System.Windows.Forms.TextBox passaddress;
        private System.Windows.Forms.TextBox Passphone;
        private System.Windows.Forms.ComboBox Passgender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PassShow;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}