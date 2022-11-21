namespace Project_NTM01
{
    partial class TimeTable
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
            this.panel_Date = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Background = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAfter = new Project_NTM01.Usercontrol.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrevious = new Project_NTM01.Usercontrol.CustomButton();
            this.panel_Background.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Date
            // 
            this.panel_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Date.Location = new System.Drawing.Point(3, 49);
            this.panel_Date.Name = "panel_Date";
            this.panel_Date.Size = new System.Drawing.Size(1220, 453);
            this.panel_Date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỜI GIAN BIỂU";
            // 
            // panel_Background
            // 
            this.panel_Background.ColumnCount = 1;
            this.panel_Background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_Background.Controls.Add(this.panel_Date, 0, 1);
            this.panel_Background.Controls.Add(this.panel1, 0, 0);
            this.panel_Background.Location = new System.Drawing.Point(43, 93);
            this.panel_Background.Name = "panel_Background";
            this.panel_Background.RowCount = 2;
            this.panel_Background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.126985F));
            this.panel_Background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.87302F));
            this.panel_Background.Size = new System.Drawing.Size(1226, 505);
            this.panel_Background.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.btnAfter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnAfter
            // 
            this.btnAfter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAfter.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAfter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfter.BorderRadius = 0;
            this.btnAfter.BorderSize = 0;
            this.btnAfter.FlatAppearance.BorderSize = 0;
            this.btnAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfter.ForeColor = System.Drawing.Color.White;
            this.btnAfter.Image = global::Project_NTM01.Properties.Resources.right_arrow;
            this.btnAfter.Location = new System.Drawing.Point(1154, -2);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(70, 40);
            this.btnAfter.TabIndex = 4;
            this.btnAfter.TextColor = System.Drawing.Color.White;
            this.btnAfter.UseVisualStyleBackColor = false;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(516, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng ..., Năm ...";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrevious.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrevious.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrevious.BorderRadius = 0;
            this.btnPrevious.BorderSize = 0;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::Project_NTM01.Properties.Resources.left_arrow;
            this.btnPrevious.Location = new System.Drawing.Point(3, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(70, 40);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.TextColor = System.Drawing.Color.White;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1303, 644);
            this.Controls.Add(this.panel_Background);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeTable";
            this.Text = "TimeTable";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            this.panel_Background.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panel_Background;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Usercontrol.CustomButton btnAfter;
        private Usercontrol.CustomButton btnPrevious;
    }
}