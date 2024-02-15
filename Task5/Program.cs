int min=9999999;
int imin=0;
int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if(arr[i]<min)
{
    min=arr[i];
imin=i;
}
}
System.Console.Write(imin);