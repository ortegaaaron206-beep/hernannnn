using System;

class ConteoParesImpares {
    static void Main() {
        int[] numeros = new int[10];
        int pares = 0, impares = 0;

        Console.WriteLine("10 valores por favor:");
        for (int i = 0; i < 10; i++) {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0) {
                pares++;
            } else {
                impares++;
            }
        }

        Console.WriteLine("Estos son pares: " + pares);
        Console.WriteLine("Estos son impares: " + impares);
    }
}