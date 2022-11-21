namespace Project_NTM01
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
            this.btnTimeTable = new Project_NTM01.Usercontrol.CustomButton();
            this.btnRevise = new Project_NTM01.Usercontrol.CustomButton();
            this.btnYourSelf = new Project_NTM01.Usercontrol.CustomButton();
            this.btnSetting = new Project_NTM01.Usercontrol.CustomButton();
            this.SuspendLayout();
            // 
            // btnTimeTable
            // 
            this.btnTimeTable.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimeTable.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimeTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimeTable.BorderRadius = 30;
            this.btnTimeTable.BorderSize = 0;
            this.btnTimeTable.FlatAppearance.BorderSize = 0;
            this.btnTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeTable.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimeTable.ForeColor = System.Drawing.Color.White;
            this.btnTimeTable.Location = new System.Drawing.Point(85, 106);
            this.btnTimeTable.Name = "btnTimeTable";
            this.btnTimeTable.Size = new System.Drawing.Size(272, 69);
            this.btnTimeTable.TabIndex = 2;
            this.btnTimeTable.Text = "Thời Gian Biểu";
            this.btnTimeTable.TextColor = System.Drawing.Color.White;
            this.btnTimeTable.UseVisualStyleBackColor = false;
            // 
            // btnRevise
            // 
            this.btnRevise.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRevise.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRevise.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRevise.BorderRadius = 30;
            this.btnRevise.BorderSize = 0;
            this.btnRevise.FlatAppearance.BorderSize = 0;
            this.btnRevise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevise.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 9F);
            this.btnRevise.ForeColor = System.Drawing.Color.White;
            this.btnRevise.Location = new System.Drawing.Point(85, 214);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(272, 69);
            this.btnRevise.TabIndex = 3;
            this.btnRevise.Text = "Ôn Tập Kiến Thức";
            this.btnRevise.TextColor = System.Drawing.Color.White;
            this.btnRevise.UseVisualStyleBackColor = false;
            // 
            // btnYourSelf
            // 
            this.btnYourSelf.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnYourSelf.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnYourSelf.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnYourSelf.BorderRadius = 30;
            this.btnYourSelf.BorderSize = 0;
            this.btnYourSelf.FlatAppearance.BorderSize = 0;
            this.btnYourSelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourSelf.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 9F);
            this.btnYourSelf.ForeColor = System.Drawing.Color.White;
            this.btnYourSelf.Location = new System.Drawing.Point(85, 326);
            this.btnYourSelf.Name = "btnYourSelf";
            this.btnYourSelf.Size = new System.Drawing.Size(272, 69);
            this.btnYourSelf.TabIndex = 4;
            this.btnYourSelf.Text = "Đánh Giá Bản Thân";
            this.btnYourSelf.TextColor = System.Drawing.Color.White;
            this.btnYourSelf.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetting.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetting.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSetting.BorderRadius = 30;
            this.btnSetting.BorderSize = 0;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("UTM Swiss 721 Black Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(85, 437);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(272, 69);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Cài Đặt";
            this.btnSetting.TextColor = System.Drawing.Color.White;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1303, 644);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnYourSelf);
            this.Controls.Add(this.btnRevise);
            this.Controls.Add(this.btnTimeTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Usercontrol.CustomButton btnTimeTable;
        private Usercontrol.CustomButton btnRevise;
        private Usercontrol.CustomButton btnYourSelf;
        private Usercontrol.CustomButton btnSetting;
    }
}