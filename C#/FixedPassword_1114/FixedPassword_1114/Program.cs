using System;

class URI {

    static void Main(string[] args) {

        while (true) {

            int input = int.Parse(Console.ReadLine());

            if (input != 2002) Console.WriteLine("Senha Invalida");
            else { Console.WriteLine("Acesso Permitido"); break; }

        }

    }

}