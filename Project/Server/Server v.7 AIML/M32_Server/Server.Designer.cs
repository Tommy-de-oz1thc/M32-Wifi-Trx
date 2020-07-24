namespace M32_Server
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.txtSentText = new System.Windows.Forms.TextBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.labSentText = new System.Windows.Forms.Label();
            this.btnSent = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pic_M32 = new System.Windows.Forms.PictureBox();
            this.labCall = new System.Windows.Forms.Label();
            this.txtStatusText = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.labVErsion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_M32)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSentText
            // 
            this.txtSentText.Location = new System.Drawing.Point(26, 547);
            this.txtSentText.Name = "txtSentText";
            this.txtSentText.Size = new System.Drawing.Size(351, 20);
            this.txtSentText.TabIndex = 5;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(23, 204);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(64, 13);
            this.labStatus.TabIndex = 6;
            this.labStatus.Text = "Status Text:";
            // 
            // labSentText
            // 
            this.labSentText.AutoSize = true;
            this.labSentText.Location = new System.Drawing.Point(23, 515);
            this.labSentText.Name = "labSentText";
            this.labSentText.Size = new System.Drawing.Size(56, 13);
            this.labSentText.TabIndex = 7;
            this.labSentText.Text = "Sent Text:";
            // 
            // btnSent
            // 
            this.btnSent.Location = new System.Drawing.Point(406, 545);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(90, 23);
            this.btnSent.TabIndex = 8;
            this.btnSent.Text = "Sent to M32";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(396, 131);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pic_M32
            // 
            this.pic_M32.Image = ((System.Drawing.Image)(resources.GetObject("pic_M32.Image")));
            this.pic_M32.Location = new System.Drawing.Point(26, 29);
            this.pic_M32.Name = "pic_M32";
            this.pic_M32.Size = new System.Drawing.Size(330, 166);
            this.pic_M32.TabIndex = 11;
            this.pic_M32.TabStop = false;
            // 
            // labCall
            // 
            this.labCall.AutoSize = true;
            this.labCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCall.Location = new System.Drawing.Point(377, 29);
            this.labCall.Name = "labCall";
            this.labCall.Size = new System.Drawing.Size(138, 66);
            this.labCall.TabIndex = 12;
            this.labCall.Text = "OZ1THC\r\nTommy";
            // 
            // txtStatusText
            // 
            this.txtStatusText.Location = new System.Drawing.Point(26, 235);
            this.txtStatusText.Multiline = true;
            this.txtStatusText.Name = "txtStatusText";
            this.txtStatusText.ReadOnly = true;
            this.txtStatusText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusText.Size = new System.Drawing.Size(351, 258);
            this.txtStatusText.TabIndex = 13;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(396, 172);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop Server";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labVErsion
            // 
            this.labVErsion.AutoSize = true;
            this.labVErsion.Location = new System.Drawing.Point(415, 480);
            this.labVErsion.Name = "labVErsion";
            this.labVErsion.Size = new System.Drawing.Size(88, 13);
            this.labVErsion.TabIndex = 14;
            this.labVErsion.Text = "Version v.7 AIML";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 604);
            this.Controls.Add(this.labVErsion);
            this.Controls.Add(this.txtStatusText);
            this.Controls.Add(this.labCall);
            this.Controls.Add(this.pic_M32);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.labSentText);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.txtSentText);
            this.Name = "Server";
            this.Text = "M32 Server ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_M32)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSentText;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labSentText;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pic_M32;
        private System.Windows.Forms.Label labCall;
        private System.Windows.Forms.TextBox txtStatusText;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labVErsion;
    }
}

