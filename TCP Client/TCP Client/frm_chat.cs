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
        TcpListener Listener = new TcpListener(IPAddress.Any, 65535);
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

        private void tmr_UpdateListener_Tick(object sender, EventArgs e)
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

                } catch (Exception ex)
                {

                }
            }
        }

    //    Private Sub btn_send_Click(sender As Object, e As EventArgs)
    //    If txt_message.Text = "" Or txt_ipaddress.Text = "" Then
    //        MessageBox.Show("Fill in valid Data to send the Message", "Error Sending Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    //    Else
    //        Try
    //            Client = New TcpClient(txt_ipaddress.Text, 65535)

    //            Dim Writer As New StreamWriter(Client.GetStream())

    //            Writer.Write(txt_ipaddress.Text & " send:  " & txt_message.Text)
    //            Writer.Flush()

    //            lbox_messages.Items.Add(" YOU* send:  " & txt_message.Text)
    //        Catch ex As Exception
    //            Console.WriteLine(ex)
    //            Dim ErrorResult As String = ex.Message
    //            MessageBox.Show(ErrorResult & vbCrLf & vbCrLf & "Please review Client Address", "Error Sending Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    //        End Try
    //    End If
    //End Sub
    }
}
