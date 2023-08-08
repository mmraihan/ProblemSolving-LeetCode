
int[] input = { 1, 2, 3 };
int[] output = SquareElements(input);

Console.Write(string.Join(",",output));

Console.WriteLine();



static int[] SquareElements(int[] input)
{
    int[] output = new int[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        output[i] = input[i] * input[i];
    }

    return output;
}