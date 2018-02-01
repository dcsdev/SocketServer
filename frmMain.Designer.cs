namespace FunsWIthSockets
{
    partial class frmMain
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
            this.btnStartListening = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.txtMessagesToSend = new System.Windows.Forms.TextBox();
            this.btnStopListening = new System.Windows.Forms.Button();
            this.btnCreateSocketServer = new System.Windows.Forms.Button();
            this.lblSocketServer = new System.Windows.Forms.Label();
            this.lblOutgoingData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartListening
            // 
            this.btnStartListening.Location = new System.Drawing.Point(162, 46);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(208, 23);
            this.btnStartListening.TabIndex = 0;
            this.btnStartListening.Text = "Start Listening";
            this.btnStartListening.UseVisualStyleBackColor = true;
            this.btnStartListening.Click += new System.EventHandler(this.btnStartListening_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(6, 235);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(368, 51);
            this.txtMessages.TabIndex = 1;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(202, 121);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(172, 68);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txtMessagesToSend
            // 
            this.txtMessagesToSend.Location = new System.Drawing.Point(6, 121);
            this.txtMessagesToSend.Multiline = true;
            this.txtMessagesToSend.Name = "txtMessagesToSend";
            this.txtMessagesToSend.Size = new System.Drawing.Size(190, 68);
            this.txtMessagesToSend.TabIndex = 3;
            // 
            // btnStopListening
            // 
            this.btnStopListening.Location = new System.Drawing.Point(162, 75);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(208, 23);
            this.btnStopListening.TabIndex = 4;
            this.btnStopListening.Text = "Stop Listening";
            this.btnStopListening.UseVisualStyleBackColor = true;
            this.btnStopListening.Click += new System.EventHandler(this.btnStopListening_Click);
            // 
            // btnCreateSocketServer
            // 
            this.btnCreateSocketServer.Location = new System.Drawing.Point(6, 46);
            this.btnCreateSocketServer.Name = "btnCreateSocketServer";
            this.btnCreateSocketServer.Size = new System.Drawing.Size(141, 23);
            this.btnCreateSocketServer.TabIndex = 5;
            this.btnCreateSocketServer.Text = "Create Socket Server";
            this.btnCreateSocketServer.UseVisualStyleBackColor = true;
            this.btnCreateSocketServer.Click += new System.EventHandler(this.btnCreateSocketServer_Click);
            // 
            // lblSocketServer
            // 
            this.lblSocketServer.AutoSize = true;
            this.lblSocketServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocketServer.Location = new System.Drawing.Point(2, 9);
            this.lblSocketServer.Name = "lblSocketServer";
            this.lblSocketServer.Size = new System.Drawing.Size(140, 24);
            this.lblSocketServer.TabIndex = 6;
            this.lblSocketServer.Text = "Socket Server";
            // 
            // lblOutgoingData
            // 
            this.lblOutgoingData.AutoSize = true;
            this.lblOutgoingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutgoingData.Location = new System.Drawing.Point(3, 93);
            this.lblOutgoingData.Name = "lblOutgoingData";
            this.lblOutgoingData.Size = new System.Drawing.Size(89, 13);
            this.lblOutgoingData.TabIndex = 7;
            this.lblOutgoingData.Text = "Outgoing Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Activity";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutgoingData);
            this.Controls.Add(this.lblSocketServer);
            this.Controls.Add(this.btnCreateSocketServer);
            this.Controls.Add(this.btnStopListening);
            this.Controls.Add(this.txtMessagesToSend);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnStartListening);
            this.Name = "frmMain";
            this.Text = "Socket Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox txtMessagesToSend;
        private System.Windows.Forms.Button btnStopListening;
        private System.Windows.Forms.Button btnCreateSocketServer;
        private System.Windows.Forms.Label lblSocketServer;
        private System.Windows.Forms.Label lblOutgoingData;
        private System.Windows.Forms.Label label1;
    }
}

