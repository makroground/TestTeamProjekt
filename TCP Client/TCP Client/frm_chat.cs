using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class frm_chat : Form
    {
        TcpListener Listener = new TcpListener(65535);
        TcpClient Client = new TcpClient();
        String Message = "";

        public frm_chat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            Thread ListenerThread = new Thread(new ThreadStart(Listening));
            ListenerThread.Start();
            
            
        }

        private void Listening()
        {
            Listener.Start();
            tmr_UpdateListener.Start();
        }

        public void tmr_UpdateListener_Tick(object sender, EventArgs e) 
        {
            if (Listener.Pending())
            {
                Message = "";
            }

            Client = Listener.AcceptTcpClient();
            StreamReader Reader = new StreamReader(Client.GetStream());
            while (Reader.Peek() > -1)
            {
                Message += Convert.ToChar(Reader.Read()).ToString();
            }
            lbox_messages.Items.Add(Message);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tbox_message.Text.Equals("") || tbox_ipaddress.Text.Equals(""))
            {
                MessageBox.Show("Fill in valid Data to send the Message", "Error Sending Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                try
                {
                    Client = new TcpClient(tbox_ipaddress.Text, 65535);
                    StreamWriter Writer = new StreamWriter(Client.GetStream());
                    Writer.Write(tbox_ipaddress.Text + " send:  " + tbox_message.Text);
                    Writer.Flush();
                    lbox_messages.Items.Add("YOU* send:  " + tbox_message.Text);
           
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    String ErrorResult = ex.Message;
                    MessageBox.Show(ErrorResult + "\n" + "Please review Client Address", "Error Sending Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
