var arr = new int[] {1,2,3,3,4,4,4,5,6,6,7,7,8,8};

for (int i = 0; i < arr.Length; i++)
{
	for (int j = i+1; j < arr.Length; j++)
	{
		if (arr[i] == arr[j])
		{
			arr[i] = 3;
		}
	}
}
Console.WriteLine("Result");

for (int i = 0; i < arr.Length; i++)
{
	if (arr[i]!=3)
	{
		Console.WriteLine(arr[i]);
	}
}

Console.ReadLine();
