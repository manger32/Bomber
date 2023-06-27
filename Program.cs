using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

/**namespace Server_In_Out
{
    private class AllJpgs
    {
        int JpgNumber;
        string dataPath;
        AllJpgs(int New_Jpg_Count, string New_Bomber_Folder)
        {
            JpgNumber = New_Jpg_Count;
            dataPath = New_Bomber_Folder;
        }
    }
}**/
string pattern = @"([a-zA-Z]*:[\\[a-zA-Z0-9 .]*]*)";
using (FileStream fs = File.OpenRead(@"./Try.txt"))
{
    byte[] b = new byte[1024];
    UTF8Encoding temp = new UTF8Encoding(true);
    while (fs.Read(b,0,b.Length) > 0)
    {
        string s = temp.GetString(b);
        Console.WriteLine(s);
        if (Regex.IsMatch(s, pattern))
        {
            Console.WriteLine("We Found a Data Path! ");
        }
    }
}



/* IPHostEntry ipHostInfo = await Dns.GetHostEntryAsync("host.contoso.com");
IPAddress ipAddress = ipHostInfo.AddressList[0];


using Socket client = new(
    ipEndPoint.AddressFamily, 
    SocketType.Stream, 
    ProtocolType.Tcp);

await client.ConnectAsync(ipEndPoint);
while (true)
{
    // Send message.
    var message = "Hi friends 👋!<|EOM|>";
    var messageBytes = Encoding.UTF8.GetBytes(message);
    _ = await client.SendAsync(messageBytes, SocketFlags.None);
    Console.WriteLine($"Socket client sent message: \"{message}\"");

    // Receive ack.
    var buffer = new byte[1_024];
    var received = await client.ReceiveAsync(buffer, SocketFlags.None);
    var response = Encoding.UTF8.GetString(buffer, 0, received);
    if (response == "<|ACK|>")
    {
        Console.WriteLine(
            $"Socket client received acknowledgment: \"{response}\"");
        break;
    }
    // Sample output:
    //     Socket client sent message: "Hi friends 👋!<|EOM|>"
    //     Socket client received acknowledgment: "<|ACK|>"
}

client.Shutdown(SocketShutdown.Both);
listener.BeginAccept(new AsyncCallback(AcceptCallback), listener); */