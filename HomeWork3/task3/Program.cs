int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [N];
int num = 1;


for (int i = 0; i < N; i++)
{
    arr[i] = num * num * num;
    Console.Write(arr[i] + " ");
    num++;
}

