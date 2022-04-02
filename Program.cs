using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
        byte var1 = 20;
	    short var2 = 56;
	    ushort var3 = 65000;
	    int var4 = 200000;
	    double var5 = 20.01;
	    decimal var6 = 9.2m;
	    char var7 = 'B';
	    bool var8 = true;
	    string var9 = "Wella Health";
	    object var10;

	    //Examples of explicit and implicit type conversion
	    int var6Int = (int)var6; // Explicit
	    dynamic var4New = var4; // Implicit
        }
    }
}
