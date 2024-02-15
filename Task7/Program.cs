int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = n-1; i>=0; i--)
{
    if ((arr[i]>0 && arr[i-1]>0) || (arr[i]<0 && arr[i-1]<0))
    {
System.Console.WriteLine(arr[i]+" "+arr[i-1]);
        break;
    }
}