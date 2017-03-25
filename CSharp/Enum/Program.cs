using System;
using System.Text;

enum Color { red, blue, green }

class Test
{

    static string ReadString()
    {
        StringBuilder b = new StringBuilder();
        int c = Console.Read();
        while (0 <= c && c < ' ') c = Console.Read();
        while (c >= ' ')
        {
            b.Append((char)c);
            c = Console.Read();
        }
        return b.ToString();
    }

    /// Read an enumeration value of type t from the console
    static object ReadEnum(Type t)
    {
        string s = ReadString();
        if (s == null || s == "") return null;
        else return Enum.Parse(t, s);
    }

    /// Write an enumeration value obj to the console
    static void WriteEnum(object obj)
    {
        Console.Write(obj.ToString());
    }

    public static void Main()
    {
        try
        {
            for (;;)
            { // terminate when an invalid enumeration value is entered
                Console.Write('>');
                Color col = (Color)ReadEnum(typeof(Color));
                WriteEnum(col);
                Console.WriteLine();
            }
        }
        catch (Exception)
        {
        }
    }
}
