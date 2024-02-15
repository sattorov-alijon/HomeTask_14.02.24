int n=Convert.ToInt32(Console.ReadLine());
if (n<100)
{
 n=n+n*5/100;
 System.Console.WriteLine(n);   
}
else if(n>99 && n<200)
{
 n=n+n*7/100;
 System.Console.WriteLine(n);   
}
else
{
    n=n+n*1/10;
 System.Console.WriteLine(n);   
}