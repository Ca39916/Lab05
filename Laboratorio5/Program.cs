using System;
using System.Drawing;

namespace Laboratorio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Console.WriteLine("");

            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            //exibindo as propriedades do objeto circulo
            Console.WriteLine("Propriedade do CentroX " + circ2.CentroX);
            Console.WriteLine("Propriedade do CentroY " + circ2.CentroY);
            Console.WriteLine("Propriedade do Raio " + circ2.Raio);
            Console.WriteLine("");

            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            Console.WriteLine("");

            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);
            Console.ReadKey();
            //exibindo as propriedades do objeto CirculoColorido
            Console.WriteLine("Propriedade do CentroX " + circ4.CentroX);
            Console.WriteLine("Propriedade do CentroY " + circ4.CentroY);
            Console.WriteLine("Propriedade do Raio " + circ4.Raio);
            Console.WriteLine("Propriedade da Cor " + circ4.Cor);

            Console.WriteLine("");
            Console.WriteLine("-----Exercício 5.2 -----");
            CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido(1.5, 3.0, 2.1,"Pink", Color.Aqua); 
            Console.WriteLine(circ5);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("-----Exercício 5.3 -----");
            Circulo[] arrcirc = new Circulo[4];
            arrcirc[0] = new CirculoColorido(2,1,3,"Verde");
            arrcirc[1] = new CirculoColorido(5, 7, 9, "Azul");
            arrcirc[2] = new CirculoColoridoPreenchido(2,9,7,"Amarelo",Color.Azure);
            arrcirc[3] = new CirculoColoridoPreenchido();
            for (int i = 0; i < arrcirc.Length; i++)
            {
                Console.WriteLine(arrcirc[i]);
            }


        }
    }
}
