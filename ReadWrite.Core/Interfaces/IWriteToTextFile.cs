using ReadWrite.Models;

namespace ReadWrite.Core.Interfaces
{
    public interface IWriteToTextFile
    {
        string WriteToText(string[] employee);
        string ReadTextFile();
        string DeleteFromFile();
    }
}
