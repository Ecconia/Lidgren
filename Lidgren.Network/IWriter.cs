namespace Lidgren.Network
{
    public interface IWriter
    {
        // write methods return IWriter for fluent programming

        // c# types
        IWriter Write(byte d);
        IWriter Write(int d);
        IWriter Write(uint d);
        IWriter Write(short d);
        IWriter Write(ushort d);
        IWriter Write(long d);
        IWriter Write(ulong d);
        IWriter Write(float d);
        IWriter Write(bool d);
        IWriter Write(string d);
    }
}