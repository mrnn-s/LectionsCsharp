

//vid 1
void Method1()
{
    Console.WriteLine("autor sarkisian");
}

//Method1();

//vid2

void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(msg: "aytor");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
//Method21("autor, 4");
//Method21(count: 4, msg: "autor made this");

//vid3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//vid4
string Method4 (int count, string text)
{
string res = String.Empty;
for (int i =0; i<count;i++)
{
    res = res + text;
}
return res;
}
string res2 = Method4(10, "sarkisian");
Console.WriteLine(res2);