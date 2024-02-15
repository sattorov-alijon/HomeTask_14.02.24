int sum=1;
int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    System.Console.Write(arr[i]+"*");
sum=sum*arr[i];
}
System.Console.Write("="+sum);