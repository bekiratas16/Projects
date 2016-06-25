namespace WifiBaglantiNoktasi
{
    partial class Form1
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
            this.btnCreateWifi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnStartWifi = new System.Windows.Forms.Button();
            this.btnStopWifi = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateWifi
            // 
            this.btnCreateWifi.Location = new System.Drawing.Point(88, 88);
            this.btnCreateWifi.Name = "btnCreateWifi";
            this.btnCreateWifi.Size = new System.Drawing.Size(276, 23);
            this.btnCreateWifi.TabIndex = 0;
            this.btnCreateWifi.Text = "Create Hotspot Network";
            this.btnCreateWifi.UseVisualStyleBackColor = true;
            this.btnCreateWifi.Click += new System.EventHandler(this.btnCreateWifi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SSID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(88, 25);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(100, 20);
            this.txtSSID.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnStartWifi
            // 
            this.btnStartWifi.Location = new System.Drawing.Point(208, 25);
            this.btnStartWifi.Name = "btnStartWifi";
            this.btnStartWifi.Size = new System.Drawing.Size(75, 23);
            this.btnStartWifi.TabIndex = 5;
            this.btnStartWifi.Text = "Start";
            this.btnStartWifi.UseVisualStyleBackColor = true;
            this.btnStartWifi.Click += new System.EventHandler(this.btnStartWifi_Click);
            // 
            // btnStopWifi
            // 
            this.btnStopWifi.Location = new System.Drawing.Point(289, 25);
            this.btnStopWifi.Name = "btnStopWifi";
            this.btnStopWifi.Size = new System.Drawing.Size(75, 23);
            this.btnStopWifi.TabIndex = 6;
            this.btnStopWifi.Text = "Stop";
            this.btnStopWifi.UseVisualStyleBackColor = true;
            this.btnStopWifi.Click += new System.EventHandler(this.btnStopWifi_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(208, 54);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(289, 54);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 220);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStopWifi);
            this.Controls.Add(this.btnStartWifi);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateWifi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateWifi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnStartWifi;
        private System.Windows.Forms.Button btnStopWifi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInfo;
    }
}

