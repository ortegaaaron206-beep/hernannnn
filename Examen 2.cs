using System;

class SumaColumnas {
    static void Main() {
        int[,] matriz = new int[3, 3];
        int[] sumaColumnas = new int[3];

        Console.WriteLine("Los valores de la matriz 3x3 porfi:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write("Valor en la posición [" + i + "][" + j + "]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
                sumaColumnas[j] += matriz[i, j];
            }
        }

        for (int j = 0; j < 3; j++) {
            Console.WriteLine("la suma de las columnas " + (j + 1) + ": " + sumaColumnas[j]);
        }
    }
}
