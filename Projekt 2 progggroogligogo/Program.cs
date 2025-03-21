
using System.Globalization;

List<string> fiender = ["farmoder","sorkMästare", "kebabMannen"];

int vilkenFiende = 0;

Motståndare du = new(){
Hp = 150,
skada = [30, 40, 50 ],
attacker = ["Drake","Dissa", "Bingufy"]
};

Motståndare farmor = new(){
Hp = 200,
skada = [20, 30, 40 ],
attacker = ["godis","löstandshugg", "shotgun"]
};


Motståndare sorkMästaren = new() {
Hp = 120,
skada = [10,20,Random.Shared.Next(1,50)],
attacker = ["gnaga", "sorkattack", "digerdöden"]
};


Motståndare kebabMan =new() {
Hp = 150,
skada = [20, Random.Shared.Next(5,40), 50],
attacker = ["kebabspett", "köttklump", "bepsi"]  
};

int kebabrulle = 2;
int energidricka = 40;


Console.WriteLine("                                                      Bertils Liv");
Console.WriteLine("""
                            __________               __  .__.__    ___.                 
                            \______   \ ____________/  |_|__|  |   \_ |__   ____ ___.__.
                             |    |  _// __ \_  __ \   __\  |  |    | __ \ /  _ <   |  |
                             |    |   \  ___/|  | \/|  | |  |  |__  | \_\ (  <_> )___  |
                             |______  /\___  >__|   |__| |__|____/  |___  /\____// ____|
                                    \/     \/                           \/       \/    
""");

while(true){
    Console.WriteLine("Är du redo att börja");
    string svar = Console.ReadLine();
    textMellanrum();
    if(svar.ToLower() == "ja"){
        break;
    }
    else if(svar.ToLower() == "nej"){
        Console.WriteLine("Okej hejdå, skriv in vad som helst för att avsluta");
        textMellanrum();
        Console.WriteLine("Bye bye");
        Console.ReadLine();
        Environment.Exit(0);
    }
    else{
        Console.WriteLine("Testa igen!");
        textMellanrum();
    }
}

Console.WriteLine("Ditt namn är Bertil");
textMellanrum();
Console.WriteLine("Du vaknar upp en vanlig morgon och dricker kaffe. Du går sedan ut");
textMellanrum();
Console.WriteLine("Du är extremt sugen på en korvmacka, så du börjar gå emot Abdis korvgrill.");
textMellanrum();
Console.WriteLine("När du står och väntar i kön, märker du hur en gammal farmor håller på att försöka tränga sig.");

Console.WriteLine("Alternativ 1, slåss mot farmor så att hon skärper sig.");
Console.WriteLine("Alternativ 2, låta farmor tränga sig så att du får din korvmacka långsammare.");
textMellanrum();
Console.WriteLine("Vilket väljer du?");

while(true){
    Console.WriteLine("Vilket väljer du? Alternativ 1, besegra farmor eller alternativ 2, vänta i kön?");
    string farmorVal = Console.ReadLine();
    int.TryParse( farmorVal, out int farmorValNum);

    if(farmorValNum == 1){
        textMellanrum();
        Console.WriteLine("Du väljer att slåss mot farmor!");
        motståndareStrid(vilkenFiende, fiender ,farmor.Hp, du.Hp, farmor.skada, du.skada, farmor.attacker,du.attacker, kebabrulle, energidricka);
        vilkenFiende ++;
    }
    else if(farmorValNum == 2){
        textMellanrum();
        Console.WriteLine("Du väljer att låta farmor tränga sig, vilket leder till att du får din korvmacka långsammare.");
        if(slumpa() == 2){
            textMellanrum();
            System.Console.WriteLine("Hon knuffar dig våldsamt, du förlorar 2 hp!");
            du.Hp -= 2;
        }
        break;
    }
    else{
        textMellanrum();
        System.Console.WriteLine("Testa igen");
        textMellanrum();
    }
}

Console.ReadLine();









static void textMellanrum() {
    Thread.Sleep(1000);
}




static int motståndareStrid(int vilkenFiende, List<string> fiender, int hälsa, int dinHälsa, List<int> skada, List<int> dinaSkador, List<string> attacker, List<string> dinaAttacker, int kebabrulle, int energidricka) {

while (dinHälsa > 0 || hälsa > 0 ){
System.Console.WriteLine($"Du har tillgång till 3 attacker");
for (int i = 0; i < dinaAttacker.Count; i++)
{
    System.Console.WriteLine($"{dinaAttacker[i]} gör {dinaSkador} i skada");
    textMellanrum();
}
while(true){
    System.Console.WriteLine("Vilken attack vill du använda. SKriv 1 till 3.");
    string attackVal = Console.ReadLine();
   bool attackBool = int.TryParse(attackVal, out int attackValNum );
    if(attackBool == true){
        System.Console.WriteLine(" bra jobbat");
        textMellanrum();
        break;
    }
    else if(attackValNum >)

}




System.Console.WriteLine($"{fiender[vilkenFiende]} attackerar med {attacker[slumpa()]} och gör {skada[slumpa()]} i skada");
dinHälsa -= skada[slumpa()];


}
return dinHälsa;

}


static int slumpa(){
    int slump = Random.Shared.Next(1,4);
    return slump;
}