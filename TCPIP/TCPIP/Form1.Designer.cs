namespace TCPIP
{
    partial class frmServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtBoxHost = new System.Windows.Forms.TextBox();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(355, 67);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(40, 68);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Host:";
            // 
            // txtBoxHost
            // 
            this.txtBoxHost.Location = new System.Drawing.Point(97, 68);
            this.txtBoxHost.Name = "txtBoxHost";
            this.txtBoxHost.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHost.TabIndex = 2;
            this.txtBoxHost.Text = "127.0.0.1";
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Location = new System.Drawing.Point(275, 70);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(52, 20);
            this.txtBoxPort.TabIndex = 4;
            this.txtBoxPort.Text = "8910";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(226, 73);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(459, 68);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Location = new System.Drawing.Point(43, 119);
            this.txtBoxStatus.Multiline = true;
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.Size = new System.Drawing.Size(491, 259);
            this.txtBoxStatus.TabIndex = 6;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtBoxHost);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.btnStart);
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtBoxHost;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtBoxStatus;
    }
}

