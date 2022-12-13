using System;

class URI {

    static void Main(string[] args) {

        int nGrenal = 0, interWins = 0, gremioWins = 0, draws = 0;

        for (;;) {

            nGrenal++;

            string[] input = Console.ReadLine().Split();
            int interGoals = int.Parse(input[0]), gremioGoals = int.Parse(input[1]);

            if (interGoals > gremioGoals) interWins++;
            else if (gremioGoals > interGoals) gremioWins++;
            else draws++;

            int option;

            do {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                option = int.Parse(Console.ReadLine());
            } while (option != 1 && option != 2);

            if (option == 2) break;

        }

        Console.WriteLine(
            $"{nGrenal} grenais\n" +
            $"Inter:{interWins}\n" +
            $"Gremio:{gremioWins}\n" +
            $"Empates:{draws}");

        if (interWins > gremioWins) Console.WriteLine("Inter venceu mais");
        else if (gremioWins > interWins) Console.WriteLine("Gremio venceu mais");
        else Console.WriteLine("Não houve vencedor");

    }

}