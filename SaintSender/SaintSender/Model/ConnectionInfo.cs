namespace SaintSender.Model
{
    /// <summary>
    /// Stores all relevant info for establishing a connection.
    /// </summary>
    internal class ConnectionInfo
    {
        public string Hostname { get; set; }
        public uint Port { get; set; }
    }
}