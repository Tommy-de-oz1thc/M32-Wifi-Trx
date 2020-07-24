namespace M32_Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.btnConnect = new System.Windows.Forms.Button();
            this.pic_M32 = new System.Windows.Forms.PictureBox();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.txtStatusText = new System.Windows.Forms.TextBox();
            this.labCall = new System.Windows.Forms.Label();
            this.labStatusText = new System.Windows.Forms.Label();
            this.txtSent = new System.Windows.Forms.TextBox();
            this.btnSent = new System.Windows.Forms.Button();
            this.labInfo = new System.Windows.Forms.Label();
            this.IpAddress = new System.Windows.Forms.Label();
            this.comboIpAddress = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_M32)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(376, 107);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 28);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pic_M32
            // 
            this.pic_M32.Image = ((System.Drawing.Image)(resources.GetObject("pic_M32.Image")));
            this.pic_M32.Location = new System.Drawing.Point(12, 21);
            this.pic_M32.Name = "pic_M32";
            this.pic_M32.Size = new System.Drawing.Size(330, 166);
            this.pic_M32.TabIndex = 12;
            this.pic_M32.TabStop = false;
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Location = new System.Drawing.Point(376, 159);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(91, 28);
            this.btnDisConnect.TabIndex = 15;
            this.btnDisConnect.Text = "DisConnect";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // txtStatusText
            // 
            this.txtStatusText.Location = new System.Drawing.Point(12, 227);
            this.txtStatusText.Multiline = true;
            this.txtStatusText.Name = "txtStatusText";
            this.txtStatusText.ReadOnly = true;
            this.txtStatusText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusText.Size = new System.Drawing.Size(330, 192);
            this.txtStatusText.TabIndex = 16;
            // 
            // labCall
            // 
            this.labCall.AutoSize = true;
            this.labCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCall.Location = new System.Drawing.Point(370, 21);
            this.labCall.Name = "labCall";
            this.labCall.Size = new System.Drawing.Size(138, 66);
            this.labCall.TabIndex = 17;
            this.labCall.Text = "OZ1THC\r\nTommy";
            // 
            // labStatusText
            // 
            this.labStatusText.AutoSize = true;
            this.labStatusText.Location = new System.Drawing.Point(12, 200);
            this.labStatusText.Name = "labStatusText";
            this.labStatusText.Size = new System.Drawing.Size(64, 13);
            this.labStatusText.TabIndex = 18;
            this.labStatusText.Text = "Status Text:";
            // 
            // txtSent
            // 
            this.txtSent.Location = new System.Drawing.Point(12, 445);
            this.txtSent.Name = "txtSent";
            this.txtSent.Size = new System.Drawing.Size(330, 20);
            this.txtSent.TabIndex = 19;
            // 
            // btnSent
            // 
            this.btnSent.Location = new System.Drawing.Point(376, 437);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(91, 28);
            this.btnSent.TabIndex = 20;
            this.btnSent.Text = "Sent to Server";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfo.Location = new System.Drawing.Point(358, 253);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(173, 144);
            this.labInfo.TabIndex = 21;
            this.labInfo.Text = "This Client is a help\r\nso you can test \r\nwhat the paddle\r\nMorserino - 32\r\nsent an" +
    "d receive \r\nfrom the server.\r\n";
            // 
            // IpAddress
            // 
            this.IpAddress.AutoSize = true;
            this.IpAddress.Location = new System.Drawing.Point(364, 211);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(57, 13);
            this.IpAddress.TabIndex = 23;
            this.IpAddress.Text = "IpAddress:";
            // 
            // comboIpAddress
            // 
            this.comboIpAddress.FormattingEnabled = true;
            this.comboIpAddress.Items.AddRange(new object[] {
            "93.104.209.96",
            "192.168.1.79"});
            this.comboIpAddress.Location = new System.Drawing.Point(362, 229);
            this.comboIpAddress.Name = "comboIpAddress";
            this.comboIpAddress.Size = new System.Drawing.Size(146, 21);
            this.comboIpAddress.TabIndex = 24;
            this.comboIpAddress.Text = "192.168.1.79";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 477);
            this.Controls.Add(this.comboIpAddress);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtSent);
            this.Controls.Add(this.labStatusText);
            this.Controls.Add(this.labCall);
            this.Controls.Add(this.txtStatusText);
            this.Controls.Add(this.btnDisConnect);
            this.Controls.Add(this.pic_M32);
            this.Controls.Add(this.btnConnect);
            this.Name = "Client";
            this.Text = "M32 Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_M32)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.PictureBox pic_M32;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.TextBox txtStatusText;
        private System.Windows.Forms.Label labCall;
        private System.Windows.Forms.Label labStatusText;
        private System.Windows.Forms.TextBox txtSent;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Label IpAddress;
        private System.Windows.Forms.ComboBox comboIpAddress;
    }
}

