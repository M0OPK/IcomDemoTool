namespace IcomTool
{
    partial class IcomDemo
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
            this.lbPorts = new System.Windows.Forms.ListBox();
            this.lbRadios = new System.Windows.Forms.ListBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.mlText = new System.Windows.Forms.TextBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.cmdFind = new System.Windows.Forms.Button();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPorts
            // 
            this.lbPorts.FormattingEnabled = true;
            this.lbPorts.Location = new System.Drawing.Point(26, 35);
            this.lbPorts.Name = "lbPorts";
            this.lbPorts.Size = new System.Drawing.Size(117, 69);
            this.lbPorts.TabIndex = 0;
            // 
            // lbRadios
            // 
            this.lbRadios.FormattingEnabled = true;
            this.lbRadios.Location = new System.Drawing.Point(167, 35);
            this.lbRadios.Name = "lbRadios";
            this.lbRadios.Size = new System.Drawing.Size(126, 69);
            this.lbRadios.TabIndex = 1;
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(26, 111);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(117, 21);
            this.cmdConnect.TabIndex = 2;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // mlText
            // 
            this.mlText.Location = new System.Drawing.Point(26, 181);
            this.mlText.Multiline = true;
            this.mlText.Name = "mlText";
            this.mlText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mlText.Size = new System.Drawing.Size(267, 139);
            this.mlText.TabIndex = 3;
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(167, 138);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(126, 22);
            this.cmdSend.TabIndex = 4;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(167, 109);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(126, 23);
            this.cmdFind.TabIndex = 5;
            this.cmdFind.Text = "Find Radio";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.Location = new System.Drawing.Point(26, 141);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(117, 19);
            this.cmdDisconnect.TabIndex = 6;
            this.cmdDisconnect.Text = "Disconnect";
            this.cmdDisconnect.UseVisualStyleBackColor = true;
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // IcomDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 332);
            this.Controls.Add(this.cmdDisconnect);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.mlText);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.lbRadios);
            this.Controls.Add(this.lbPorts);
            this.Name = "IcomDemo";
            this.Text = "Icom Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPorts;
        private System.Windows.Forms.ListBox lbRadios;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.TextBox mlText;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Button cmdDisconnect;
    }
}

