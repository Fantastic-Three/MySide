
namespace MySide
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HabitFormBtn = new System.Windows.Forms.Button();
            this.HabitViewBtn = new System.Windows.Forms.Button();
            this.RemindBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("sweet purple", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to MySide";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HabitFormBtn
            // 
            this.HabitFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(148)))));
            this.HabitFormBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HabitFormBtn.Location = new System.Drawing.Point(208, 283);
            this.HabitFormBtn.Name = "HabitFormBtn";
            this.HabitFormBtn.Size = new System.Drawing.Size(549, 77);
            this.HabitFormBtn.TabIndex = 5;
            this.HabitFormBtn.Text = "Add Habit";
            this.HabitFormBtn.UseVisualStyleBackColor = false;
            this.HabitFormBtn.Click += new System.EventHandler(this.HabitFormBtn_Click);
            // 
            // HabitViewBtn
            // 
            this.HabitViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(148)))));
            this.HabitViewBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HabitViewBtn.Location = new System.Drawing.Point(208, 400);
            this.HabitViewBtn.Name = "HabitViewBtn";
            this.HabitViewBtn.Size = new System.Drawing.Size(549, 77);
            this.HabitViewBtn.TabIndex = 6;
            this.HabitViewBtn.Text = "Habit List ";
            this.HabitViewBtn.UseVisualStyleBackColor = false;
            this.HabitViewBtn.Click += new System.EventHandler(this.HabitViewBtn_Click);
            // 
            // RemindBtn
            // 
            this.RemindBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(148)))));
            this.RemindBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemindBtn.Location = new System.Drawing.Point(208, 511);
            this.RemindBtn.Name = "RemindBtn";
            this.RemindBtn.Size = new System.Drawing.Size(549, 80);
            this.RemindBtn.TabIndex = 7;
            this.RemindBtn.Text = "Reminder ";
            this.RemindBtn.UseVisualStyleBackColor = false;
            this.RemindBtn.Click += new System.EventHandler(this.RemindBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(926, 643);
            this.Controls.Add(this.RemindBtn);
            this.Controls.Add(this.HabitViewBtn);
            this.Controls.Add(this.HabitFormBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HabitFormBtn;
        private System.Windows.Forms.Button HabitViewBtn;
        private System.Windows.Forms.Button RemindBtn;
    }
}