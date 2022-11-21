namespace Project_NTM01
{
    partial class Mission_Record_Form
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
            this.panel_Container = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new Project_NTM01.Usercontrol.CustomButton();
            this.btnAdd1 = new Project_NTM01.Usercontrol.CustomButton();
            this.btnAdd2 = new Project_NTM01.Usercontrol.CustomButton();
            this.btnAdd3 = new Project_NTM01.Usercontrol.CustomButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Container
            // 
            this.panel_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Container.ColumnCount = 5;
            this.panel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.panel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.panel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.panel_Container.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.panel_Container.Controls.Add(this.panel1, 0, 0);
            this.panel_Container.Controls.Add(this.panel2, 2, 0);
            this.panel_Container.Controls.Add(this.panel3, 4, 0);
            this.panel_Container.Controls.Add(this.flowLayoutPanel1, 2, 1);
            this.panel_Container.Controls.Add(this.flowLayoutPanel3, 4, 1);
            this.panel_Container.Location = new System.Drawing.Point(52, 85);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.RowCount = 2;
            this.panel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 422F));
            this.panel_Container.Size = new System.Drawing.Size(1200, 468);
            this.panel_Container.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.btnAdd1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.btnAdd2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(388, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 40);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.btnAdd3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(848, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 40);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỊCH TRÌNH CÔNG VIỆC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "SÁNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "CHIỀU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "TỐI";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 0;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::Project_NTM01.Properties.Resources.left_arrow;
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnAdd1
            // 
            this.btnAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd1.BorderRadius = 0;
            this.btnAdd1.BorderSize = 0;
            this.btnAdd1.FlatAppearance.BorderSize = 0;
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd1.ForeColor = System.Drawing.Color.White;
            this.btnAdd1.Image = global::Project_NTM01.Properties.Resources.plus__1_;
            this.btnAdd1.Location = new System.Drawing.Point(307, -1);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(44, 40);
            this.btnAdd1.TabIndex = 1;
            this.btnAdd1.TextColor = System.Drawing.Color.White;
            this.btnAdd1.UseVisualStyleBackColor = false;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd2.BorderRadius = 0;
            this.btnAdd2.BorderSize = 0;
            this.btnAdd2.FlatAppearance.BorderSize = 0;
            this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd2.ForeColor = System.Drawing.Color.White;
            this.btnAdd2.Image = global::Project_NTM01.Properties.Resources.plus__1_;
            this.btnAdd2.Location = new System.Drawing.Point(380, 0);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(44, 40);
            this.btnAdd2.TabIndex = 2;
            this.btnAdd2.TextColor = System.Drawing.Color.White;
            this.btnAdd2.UseVisualStyleBackColor = false;
            // 
            // btnAdd3
            // 
            this.btnAdd3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd3.BorderRadius = 0;
            this.btnAdd3.BorderSize = 0;
            this.btnAdd3.FlatAppearance.BorderSize = 0;
            this.btnAdd3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd3.ForeColor = System.Drawing.Color.White;
            this.btnAdd3.Image = global::Project_NTM01.Properties.Resources.plus__1_;
            this.btnAdd3.Location = new System.Drawing.Point(304, 1);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(44, 40);
            this.btnAdd3.TabIndex = 3;
            this.btnAdd3.TextColor = System.Drawing.Color.White;
            this.btnAdd3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(388, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(424, 419);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 44);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(353, 420);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(848, 44);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(352, 420);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // Mission_Record_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1281, 588);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mission_Record_Form";
            this.Text = "Mission_Record_Form";
            this.panel_Container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_Container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Usercontrol.CustomButton btnExit;
        private Usercontrol.CustomButton btnAdd1;
        private Usercontrol.CustomButton btnAdd2;
        private Usercontrol.CustomButton btnAdd3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}