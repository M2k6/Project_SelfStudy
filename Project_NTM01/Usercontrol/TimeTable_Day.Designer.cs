namespace Project_NTM01.Usercontrol
{
    partial class TimeTable_Day
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Date.Location = new System.Drawing.Point(16, 17);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(45, 29);
            this.lb_Date.TabIndex = 0;
            this.lb_Date.Text = "30";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("UTM Colossalis", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.Location = new System.Drawing.Point(11, 60);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(55, 21);
            this.lb_Status.TabIndex = 1;
            this.lb_Status.Text = "THỨ 2";
            // 
            // TimeTable_Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_Date);
            this.Name = "TimeTable_Day";
            this.Size = new System.Drawing.Size(81, 90);
            this.MouseLeave += new System.EventHandler(this.TimeTable_Day_MouseLeave);
            this.MouseHover += new System.EventHandler(this.TimeTable_Day_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_Status;
    }
}
