

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
int energidricka = 80;


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
textMellanrum();
Console.WriteLine("Alternativ 1, slåss mot farmor så att hon skärper sig.");
textMellanrum();
Console.WriteLine("Alternativ 2, låta farmor tränga sig så att du får din korvmacka långsammare.");
textMellanrum();


while(true){
    textMellanrum();
    Console.WriteLine("Vilket väljer du? Alternativ 1, besegra farmor eller alternativ 2, vänta i kön?");
    string farmorVal = Console.ReadLine();
    int.TryParse( farmorVal, out int farmorValNum);

    if(farmorValNum == 1){
        textMellanrum();
        Console.WriteLine("Du väljer att slåss mot farmor!");
        motståndareStrid(vilkenFiende, fiender ,farmor.Hp, du.Hp, farmor.skada, du.skada, farmor.attacker,du.attacker, energidricka,kebabrulle);
        vilkenFiende ++;
        död(du.Hp);
        break;
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

textMellanrum();
System.Console.WriteLine("Du får din korvmacka och går vidare");
textMellanrum();
System.Console.WriteLine("Påväg hemåt igen träffar du Sorkmästaren som av någon anledning vill sno din smörgås. Vad gör du?");
textMellanrum();
System.Console.WriteLine(@"Alternativ 1, slåss mot sorkmästaren så att han inte tar din macka.
Alternativ 2, ge mackan till Sorkmästaren så att han drar därifrån."
);
int sorkValNum;
while(true){
    textMellanrum();
    System.Console.WriteLine("Vad gör du, skriv 1 eller 2.");
    string sorkVal = Console.ReadLine();
    int.TryParse(sorkVal, out sorkValNum);

    if(sorkValNum == 1){
        textMellanrum();
        Console.WriteLine("Du väljer att slåss mot Sorkmästaren!");
        motståndareStrid(vilkenFiende, fiender ,sorkMästaren.Hp, du.Hp, sorkMästaren.skada, du.skada, sorkMästaren.attacker,du.attacker, energidricka,kebabrulle);
        vilkenFiende ++;
        död(du.Hp);
        break;  
    }
    else if(sorkValNum == 2){
        textMellanrum();
        Console.WriteLine("Du väljer att ge din korvmacka till Sorkmästaren.");
        if(slumpa() == 2){
            textMellanrum();
            System.Console.WriteLine("Han biter din tå, du förlorar 3 hp!");
            du.Hp -= 3;
        }
        break;
    }
    else{  
        textMellanrum();
        System.Console.WriteLine("Testa igen");
        textMellanrum();
        } 
}

textMellanrum();
if(sorkValNum == 2){
    System.Console.WriteLine("Du förlorar din macka.");
}
else{
    System.Console.WriteLine("Du äter upp din macka.");
}

textMellanrum();


Console.ReadLine();









static void textMellanrum() {
    Thread.Sleep(1500);
}





static int motståndareStrid(int vilkenFiende, List<string> fiender, int hälsa, int dinHälsa, List<int> skada, List<int> dinaSkador, List<string> attacker, List<string> dinaAttacker, int energidricka, int kebabrulle) {

int slumptal = slumpa();

while (dinHälsa > 0 || hälsa > 0 ){
System.Console.WriteLine($"Du har tillgång till 3 attacker");

for (int i = 0; i < dinaAttacker.Count; i++)
{
    System.Console.WriteLine($"{dinaAttacker[i]} gör {dinaSkador[i]} i skada");
    textMellanrum();
}

int attackValNum;

while(true){
    System.Console.WriteLine("Vilken attack vill du använda. SKriv 1 till 3. Eller powerup");
    string Val = Console.ReadLine();

    if (Val.ToLower() == "powerup"){
        textMellanrum();
        System.Console.WriteLine("Kebabrulle eller energidricka?");
        string kraftUpp = Console.ReadLine();
        
        if(kraftUpp.ToLower() == "kebabrulle"){
            System.Console.WriteLine("Du valde kebabrulle");
            kebab(dinaSkador,kebabrulle,dinaAttacker);
        }

        else if(kraftUpp.ToLower() == "energidricka"){
            textMellanrum();
            System.Console.WriteLine("Du valde energidricka");
            energidryck(dinHälsa,energidricka);
            dinHälsa += skada[slumptal];
        }
    }
    
    bool attackBool = int.TryParse(Val, out attackValNum );


    if(attackBool == false){
        System.Console.WriteLine("skriv 1 2 eller 3!");
        textMellanrum();
    }
    else if(attackValNum > 3){
        System.Console.WriteLine("skriv högst 3!");
        textMellanrum();
    }
    else if (attackValNum < 1){
        System.Console.WriteLine("Skriv minst 1!");
        textMellanrum();
    }
    else{
        System.Console.WriteLine($"Bra jobbat! du tog {attackValNum}.");
        attackValNum--;
        textMellanrum();
        break;
    }
    
}

System.Console.WriteLine($"Du använder {dinaAttacker[attackValNum]} och gör {dinaSkador[attackValNum]}!");
hälsa -= dinaSkador[attackValNum];



System.Console.WriteLine($"{fiender[vilkenFiende]} attackerar med {attacker[slumptal]} och gör {skada[slumptal]} i skada");
dinHälsa -= skada[slumpa()];

System.Console.WriteLine($"Farmor har {hälsa} hp kvar!");
System.Console.WriteLine($"Du har {dinHälsa} hp kvar!");

if(dinHälsa <= 0){
    textMellanrum();
    System.Console.WriteLine("Du dog!");
    return dinHälsa;
}
else if(hälsa <= 0){
    textMellanrum();
    System.Console.WriteLine($"Du dödade {fiender[vilkenFiende]}");
    return dinHälsa;
}

Console.ReadLine();
if(dinaSkador[0] > 30 || dinaSkador[1] > 40 || dinaSkador[2] > 50){

for (int i = 0; i < dinaSkador.Count; i++)
{
    dinaSkador[i] /= kebabrulle;
}

dinHälsa += skada[slumptal];

}


}


return dinHälsa;

}







static int slumpa(){

    int slump = Random.Shared.Next(0,3);
    return slump;
}


static void energidryck(int dinHälsa, int energidricka) {
    System.Console.WriteLine($"Du dricker en energidricka och återfår {energidricka} i hp.");
    dinHälsa += energidricka;
}

static List<int> kebab( List<int> dinaSkador, int kebabrulle, List<string> dinaAttacker) {
    for (int i = 0; i < dinaSkador.Count; i++)
    {
        dinaSkador[i] *= kebabrulle;
        textMellanrum();
        System.Console.WriteLine($"{dinaAttacker[i]} gör nu {dinaSkador[i]} i skada!");
    }
    return dinaSkador;

}


static void död(int dinHälsa) {
    if(dinHälsa <= 0){
        System.Console.WriteLine("Du är död, skriv vad som heslt för att avsluta.");
        Environment.Exit(0);
    }
}