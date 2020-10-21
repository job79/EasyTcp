using System;
using System.Text;
using EasyTcp3.EasyTcpPacketUtils;
using EasyTcp3.ServerUtils;

namespace EasyTcp3.Actions.ActionUtils
{
    /// <summary>
    /// Class with SendAllAction functions
    /// </summary>
    public static class SendAllActionUtil
    {
        /// <summary>
        /// Send action (byte[]) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        /// <param name="compression">compress data using Deflate if set to true</param>
        public static void SendAllAction(this EasyTcpServer server, int action, byte[] data = null, bool compression = false)
        {
            if (compression && data != null) data = CompressionUtil.Compress(data);
            server.SendAll(BitConverter.GetBytes(action), data);
        }

        /// <summary>
        /// Send action (byte[]) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        /// <param name="compression">compress data using Deflate if set to true</param>
        public static void SendAllAction(this EasyTcpServer server, string action, byte[] data = null,
            bool compression = false)
            => server.SendAllAction(action.ToActionCode(), data, compression);

        /// <summary>
        /// Send action (ushort) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, int action, ushort data) =>
            server.SendAllAction(action, BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (ushort) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, string action, ushort data) =>
            server.SendAllAction(action.ToActionCode(), BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (short) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, int action, short data) =>
            server.SendAllAction(action, BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (short) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, string action, short data) =>
            server.SendAllAction(action.ToActionCode(), BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (uint) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, int action, uint data) =>
            server.SendAllAction(action, BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (uint) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, string action, uint data) =>
            server.SendAllAction(action.ToActionCode(), BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (int) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, int action, int data) =>
            server.SendAllAction(action, BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (int) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, string action, int data) =>
            server.SendAllAction(action.ToActionCode(), BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (ulong) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, int action, ulong data) =>
            server.SendAllAction(action, BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (ulong) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, string action, ulong data) =>
            server.SendAllAction(action.ToActionCode(), BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (long) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, int action, long data) =>
            server.SendAllAction(action, BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (long) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, string action, long data) =>
            server.SendAllAction(action.ToActionCode(), BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (double) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, int action, double data) =>
            server.SendAllAction(action, BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (double) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, string action, double data) =>
            server.SendAllAction(action.ToActionCode(), BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (bool) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, int action, bool data) =>
            server.SendAllAction(action, BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (bool) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        public static void SendAllAction(this EasyTcpServer server, string action, bool data) =>
            server.SendAllAction(action.ToActionCode(), BitConverter.GetBytes(data));

        /// <summary>
        /// Send action (string) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        /// <param name="encoding">encoding type (Default: UTF8)</param>
        /// <param name="compression">compress data using Deflate if set to true</param>
        public static void SendAllAction(this EasyTcpServer server, int action, string data, Encoding encoding = null,
            bool compression = false)
            => server.SendAllAction(action, (encoding ?? Encoding.UTF8).GetBytes(data), compression);

        /// <summary>
        /// Send action (string) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        /// <param name="encoding">encoding type (Default: UTF8)</param>
        /// <param name="compression">compress data using Deflate if set to true</param>
        public static void SendAllAction(this EasyTcpServer server, string action, string data,
            Encoding encoding = null, bool compression = false)
            => server.SendAllAction(action.ToActionCode(), (encoding ?? Encoding.UTF8).GetBytes(data), compression);
        
        /// <summary>
        /// Send action (IEasyTcpPacket) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code</param>
        /// <param name="data">data to send to connected clients</param>
        /// <param name="compression">compress data using Deflate if set to true</param>
        public static void SendAllAction(this EasyTcpServer server, int action, IEasyTcpPacket data, bool compression = false)
            => server.SendAllAction(action, data.Data, compression);

        /// <summary>
        /// Send action (IEasyTcpPacket) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        /// <param name="compression">compress data using Deflate if set to true</param>
        public static void SendAllAction(this EasyTcpServer server, string action, IEasyTcpPacket data, bool compression = false)
            => server.SendAllAction(action.ToActionCode(), data.Data, compression);
        
        /// <summary>
        /// Send action (object) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        /// <param name="compression">compress data using Deflate if set to true</param>
        public static void SendAllAction(this EasyTcpServer server, int action, object data, bool compression = false)
            => server.SendAllAction(action, server?.Serialize(data),compression);

        /// <summary>
        /// Send action (object) to connected clients
        /// </summary>
        /// <param name="server"></param>
        /// <param name="action">action code as string</param>
        /// <param name="data">data to send to connected clients</param>
        /// <param name="compression">compress data using Deflate if set to true</param>
        public static void SendAllAction(this EasyTcpServer server, string action, object data, bool compression = false)
            => server.SendAllAction(action.ToActionCode(), server?.Serialize(data), compression);
    }
}