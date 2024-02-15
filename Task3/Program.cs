int big=-9999999;
int ibig=0;
int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if(arr[i]>big)
{
    big=arr[i];
ibig=i;
}
}
System.Console.Write(ibig);