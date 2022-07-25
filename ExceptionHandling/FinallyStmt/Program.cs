using System;
using System.IO;
class FinallyDemo
{
    static void Main(string[] args)
    {
        FileStream outStream = null;
        FileStream inStream = null;
        try
        {
            outStream = File.OpenWrite("DestinationFile.txt");
            inStream = File.OpenRead("BogusInputFile.txt");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            if(outStream != null)
            {
                outStream.Close();
                Console.WriteLine("outSteam closed.");
            }
            if (inStream != null)
            {
                inStream.Close();
                Console.WriteLine("inSteam closed.");
            }
        }
    }
}