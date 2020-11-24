using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace TCP_Terminal
{
    public class TCP_Client
    {

        // generating object from TcpClient class
        TcpClient client;
        NetworkStream stream;

        public void connect(string IP, int Port)
        {
            try
            {
                client = new TcpClient();
                client.Connect(IP, Port);
                stream = client.GetStream();
                return;
            }
            catch (ObjectDisposedException)
            {
            }
            catch (ArgumentNullException)
            {
            }
            catch (SocketException)
            {
            }
        }

        public void send(string message)
        {
            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();
                try
                {
                    // Send the message to the connected TcpServer.
                    stream.Write(data, 0, data.Length);
                    /*
                    // Buffer to store the response bytes.
                    data = new Byte[256];

                    // String to store the response ASCII representation.
                    String responseData = String.Empty;

                    // Read the first batch of the TcpServer response bytes.
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    */
                    //close stream
                    //stream.Close();
                    return;
                }
                catch (InvalidOperationException)
                {
                }
            }
            catch (ArgumentNullException)
            {
            }
            catch (SocketException)
            {
            }
        }

        public void disconnect()
        {
            try
            {
            client.Close();
            stream.Close();
            }
            catch(NullReferenceException )
            {
                Trace.WriteLine("NullReferenceException");
            }
            return;
        }
    }
}
