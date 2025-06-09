﻿using EspacioCalculadora;

Calculadora miCalcu = new Calculadora();


bool seguir = true;
do
{

    Console.WriteLine("----Menu de operaciones----\n1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Limpiar");

    int opcion = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingresar el numero:");
    int numero = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            miCalcu.Sumar(numero);
            break;
        case 2:
            miCalcu.Restar(numero);
            break;
        case 3:
            miCalcu.Multiplicar(numero);
            break;
        case 4:
            miCalcu.Dividir(numero);
            break;
        case 5:
            break;    
    }
    Console.WriteLine($"Resultado= {miCalcu.Resultado}");

    Console.WriteLine("Desea realizar otra operacion?(1 para seguir|| 0 para parar)");
    int seguirS = int.Parse(Console.ReadLine());
    if (seguirS == 1)
    {
        seguir = true;
    }
    else
    {
        seguir = false;
    }
    
} while (seguir);
