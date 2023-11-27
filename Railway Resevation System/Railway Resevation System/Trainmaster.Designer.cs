
namespace Railway_Resevation_System
{
    partial class TrainMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainMaster));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TMadd = new System.Windows.Forms.Button();
            this.TMedit = new System.Windows.Forms.Button();
            this.TMremove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trainstatus = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TMshow = new System.Windows.Forms.Button();
            this.trainname = new System.Windows.Forms.ComboBox();
            this.traincapacity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Train Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Train Status";
            // 
            // TMadd
            // 
            this.TMadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMadd.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMadd.ForeColor = System.Drawing.Color.White;
            this.TMadd.Location = new System.Drawing.Point(480, 93);
            this.TMadd.Name = "TMadd";
            this.TMadd.Size = new System.Drawing.Size(80, 28);
            this.TMadd.TabIndex = 3;
            this.TMadd.Text = "Add";
            this.TMadd.UseVisualStyleBackColor = true;
            this.TMadd.Click += new System.EventHandler(this.TMadd_Click);
            // 
            // TMedit
            // 
            this.TMedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMedit.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMedit.ForeColor = System.Drawing.Color.White;
            this.TMedit.Location = new System.Drawing.Point(480, 182);
            this.TMedit.Name = "TMedit";
            this.TMedit.Size = new System.Drawing.Size(80, 30);
            this.TMedit.TabIndex = 5;
            this.TMedit.Text = "Update";
            this.TMedit.UseVisualStyleBackColor = true;
            this.TMedit.Click += new System.EventHandler(this.TMedit_Click);
            // 
            // TMremove
            // 
            this.TMremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMremove.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMremove.ForeColor = System.Drawing.Color.White;
            this.TMremove.Location = new System.Drawing.Point(595, 93);
            this.TMremove.Name = "TMremove";
            this.TMremove.Size = new System.Drawing.Size(80, 30);
            this.TMremove.TabIndex = 6;
            this.TMremove.Text = "Remove";
            this.TMremove.UseVisualStyleBackColor = true;
            this.TMremove.Click += new System.EventHandler(this.TMremove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(327, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trains List";
            // 
            // trainstatus
            // 
            this.trainstatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainstatus.FormattingEnabled = true;
            this.trainstatus.Items.AddRange(new object[] {
            "AC",
            "NON AC"});
            this.trainstatus.Location = new System.Drawing.Point(143, 191);
            this.trainstatus.Name = "trainstatus";
            this.trainstatus.Size = new System.Drawing.Size(145, 27);
            this.trainstatus.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 168);
            this.dataGridView1.TabIndex = 12;
            // 
            // TMshow
            // 
            this.TMshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMshow.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMshow.ForeColor = System.Drawing.Color.White;
            this.TMshow.Location = new System.Drawing.Point(595, 182);
            this.TMshow.Name = "TMshow";
            this.TMshow.Size = new System.Drawing.Size(80, 30);
            this.TMshow.TabIndex = 8;
            this.TMshow.Text = "Show";
            this.TMshow.UseVisualStyleBackColor = true;
            this.TMshow.Click += new System.EventHandler(this.TMshow_Click);
            // 
            // trainname
            // 
            this.trainname.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainname.FormattingEnabled = true;
            this.trainname.Items.AddRange(new object[] {
            "Upakul Express",
            "Tista Express",
            "Ekota Express",
            "Parabat Express",
            "Mohanagar Express",
            "Paharika Express",
            "Padma Express",
            "Bijoy Express"});
            this.trainname.Location = new System.Drawing.Point(143, 122);
            this.trainname.Name = "trainname";
            this.trainname.Size = new System.Drawing.Size(145, 27);
            this.trainname.TabIndex = 16;
            // 
            // traincapacity
            // 
            this.traincapacity.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traincapacity.FormattingEnabled = true;
            this.traincapacity.Items.AddRange(new object[] {
            "100",
            "150",
            "200",
            "120",
            "80",
            "180"});
            this.traincapacity.Location = new System.Drawing.Point(143, 155);
            this.traincapacity.Name = "traincapacity";
            this.traincapacity.Size = new System.Drawing.Size(145, 27);
            this.traincapacity.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(305, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Train Master";
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(480, 136);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 30);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 30);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(595, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 28);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TrainMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(778, 474);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.traincapacity);
            this.Controls.Add(this.trainname);
            this.Controls.Add(this.TMshow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.trainstatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TMremove);
            this.Controls.Add(this.TMedit);
            this.Controls.Add(this.TMadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainmaster";
            this.Load += new System.EventHandler(this.TrainMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TMadd;
        private System.Windows.Forms.Button TMedit;
        private System.Windows.Forms.Button TMremove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox trainstatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TMshow;
        private System.Windows.Forms.ComboBox trainname;
        private System.Windows.Forms.ComboBox traincapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}