
namespace TCP_Client_Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_messageRecv = new System.Windows.Forms.TextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_ipAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // textBox_messageRecv
            // 
            this.textBox_messageRecv.Location = new System.Drawing.Point(108, 60);
            this.textBox_messageRecv.Multiline = true;
            this.textBox_messageRecv.Name = "textBox_messageRecv";
            this.textBox_messageRecv.Size = new System.Drawing.Size(322, 261);
            this.textBox_messageRecv.TabIndex = 2;
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(108, 327);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(322, 22);
            this.textBox_message.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message:";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(351, 23);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(79, 31);
            this.button_connect.TabIndex = 5;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(351, 355);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(79, 31);
            this.button_send.TabIndex = 6;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Port:";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(261, 27);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(39, 22);
            this.textBox_port.TabIndex = 21;
            this.textBox_port.Text = "8080";
            // 
            // textBox_ipAddress
            // 
            this.textBox_ipAddress.Location = new System.Drawing.Point(108, 27);
            this.textBox_ipAddress.Name = "textBox_ipAddress";
            this.textBox_ipAddress.Size = new System.Drawing.Size(103, 22);
            this.textBox_ipAddress.TabIndex = 20;
            this.textBox_ipAddress.Text = "192.168.18.229";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 420);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ipAddress);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_messageRecv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TCP/IP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_messageRecv;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_ipAddress;
    }
}

