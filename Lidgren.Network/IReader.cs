namespace Lidgren.Network
{
    public interface IReader
    {
        // c# types
        byte ReadByte();
        int ReadInt32();
        uint ReadUInt32();
        short ReadInt16();
        ushort ReadUInt16();
        long ReadInt64();
        ulong ReadUInt64();
        float ReadFloat();
        bool ReadBoolean();
        string ReadString();
    }
}