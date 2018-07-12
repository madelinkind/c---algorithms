﻿using System;
using System.Collections.Generic;

namespace programming_solutions
{
    static class Semana3
    {
        public static void Mayor()
        {
            Console.Write("Teclea un primer numero ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("Teclea un segundo numero ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Teclea un tercer numero ");
            int m = int.Parse(Console.ReadLine());

            if ((j >= k) && (j >= m))
                Console.WriteLine("El mayor es {0}", j);
            else if ((k >= j) && (k >= m))
                Console.WriteLine("El mayor es {0}", k);
            else
                Console.WriteLine("El mayor es {0}", m);

            Console.Read();
        }
        public static void Speed()
        {
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Teclee su nombre?");

            crono.Start();
            string name = Console.ReadLine();
            crono.Stop();

            int charactersCount = name.Length;
            double elapsedSeconds = crono.ElapsedMilliseconds / 1000.0;
            double charactersPerSecond = charactersCount / elapsedSeconds;

            if (charactersPerSecond > 2)
                Console.WriteLine("Usted es rápido");
            else if (charactersPerSecond >= 1 && charactersPerSecond <= 2)
                Console.WriteLine("Usted es regular");
            else
                Console.WriteLine("Usted es lento");

            //            Console.Read();
        }

        public static void FastName()
        {
            Stopwatch crono = new Stopwatch();
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            Console.WriteLine("Teclee su nombre tres veces?");

            crono.Start();
            string firstName = Console.ReadLine();
            crono.Stop();

            crono1.Start();
            string secondtName = Console.ReadLine();
            crono1.Stop();

            crono2.Start();
            string thirdtName = Console.ReadLine();
            crono2.Stop();

            if (firstName == secondtName && secondtName == thirdtName)
            {
                if (crono.ElapsedMilliseconds <= crono1.ElapsedMilliseconds && crono.ElapsedMilliseconds <= crono2.ElapsedMilliseconds)
                    Console.WriteLine("Usted exscribió el primer nombre más rápido");
                else if (crono1.ElapsedMilliseconds <= crono2.ElapsedMilliseconds)
                    Console.WriteLine("Usted exscribió el segundo nombre más rápido");
                else
                    Console.WriteLine("Usted exscribió el tercer nombre más rápido");
            }
            else
                Console.WriteLine("Error, has tecleado mal alguno de los nombres. Vuélva a ejecutar el programa");

            Console.Read();
        }

        public static void TypeTriangle()
        {
            Console.WriteLine("Entre 3 valores enteros");

            int side = int.Parse(Console.ReadLine());
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());

            if (side > 0 && side1 > 0 && side2 > 0)
            {

                if (side == side1 && side == side2)
                    Console.WriteLine("Es un triangulo Equilátero");
                else if (side != side1 && side1 != side2 && side != side2)
                    Console.WriteLine("Es un triángulo Escaleno");
                else
                    Console.WriteLine("Es un triángulo Isósceles");
            }

            else
                Console.WriteLine("No es posible formar un triángulo");

            Console.Read();
        }

        public static void OrderAvrg()
        {
            float average = 0;
            Console.WriteLine("Entre 3 valores enteros a ordenar");

            int value = int.Parse(Console.ReadLine());
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());

            if (value <= value1 && value <= value2)
            {
                if (value1 <= value2)
                    Console.WriteLine("{0},{1},{2}", value, value1, value2);
                else
                    Console.WriteLine("{0},{1},{2}", value, value2, value1);
            }
            else if (value1 <= value && value1 <= value2)
            {
                if (value <= value2)
                    Console.WriteLine("{0},{1},{2}", value1, value, value2);
                else
                    Console.WriteLine("{0},{1},{2}", value1, value2, value);
            }
            else if (value2 <= value && value2 <= value1)
            {
                if (value <= value1)
                    Console.WriteLine("{0},{1},{2}", value2, value, value1);
                else
                    Console.WriteLine("{0},{1},{2}", value2, value1, value);
            }

            average = (value + value1 + value2) / 3;
            Console.WriteLine("{0}", average);
            Console.Read();
        }

        public static void PrimeNumber()
        {

            Console.WriteLine("Entre un número que se encuentre en el rango del 1 al 100");
            int valor = int.Parse(Console.ReadLine());
            if (valor >= 1 && valor <= 100)
            {
                int rest = valor % 2;
                if (rest != 0)
                    Console.WriteLine("El número es primo");
                else
                    Console.WriteLine("El número no es primo");
            }
            else
                Console.WriteLine("Error, entró un número fuera del rango indicado. Vuelva a ejecutar el programa.");
            Console.Read();
        }

        public static void NextDay()
        {
            Console.WriteLine("Entre una fecha");

            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            if ((day >= 1 && day <= 31) && (month >= 1 && month <= 12) && (year >= 1880 && year <= 2045))
            {
                Console.WriteLine("El día siguiente es: {0}-{1}-{2}", day + 1, month, year);
            }
            else
                Console.WriteLine("Error, entre correctamente una fecha");
        }
    }
}