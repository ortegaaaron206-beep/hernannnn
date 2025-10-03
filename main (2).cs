using System;

class BuscarValor3D {
    static void Main() {
        int[,,] cubo = new int[3, 3, 3];
        bool encontrado = false;

        Console.WriteLine("Pon los valores para el cubo de 3x3x3:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                for (int k = 0; k < 3; k++) {
                    Console.Write("El valor en la posicion [" + i + "][" + j + "][" + k + "]: ");
                    cubo[i, j, k] = int.Parse(Console.ReadLine());
                }
            }
        }

        Console.Write("Que valor se te perdio: ");
        int buscado = int.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                for (int k = 0; k < 3; k++) {
                    if (cubo[i, j, k] == buscado) {
                        Console.WriteLine("El valor se encuentra en [" + i + "][" + j + "][" + k + "] pa que no se te olvide");
                        encontrado = true;
                    }
                }
            }
        }

        if (!encontrado) {
            Console.WriteLine("No pusiste ese valor dentro del cubo");
        }
    }
}