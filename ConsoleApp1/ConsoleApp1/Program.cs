using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IPavyzdys
    {
        void Metodas();

        int Popertis { get; set; }
    }

    internal class Paveldi : IPavyzdys
    {
        public int Popertis { get; set; }

        public void Metodas()
        {
        }
    }

    internal interface IClient
    {
        void Connect();

        void Disconnect();

        void SendData(string data);
    }

    internal class PrepareDataToBeSend
    {
        private IClient client; //Globalus visai klasei

        public PrepareDataToBeSend(IClient cl)
        {
            // cl lokaliai naudojamas tik konstruktoriuje
            client = cl;
        }

        public void ParseAndSendData(char[] data)
        {
            client.SendData(data.ToString());
        }
    }

    internal class HttpClient : IClient
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void SendData(string data)
        {
            throw new NotImplementedException();
        }
    }

    internal class SocketClient : IClient
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void SendData(string data)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            IPavyzdys pavyzdys = new Paveldi();

            SocketClient sokcet = new SocketClient();
            PrepareDataToBeSend data = new PrepareDataToBeSend(sokcet);
        }
    }
}