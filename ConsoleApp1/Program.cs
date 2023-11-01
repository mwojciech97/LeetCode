using System.Security.Cryptography.X509Certificates;

static string SumMultiplier(int[] arr)
{
    int sum = 0, a = int.MinValue, b = int.MinValue;
    foreach (int i in arr)
    {
        sum += i;
        if (i > a)
        {
            b = a;
            a = i;
        }
        else if (i > b) b = i;
    }
    if (sum * 2 > a * b) return "false";
    else return "true";   
}

int[] arr = { 20, 20, 2, 2, 2, 1 };
Console.WriteLine(SumMultiplier(arr));