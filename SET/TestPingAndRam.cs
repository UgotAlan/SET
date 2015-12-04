namespace SET
{
    using System.Net.NetworkInformation;

    /// <summary>
    /// TestPingAndRam tests ping and available memory
    /// </summary>
    public class TestPingAndRam
    {
        /// <summary>
        /// CheckPingAndRam pings www.google.com and gets available memory and returns true if they are in specifications
        /// </summary>
        /// <param name="max_ping">max_ping is the maximum acceptance for ping result</param>
        /// <param name="ip">IP = www.google.com</param>
        /// <returns>boolean true if pass and false if fail</returns>
        public bool CheckPing(long max_ping, string ip)
        {
            Ping p = new Ping();
            long ping_result;

            try
            {
                ping_result = p.Send(ip).RoundtripTime;
            }
            catch
            {
                return false;
            }

            if (ping_result < max_ping)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckRam(double availableRam)
        {
            if (availableRam > 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}