using System;
using System.Security.Cryptography;
using System.Text;

public class Block
{
    public int Index { get; set; }
    public DateTime Timestamp { get; set; }
    public string Data { get; set; }
    public string PreviousHash { get; set; }
    public string Hash { get; set; }

    public Block(int index, DateTime timestamp, string previousHash, string data)
    {
        Index = index;
        Timestamp = timestamp;
        Data = data;
        PreviousHash = previousHash;
        Hash = CreateHash();
    }

    public string CreateHash()
{
    using (SHA256 sha256 = SHA256.Create())
    {
        string rawData = $"{Index}{Timestamp}{PreviousHash}{Data}";
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
        return BitConverter.ToString(bytes).Replace("-", "");
    }
}
}
