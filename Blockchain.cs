using System.Collections.Generic;
using System.Linq;

public class Blockchain
{
    public IList<Block> Chain { get; set; } = new List<Block>();

    public Blockchain()
    {
        InitializeChain();
        AddGenesisBlock();
    }

    private void InitializeChain()
    {
        Chain = new List<Block>();
    }

    private void AddGenesisBlock()
    {
        Chain.Add(new Block(0, DateTime.Now, "0", "Genesis Block"));
    }

    public void AddBlock(Block block)
    {
        Block latestBlock = Chain.Last();
        block.Index = latestBlock.Index + 1;
        block.PreviousHash = latestBlock.Hash;
        block.Hash = block.CreateHash();
        Chain.Add(block);
    }
}
