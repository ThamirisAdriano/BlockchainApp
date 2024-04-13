using System;

class Program
{
    static void Main(string[] args)
    {
        Blockchain phiCoin = new Blockchain();
        phiCoin.AddBlock(new Block(1, DateTime.Now, phiCoin.Chain[^1].Hash, "Block 1 Data"));
        phiCoin.AddBlock(new Block(2, DateTime.Now, phiCoin.Chain[^1].Hash, "Block 2 Data"));

        foreach (Block block in phiCoin.Chain)
        {
            Console.WriteLine($"Index: {block.Index}");
            Console.WriteLine($"Timestamp: {block.Timestamp}");
            Console.WriteLine($"Previous Hash: {block.PreviousHash}");
            Console.WriteLine($"Hash: {block.Hash}");
            Console.WriteLine($"Data: {block.Data}");
            Console.WriteLine();
        }
    }
}
