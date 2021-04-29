
namespace HabitForm
{
    partial class HabitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbNamaHabit = new System.Windows.Forms.TextBox();
            this.tbKeterangan = new System.Windows.Forms.TextBox();
            this.tbCalendar = new System.Windows.Forms.TextBox();
            this.tbYesOrNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keterangan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "D / M / Y  :";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(109, 233);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(107, 26);
            this.btnAction.TabIndex = 4;
            this.btnAction.Text = "Add";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbNamaHabit
            // 
            this.tbNamaHabit.Location = new System.Drawing.Point(109, 24);
            this.tbNamaHabit.Name = "tbNamaHabit";
            this.tbNamaHabit.Size = new System.Drawing.Size(232, 20);
            this.tbNamaHabit.TabIndex = 9;
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.Location = new System.Drawing.Point(109, 64);
            this.tbKeterangan.Multiline = true;
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.Size = new System.Drawing.Size(232, 77);
            this.tbKeterangan.TabIndex = 10;
            // 
            // tbCalendar
            // 
            this.tbCalendar.Location = new System.Drawing.Point(109, 159);
            this.tbCalendar.Name = "tbCalendar";
            this.tbCalendar.Size = new System.Drawing.Size(232, 20);
            this.tbCalendar.TabIndex = 11;
            // 
            // tbYesOrNo
            // 
            this.tbYesOrNo.Location = new System.Drawing.Point(109, 196);
            this.tbYesOrNo.Name = "tbYesOrNo";
            this.tbYesOrNo.Size = new System.Drawing.Size(232, 20);
            this.tbYesOrNo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yes / No :";
            // 
            // HabitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbYesOrNo);
            this.Controls.Add(this.tbCalendar);
            this.Controls.Add(this.tbKeterangan);
            this.Controls.Add(this.tbNamaHabit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HabitForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbNamaHabit;
        private System.Windows.Forms.TextBox tbKeterangan;
        private System.Windows.Forms.TextBox tbCalendar;
        private System.Windows.Forms.TextBox tbYesOrNo;
        private System.Windows.Forms.Label label4;
    }
}

