using System;

namespace HelloWorldApp {
    class Geeks {
        static void Main(string[] args) {

            double largura = 0;
            double comprimento = 0;
            double area = 0;

            Console.WriteLine("Calcular a area do terreno");

            Console.WriteLine("Insira o valor da largura do terreno");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor do comprimento do terreno");
            comprimento = Convert.ToDouble(Console.ReadLine());

            if (largura == comprimento){
                Console.WriteLine("Erro: Terreno nao retangular");
            }
           
           else {
            area = largura * comprimento;
            Console.WriteLine("Area do terreno: " + area.ToString());
            Console.ReadLine();
        }
    }
}
}