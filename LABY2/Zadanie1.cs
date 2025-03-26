public class Zad1
{
	public Zad1(){ 
	}


		public static void Zadanie1()
	{
        Console.WriteLine("Podaj ciąg liczb oddzielonych spacją do posortowania");
		string bubble_input = Console.ReadLine();

        int[] A = bubble_input.Split(' ').Select(s => int.Parse(s)).ToArray();

		for (int i = 0; i < A.Length; i++)
		{
			for (int j = 0; j < A.Length-1; j++)
			{
				if (A[j] > A[j+1]) {
					int a;
					a = A[j];
					A[j] = A[j + 1];
					A[j + 1] = a;
				}

			}

        }
        Console.WriteLine("posortowany ciąg");
		foreach (int i in A) {
            Console.Write(i + " ");		
		}





    }


	
}
