Double a,k=0,s=0;
string n;
Console.Clear();
Console.Write("Введите числовое значение:");
n=Console.ReadLine();
a=Convert.ToDouble(n);
while (a!=0)
{
    if (a>99 && a<1000)  // НЕСМОГ НАЙТИ КАК ЗАПИСАТЬ 2 УСЛОВИЯ В ЦИКЛ (ПРОГРАММА НЕ РАБОТАЕТ)
    {
        s=s+a;
        k=k+1;
        Console.WriteLine("Введите числовое значение:");
    }
     n=Console.ReadLine();
     a=Convert.ToDouble(n);
}
if (k>0) Console.Write(s/k);
else Console.Write("No");
