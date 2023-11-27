
namespace Railway_Resevation_System
{
    partial class TravelMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelMaster));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TRMadd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trainCode = new System.Windows.Forms.ComboBox();
            this.destination = new System.Windows.Forms.ComboBox();
            this.travelcost = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TRMremove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.trainsource = new System.Windows.Forms.ComboBox();
            this.TRMshowall = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Travel  Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Train Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destination";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Travel Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(343, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Travels";
            // 
            // TRMadd
            // 
            this.TRMadd.BackColor = System.Drawing.Color.Transparent;
            this.TRMadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TRMadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRMadd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRMadd.ForeColor = System.Drawing.Color.White;
            this.TRMadd.Location = new System.Drawing.Point(471, 86);
            this.TRMadd.Name = "TRMadd";
            this.TRMadd.Size = new System.Drawing.Size(99, 29);
            this.TRMadd.TabIndex = 1;
            this.TRMadd.Text = "Add";
            this.TRMadd.UseVisualStyleBackColor = false;
            this.TRMadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 29);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // trainCode
            // 
            this.trainCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainCode.FormattingEnabled = true;
            this.trainCode.Items.AddRange(new object[] {
            "707",
            "708",
            "723",
            "727",
            "740",
            "745",
            "752",
            "786"});
            this.trainCode.Location = new System.Drawing.Point(150, 128);
            this.trainCode.Name = "trainCode";
            this.trainCode.Size = new System.Drawing.Size(133, 28);
            this.trainCode.TabIndex = 11;
            this.trainCode.SelectedIndexChanged += new System.EventHandler(this.trainCode_SelectedIndexChanged);
            // 
            // destination
            // 
            this.destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.FormattingEnabled = true;
            this.destination.Items.AddRange(new object[] {
            "Dhaka",
            "Khulna",
            "Chattogram",
            "Rajshahi",
            "Sylhet"});
            this.destination.Location = new System.Drawing.Point(150, 211);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(133, 28);
            this.destination.TabIndex = 12;
            // 
            // travelcost
            // 
            this.travelcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelcost.ForeColor = System.Drawing.Color.Navy;
            this.travelcost.FormattingEnabled = true;
            this.travelcost.Items.AddRange(new object[] {
            "350",
            "550",
            "600",
            "750",
            "950"});
            this.travelcost.Location = new System.Drawing.Point(150, 255);
            this.travelcost.Name = "travelcost";
            this.travelcost.Size = new System.Drawing.Size(133, 28);
            this.travelcost.TabIndex = 13;
            this.travelcost.SelectedIndexChanged += new System.EventHandler(this.travelcost_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 178);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TRMremove
            // 
            this.TRMremove.BackColor = System.Drawing.Color.Transparent;
            this.TRMremove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TRMremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRMremove.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRMremove.ForeColor = System.Drawing.Color.White;
            this.TRMremove.Location = new System.Drawing.Point(601, 86);
            this.TRMremove.Name = "TRMremove";
            this.TRMremove.Size = new System.Drawing.Size(99, 29);
            this.TRMremove.TabIndex = 4;
            this.TRMremove.Text = "Remove";
            this.TRMremove.UseVisualStyleBackColor = false;
            this.TRMremove.Click += new System.EventHandler(this.TRMremove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Source";
            // 
            // trainsource
            // 
            this.trainsource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainsource.FormattingEnabled = true;
            this.trainsource.Items.AddRange(new object[] {
            "Dhaka",
            "Khulna",
            "Chattogram",
            "Rajshahi",
            "Sylhet"});
            this.trainsource.Location = new System.Drawing.Point(150, 168);
            this.trainsource.Name = "trainsource";
            this.trainsource.Size = new System.Drawing.Size(133, 28);
            this.trainsource.TabIndex = 17;
            // 
            // TRMshowall
            // 
            this.TRMshowall.BackColor = System.Drawing.Color.Transparent;
            this.TRMshowall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TRMshowall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRMshowall.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRMshowall.ForeColor = System.Drawing.Color.White;
            this.TRMshowall.Location = new System.Drawing.Point(601, 175);
            this.TRMshowall.Name = "TRMshowall";
            this.TRMshowall.Size = new System.Drawing.Size(99, 29);
            this.TRMshowall.TabIndex = 6;
            this.TRMshowall.Text = "Show All";
            this.TRMshowall.UseVisualStyleBackColor = false;
            this.TRMshowall.Click += new System.EventHandler(this.TRMshowall_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(471, 130);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 29);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 30);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(601, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 29);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(471, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TravelMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(781, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.TRMshowall);
            this.Controls.Add(this.trainsource);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TRMremove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.travelcost);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.trainCode);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TRMadd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TravelMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travelmaster";
            this.Load += new System.EventHandler(this.TravelMaster_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TRMadd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox trainCode;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.ComboBox travelcost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TRMremove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox trainsource;
        private System.Windows.Forms.Button TRMshowall;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
    }
}