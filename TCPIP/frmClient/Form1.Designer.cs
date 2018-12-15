namespace frmClient
{
    partial class frmClient
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtBoxHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Location = new System.Drawing.Point(269, 60);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(52, 20);
            this.txtBoxPort.TabIndex = 9;
            this.txtBoxPort.Text = "8910";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(220, 63);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port:";
            // 
            // txtBoxHost
            // 
            this.txtBoxHost.Location = new System.Drawing.Point(91, 58);
            this.txtBoxHost.Name = "txtBoxHost";
            this.txtBoxHost.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHost.TabIndex = 7;
            this.txtBoxHost.Text = "127.0.0.1";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(34, 58);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 6;
            this.lblHost.Text = "Host:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(349, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.Location = new System.Drawing.Point(37, 108);
            this.txtBoxMessage.Multiline = true;
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(686, 53);
            this.txtBoxMessage.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(636, 184);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Location = new System.Drawing.Point(37, 224);
            this.txtBoxStatus.Multiline = true;
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.Size = new System.Drawing.Size(686, 187);
            this.txtBoxStatus.TabIndex = 12;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBoxMessage);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtBoxHost);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.btnConnect);
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtBoxHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtBoxMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBoxStatus;
    }
}

