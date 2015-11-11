namespace TCP_Client
{
    partial class frm_chat
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_send = new System.Windows.Forms.Button();
            this.tmr_UpdateListener = new System.Windows.Forms.Timer(this.components);
            this.tbox_ipaddress = new System.Windows.Forms.TextBox();
            this.tbox_message = new System.Windows.Forms.TextBox();
            this.lbox_messages = new System.Windows.Forms.ListBox();
            this.lbl_ipaddress = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_answers = new System.Windows.Forms.Label();
            this.tmr_sendSpam = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(363, 140);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(68, 24);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tmr_UpdateListener
            // 
            this.tmr_UpdateListener.Enabled = true;
            this.tmr_UpdateListener.Interval = 1;
            this.tmr_UpdateListener.Tick += new System.EventHandler(this.tmr_UpdateListener_Tick);
            // 
            // tbox_ipaddress
            // 
            this.tbox_ipaddress.Location = new System.Drawing.Point(52, 57);
            this.tbox_ipaddress.Name = "tbox_ipaddress";
            this.tbox_ipaddress.Size = new System.Drawing.Size(133, 20);
            this.tbox_ipaddress.TabIndex = 1;
            // 
            // tbox_message
            // 
            this.tbox_message.Location = new System.Drawing.Point(52, 140);
            this.tbox_message.Name = "tbox_message";
            this.tbox_message.Size = new System.Drawing.Size(280, 20);
            this.tbox_message.TabIndex = 2;
            // 
            // lbox_messages
            // 
            this.lbox_messages.FormattingEnabled = true;
            this.lbox_messages.Location = new System.Drawing.Point(52, 230);
            this.lbox_messages.Name = "lbox_messages";
            this.lbox_messages.Size = new System.Drawing.Size(379, 277);
            this.lbox_messages.TabIndex = 3;
            // 
            // lbl_ipaddress
            // 
            this.lbl_ipaddress.AutoSize = true;
            this.lbl_ipaddress.Location = new System.Drawing.Point(49, 41);
            this.lbl_ipaddress.Name = "lbl_ipaddress";
            this.lbl_ipaddress.Size = new System.Drawing.Size(61, 13);
            this.lbl_ipaddress.TabIndex = 4;
            this.lbl_ipaddress.Text = "IP Address:";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(49, 124);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(53, 13);
            this.lbl_message.TabIndex = 5;
            this.lbl_message.Text = "Message:";
            // 
            // lbl_answers
            // 
            this.lbl_answers.AutoSize = true;
            this.lbl_answers.Location = new System.Drawing.Point(49, 214);
            this.lbl_answers.Name = "lbl_answers";
            this.lbl_answers.Size = new System.Drawing.Size(50, 13);
            this.lbl_answers.TabIndex = 6;
            this.lbl_answers.Text = "Answers:";
            // 
            // tmr_sendSpam
            // 
            this.tmr_sendSpam.Enabled = true;
            this.tmr_sendSpam.Interval = 1000;
            this.tmr_sendSpam.Tick += new System.EventHandler(this.tmr_sendSpam_Tick);
            // 
            // frm_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 541);
            this.Controls.Add(this.lbl_answers);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_ipaddress);
            this.Controls.Add(this.lbox_messages);
            this.Controls.Add(this.tbox_message);
            this.Controls.Add(this.tbox_ipaddress);
            this.Controls.Add(this.btn_send);
            this.Name = "frm_chat";
            this.Text = "TCP Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Timer tmr_UpdateListener;
        private System.Windows.Forms.TextBox tbox_ipaddress;
        private System.Windows.Forms.TextBox tbox_message;
        internal System.Windows.Forms.ListBox lbox_messages;
        internal System.Windows.Forms.Label lbl_ipaddress;
        internal System.Windows.Forms.Label lbl_message;
        internal System.Windows.Forms.Label lbl_answers;
        private System.Windows.Forms.Timer tmr_sendSpam;
    }
}

