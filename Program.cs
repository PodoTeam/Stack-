using System;
namespace Stack_Verificador_Ecuacion
{
    class Stack
    {
        private int tope;
        public Stack(int[] pila)
        {
            Console.WriteLine(pila.Length);
            for (int i = 0; i < pila.Length; i++)
            {
                pila[i] = 0;
                tope = -1;
            }
        }
        public void Push(int[] pila, int a)
        {
            pila[tope + 1] = a;
            tope += 1;
        }
        public int Pop(int[] pila)
        {
            int aux;
            aux = pila[tope];
            pila[tope] = 0;
            tope -= 1;
            return aux;
        }
        public void Imprimir(int[] pila)
        {
            for (int i = 0; i <= tope; i++)
            {
                Console.WriteLine(pila[i]);
            }
            Console.WriteLine("Esto es todo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, d = 0;
            Console.WriteLine("Ingrese la longitud de su pila");
            a = int.Parse(Console.ReadLine());
            int[] Longitud_Pila = new int[a];
            Stack Pila = new Stack(Longitud_Pila);
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Ingrese los elementos {0}", i + 1);
                Pila.Push(Longitud_Pila, int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Cuantos datos desea retirar");
            d = int.Parse(Console.ReadLine());
            for (int i = 0; i < d; i++)
            {
                Pila.Pop(Longitud_Pila);
            }
            Pila.Imprimir(Longitud_Pila);
        }
    }
}
