﻿internal class Sample
{
    protected static int origRow;
    protected static int origCol;

    protected static void WriteAt(string s, int x, int y)
    {
        try
        {
            Console.SetCursorPosition(origCol + x, origRow + y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }
}