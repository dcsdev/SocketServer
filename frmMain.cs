using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;


namespace FunsWIthSockets
{
    public partial class frmMain : Form
    {
        SocketPermission permToUseAddressPort;
        Socket socketListener;
        IPEndPoint ipEndPoint;
        Socket handler;
        Int32 ipPort = 10001;
        private Socket senderSock;

        byte[] bytes = new byte[1024]; 

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            socketListener.Listen(10);
            AsyncCallback aCallback = new AsyncCallback(AcceptCallback);
            socketListener.BeginAccept(aCallback, socketListener);
            btnStartListening.Enabled = false;
            txtMessages.Text = String.Format("Socket Server Is Listening at IP Address {0} and Port {1}", ipEndPoint.Address.MapToIPv4().ToString(), ipPort);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            Socket listener = null;

            Socket handler = null;
            try
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    this.txtMessages.Text = "Server is now listening on " + ipEndPoint.Address + " port: " + ipEndPoint.Port; 
                }));

                byte[] buffer = new byte[1024];
                listener = (Socket)ar.AsyncState;
                handler = listener.EndAccept(ar);

                handler.NoDelay = false;

                object[] obj = new object[2];
                obj[0] = buffer;
                obj[1] = handler;

                handler.BeginReceive(
                    buffer,        
                    0,             
                    buffer.Length, 
                    SocketFlags.None,
                    new AsyncCallback(ReceiveCallback),
                    obj            
                    );

                AsyncCallback aCallback = new AsyncCallback(AcceptCallback);
                listener.BeginAccept(aCallback, listener);
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                object[] obj = new object[2];
                obj = (object[])ar.AsyncState;

                byte[] buffer = (byte[])obj[0];

                handler = (Socket)obj[1];

                string content = string.Empty;

                int bytesRead = handler.EndReceive(ar);

                if (bytesRead > 0)
                {
                    content += Encoding.Unicode.GetString(buffer, 0,
                        bytesRead);

                    if (content.IndexOf("<####>") > -1)
                    {
                        string str = content.Substring(0, content.LastIndexOf("<####>"));

                        this.Invoke(new MethodInvoker(delegate()
                        {
                            this.txtMessages.Text = "Read " + str.Length * 2 + " bytes from client.\n Data: " + str;
                        }));

                    }
                    else
                    {
                        byte[] buffernew = new byte[1024];
                        obj[0] = buffernew;
                        obj[1] = handler;
                        handler.BeginReceive(buffernew, 0, buffernew.Length,
                            SocketFlags.None,
                            new AsyncCallback(ReceiveCallback), obj);
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtMessagesToSend.Text;
                byte[] byteData = Encoding.Unicode.GetBytes(str);
                handler.BeginSend(byteData, 0, byteData.Length, 0,new AsyncCallback(SendCallback), handler);
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket handler = (Socket)ar.AsyncState;
                int bytesSend = handler.EndSend(ar);
                this.Invoke(new MethodInvoker(delegate()
                {
                    this.txtMessages.Text = String.Format("Sent {0} bytes to Client", bytesSend);
                }));

                
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopListeningForConnections();
        }

        private void btnStopListening_Click(object sender, EventArgs e)
        {
            StopListeningForConnections();
        }

        private void StopListeningForConnections()
        {
            try
            {
                if (socketListener.Connected)
                {
                    socketListener.Shutdown(SocketShutdown.Receive);
                    socketListener.Close();
                }

                btnStopListening.Enabled = false;

                txtMessages.Text = "No Longer Listening For Connections";
            }
            catch (Exception exc) 
            { 
                MessageBox.Show(exc.ToString()); 
            }
        }

        private void btnCreateSocketServer_Click(object sender, EventArgs e)
        {
            try
            {
                permToUseAddressPort = new SocketPermission(
                NetworkAccess.Accept,     
                TransportType.Tcp,        
                "",                       
                SocketPermission.AllPorts 
                );
                
                
                socketListener = null;

                
                permToUseAddressPort.Demand();

                
                IPHostEntry ipHost = Dns.GetHostEntry("");

                
                IPAddress ipAddr = ipHost.AddressList[0];

                
                ipEndPoint = new IPEndPoint(ipAddr, ipPort);

                
                socketListener = new Socket(
                    ipAddr.AddressFamily,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );

                
                socketListener.Bind(ipEndPoint);

                txtMessages.Text = "Socket Server Created...";

                btnCreateSocketServer.Enabled = false;
                btnStartListening.Enabled = true;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

       

        
    }
}
