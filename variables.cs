//Types of Primitive Datas

//Sbyte
using Internal;
using System;

sbyte x = 120;  //Integer numbers between -128 and 127

//Short
short x = 30000;  //Integer numbers between -32767 and 32767

//Int
int x = 2000000000;

//Long
long x = 234440000000000

//Float
float x = 99.99f; // 7 place after point

//Double
double x = 1.5; // 15 place after point

//Decimal
decimal x = 23.567 // 23 place after point

//Boolean
bool s = false;

//Char
char unic = 'A';  //Only used for represent one lyrics

//String
string lt = "Ali Corrales"


class Variables
{
    static void Main(string[] args)
    {
        string va = "The Elements is good";
        string va2 = "ELEMENT";
        string str = "10";
        string str1 = "2";
        string container = va.ToUpper();
        string conta = va2.ToLower();

        int num1 = Int32.Parse(str);
        int num3 = Int32.Parse(str1);
        int sum = num1 + num3;

        Console.WriteLine(container + "  " + sum);
        Console.Read();
    }
}

