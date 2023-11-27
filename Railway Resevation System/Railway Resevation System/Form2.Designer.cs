
namespace Railway_Resevation_System
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.TravelMaster = new System.Windows.Forms.Button();
            this.PassengerMaster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TravelMaster
            // 
            this.TravelMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TravelMaster.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelMaster.ForeColor = System.Drawing.Color.White;
            this.TravelMaster.Location = new System.Drawing.Point(284, 382);
            this.TravelMaster.Name = "TravelMaster";
            this.TravelMaster.Size = new System.Drawing.Size(181, 37);
            this.TravelMaster.TabIndex = 2;
            this.TravelMaster.Text = "Travel Master";
            this.TravelMaster.UseVisualStyleBackColor = true;
            this.TravelMaster.Click += new System.EventHandler(this.TravelMaster_Click);
            // 
            // PassengerMaster
            // 
            this.PassengerMaster.BackColor = System.Drawing.Color.Transparent;
            this.PassengerMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerMaster.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerMaster.ForeColor = System.Drawing.Color.White;
            this.PassengerMaster.Location = new System.Drawing.Point(284, 253);
            this.PassengerMaster.Name = "PassengerMaster";
            this.PassengerMaster.Size = new System.Drawing.Size(181, 37);
            this.PassengerMaster.TabIndex = 1;
            this.PassengerMaster.Text = "Passenger Master";
            this.PassengerMaster.UseVisualStyleBackColor = false;
            this.PassengerMaster.Click += new System.EventHandler(this.PassengerMaster_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(284, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Train Master";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 401);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 30);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(503, 481);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TravelMaster);
            this.Controls.Add(this.PassengerMaster);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TravelMaster;
        private System.Windows.Forms.Button PassengerMaster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}