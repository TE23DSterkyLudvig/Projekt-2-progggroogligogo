System.Console.WriteLine("Nu kör vi");
Textmellanrum();

HelaKoden();// Koden i en funktion



//innehåller hela huvudkoden
static void HelaKoden(){
    
string[] fiender = ["farmoder","sorkMästare", "kebabMannen"]; // Jag använder array här för att jag inte kommer att ändra innehållet.

int vilkenFiende = 0;

// jag använder min klass kämpe för att skapa alla olika kämpar bland annat spelaren.
kämpe du = new(){
hp = 300,
skada = [30, 40, 50 ],
attacker = ["Drake","Dissa", "Bingufy"]
};

kämpe farmor = new(){
hp = 200,
skada = [20, 30, 40 ],
attacker = ["godis","löstandshugg", "shotgun"]
};


kämpe sorkMästaren = new() {
hp = 120,
skada = [10,20,Random.Shared.Next(1,50)],
attacker = ["gnaga", "sorkattack", "digerdöden"]
};


kämpe kebabMan =new() {
hp = 150,
skada = [20, Random.Shared.Next(5,40), 50],
attacker = ["kebabspett", "köttklump", "bepsi"]  
};

int kebabrulle = 2;
int energidricka = 80;

//Loggan
Console.WriteLine("                                                      Bertils Liv");
Console.WriteLine("""
                            __________               __  .__.__    ___.                 
                            \______   \ ____________/  |_|__|  |   \_ |__   ____ ___.__.
                             |    |  _// __ \_  __ \   __\  |  |    | __ \ /  _ <   |  |
                             |    |   \  ___/|  | \/|  | |  |  |__  | \_\ (  <_> )___  |
                             |______  /\___  >__|   |__| |__|____/  |___  /\____// ____|
                                    \/     \/                           \/       \/    
""");
//Om man vill börja
while(true){
    Console.WriteLine("Är du redo att börja? Skriv ja eller nej!");
    string svar = Console.ReadLine();
    Textmellanrum();
    if(svar.ToLower() == "ja"){
        break;
    }
    else if(svar.ToLower() == "nej"){
        Console.WriteLine("Okej hejdå, skriv in vad som helst för att avsluta");
        Textmellanrum();
        Console.WriteLine("Bye bye");
        Console.ReadLine();
        Environment.Exit(0);
    }
    else{
        Console.WriteLine("Testa igen!");
        Textmellanrum();
    }
}



Console.WriteLine("Ditt namn är Bertil");
Textmellanrum();
Console.WriteLine("Du vaknar upp en vanlig morgon och dricker kaffe. Du går sedan ut");
Textmellanrum();
Console.WriteLine("Du är extremt sugen på en korvmacka, så du börjar gå emot Abdis korvgrill.");
Textmellanrum();
Console.WriteLine("När du står och väntar i kön, märker du hur en gammal farmor håller på att försöka tränga sig.");
Textmellanrum();
Console.WriteLine("Alternativ 1, slåss mot farmor så att hon skärper sig.");
Textmellanrum();
Console.WriteLine("Alternativ 2, låta farmor tränga sig så att du får din korvmacka långsammare.");
Textmellanrum();

//farmor
while(true){
    Textmellanrum();
    Console.WriteLine("Vilket väljer du? Alternativ 1, besegra farmor eller alternativ 2, vänta i kön?");
    string farmorVal = Console.ReadLine();
    int.TryParse( farmorVal, out int farmorValNum);

// om man väljer att attackera
    if(farmorValNum == 1){
        Textmellanrum();
        Console.WriteLine("Du väljer att slåss mot farmor!");
        Textmellanrum();
        MotståndareStrid(vilkenFiende, fiender ,farmor.hp, du.hp, farmor.skada, du.skada, farmor.attacker,du.attacker, energidricka,kebabrulle);
        vilkenFiende ++;
        Död(du.hp);
        break;
    }
    // om man väljer att inte göra något.
    else if(farmorValNum == 2){
        Textmellanrum();
        Console.WriteLine("Du väljer att låta farmor tränga sig, vilket leder till att du får din korvmacka långsammare.");
        if(Slumpa() == 2){
            Textmellanrum();
            System.Console.WriteLine("Hon knuffar dig våldsamt, du förlorar 2 hp!");
            du.hp -= 2;
        }
        break;
    }
    // om man skriver fel
    else{
        Textmellanrum();
        System.Console.WriteLine("Testa igen");
        Textmellanrum();
    }
}

Textmellanrum();
System.Console.WriteLine("Du får din korvmacka och går vidare");




Textmellanrum();
System.Console.WriteLine("Påväg hemåt igen träffar du Sorkmästaren som av någon anledning vill slår dig. Vad gör du?");
Textmellanrum();
System.Console.WriteLine(@"Alternativ 1, slåss mot sorkmästaren så att han slutar slå dig.
Alternativ 2, ge in till Sorkmästaren så att han drar därifrån."
);

//Sorkmästaren
int sorkValNum;
while(true){
    Textmellanrum();
    System.Console.WriteLine("Vad gör du, skriv 1 eller 2.");
    string sorkVal = Console.ReadLine();
    int.TryParse(sorkVal, out sorkValNum);

    if(sorkValNum == 1){
        Textmellanrum();
        Console.WriteLine("Du väljer att slåss mot Sorkmästaren!");
        Textmellanrum();
        MotståndareStrid(vilkenFiende, fiender ,sorkMästaren.hp, du.hp, sorkMästaren.skada, du.skada, sorkMästaren.attacker,du.attacker, energidricka,kebabrulle);
        vilkenFiende ++;
        Död(du.hp);
        break;  
    }
    else if(sorkValNum == 2){
        Textmellanrum();
        Console.WriteLine("Du väljer att bara stå still nära Sorkmästaren.");
        if(Slumpa() == 2){
            Textmellanrum();
            System.Console.WriteLine("Han biter din tå, du förlorar 3 hp!");
            du.hp -= 3;
        }
        break;
    }
    else{  
        Textmellanrum();
        System.Console.WriteLine("Testa igen");
        Textmellanrum();
        } 
}

System.Console.WriteLine("Sorkmästaren flyr!");
Textmellanrum();



System.Console.WriteLine("När du kommer hem så märker du att en kebab man står i dörr öppningen med ett spett.");
Textmellanrum();
System.Console.WriteLine("Han går till attack! Alternativ 1 kämpa emot. Alternativ 2 låt honom smeta dig med kebab.");
Textmellanrum();
System.Console.WriteLine(@"Alternativ 1
eller
alternativ 2?");

string kebabVal;

// Kebabmannen.
while(true){
    Textmellanrum();
    System.Console.WriteLine("Vad gör du, skriv 1 eller 2.");
    kebabVal = Console.ReadLine();
    int.TryParse(kebabVal, out int kebabValNum);

    if(kebabValNum == 1){
        Textmellanrum();
        Console.WriteLine("Du väljer att slåss mot kebabmannen!");
        Textmellanrum();
        MotståndareStrid(vilkenFiende, fiender ,kebabMan.hp, du.hp, kebabMan.skada, du.skada, kebabMan.attacker,du.attacker, energidricka,kebabrulle);
        Död(du.hp);
        break;  
    }
    else if(kebabValNum == 2){
        Textmellanrum();
        Console.WriteLine("Du väljer att bli smetad av kebabmannen.");
        if(Slumpa() == 2){
            Textmellanrum();
            System.Console.WriteLine("Han petar dig med spettet och du förlorar 3 i hälsa.");
            du.hp -= 3;
        }
        break;
    }
    else{  
        Textmellanrum();
        System.Console.WriteLine("Testa igen");
        Textmellanrum();
        } 
}


// du överlever dagen.
System.Console.WriteLine("Kebabmannen försvinner och lämnar endast efter sig en rulle kött.");
Textmellanrum();
System.Console.WriteLine("Du går och lägger dig och sover.");

Stopp();

Console.ReadLine();
}


//Återanvändbar funktion som ger tidsmellrum mellan skriven text
static void Textmellanrum() {
    Thread.Sleep(1500);
}




// själva stridsprocessen
static int MotståndareStrid(int vilkenFiende, string[] fiender, int hälsa, int dinHälsa, int[] skada, int[] dinaSkador, string[] attacker, string[] dinaAttacker, int energidricka, int kebabrulle) {

int slumptal = Slumpa();
Textmellanrum();
while (dinHälsa > 0 || hälsa > 0 ){
System.Console.WriteLine($"Du har tillgång till 3 attacker");

// Skriver ut alla attacker man har tillgång till.
for (int i = 0; i < dinaAttacker.Length; i++)
{
    System.Console.WriteLine($"{i}.{dinaAttacker[i]} gör {dinaSkador[i]} i skada");
    Textmellanrum();
}

System.Console.WriteLine($"Du har {dinHälsa} i hälsa.");
Textmellanrum();
System.Console.WriteLine($"{fiender[vilkenFiende]} har {hälsa} i hälsa.");

int attackValNum;

while(true){
    System.Console.WriteLine("Vilken attack vill du använda. SKriv 1 till 3. Eller powerup");
    string Val = Console.ReadLine();

// ifall man väljer en powerup.
    if (Val.ToLower() == "powerup"){
        Textmellanrum();
        System.Console.WriteLine("Kebabrulle eller energidricka?");
        string kraftUpp = Console.ReadLine();
        
        if(kraftUpp.ToLower() == "kebabrulle"){
            System.Console.WriteLine("Du valde kebabrulle");
            Kebab(dinaSkador,kebabrulle,dinaAttacker);
        }

        else if(kraftUpp.ToLower() == "energidricka"){
            Textmellanrum();
            System.Console.WriteLine("Du valde energidricka");
            dinHälsa = Energidryck(dinHälsa,energidricka);
            dinHälsa += skada[slumptal];
        }
    }
    
    bool attackBool = int.TryParse(Val, out attackValNum );


    if(attackBool == false ){
        // om val är powerup så ignoreras attackBool
        if(Val.ToLower() == "powerup"){
            System.Console.WriteLine("Du har använt en powerup!");
            Textmellanrum();
        }

        else{
        System.Console.WriteLine("skriv 1 2 eller 3!");
        Textmellanrum();
        }

    }
    else if(attackValNum > 3){
        System.Console.WriteLine("skriv högst 3!");
        Textmellanrum();
    }
    else if (attackValNum < 1){
        System.Console.WriteLine("Skriv minst 1!");
        Textmellanrum();
    }
    else{
        System.Console.WriteLine($"Bra jobbat! du tog {attackValNum}.");
        attackValNum--;
        Textmellanrum();
        break;
    }
    
}
 Textmellanrum();
System.Console.WriteLine($"Du använder {dinaAttacker[attackValNum]} och gör {dinaSkador[attackValNum]}!");
hälsa -= dinaSkador[attackValNum];


 Textmellanrum();
System.Console.WriteLine($"{fiender[vilkenFiende]} attackerar med {attacker[slumptal]} och gör {skada[slumptal]} i skada");
dinHälsa -= skada[slumptal];

//ifall någon hälsa blir under noll blir hälsa istället noll.
hälsa = Math.Max(0,hälsa); ;
dinHälsa = Math.Max(0,dinHälsa);

Textmellanrum();
System.Console.WriteLine($"Farmor har {hälsa} hp kvar!");
System.Console.WriteLine($"Du har {dinHälsa} hp kvar!");

// om man dör eller fienden dog
if(dinHälsa <= 0){
    Textmellanrum();
    System.Console.WriteLine("Du dog!");
    return dinHälsa;
}
else if(hälsa <= 0){
    Textmellanrum();
    System.Console.WriteLine($"Du dödade {fiender[vilkenFiende]}");
    return dinHälsa;
}

Textmellanrum();
System.Console.WriteLine("Tryck enter för att fortsätta!");

Console.ReadLine();

//Återställer den orginella attackskadan

if(dinaSkador[0] > 30 || dinaSkador[1] > 40 || dinaSkador[2] > 50){

for (int i = 0; i < dinaSkador.Length; i++)
{
    dinaSkador[i] /= kebabrulle;
}

dinHälsa += skada[slumptal];

}


}

//Retunerar den hälsa du har kvar;
return dinHälsa;

}


//En funktion som ger ett slumptal varje gång.
static int Slumpa(){

    int slump = Random.Shared.Next(0,3); // ett tal från 0 och 2
    return slump;
}

//En powerup som ger tillbacka hälsa
static int Energidryck(int dinHälsa, int energidricka) {
    System.Console.WriteLine($"Du dricker en energidricka och återfår {energidricka} i hp.");
    dinHälsa += energidricka;
    return dinHälsa;
}

// En powerup som dubblar den skada du gör.
static int[] Kebab( int[] dinaSkador, int kebabrulle, string[] dinaAttacker) {

    // en For loop som dubblar alla listvärden.
    for (int i = 0; i < dinaSkador.Length; i++)
    {
        dinaSkador[i] *= kebabrulle;
        Textmellanrum();
        System.Console.WriteLine($"{dinaAttacker[i]} gör nu {dinaSkador[i]} i skada!");
    }
    return dinaSkador;

}

// En funktion som kollar ifall du är död
static void Död(int dinHälsa) {
    if(dinHälsa <= 0){
        System.Console.WriteLine("Du är död, skriv vad som heslt för att avsluta.");
        Console.ReadLine();
        Environment.Exit(0); // stänger ner programmet. om dinhälsa är 0
    }
}

//Själva avslutningen av spelet.
static void Stopp() {

    string stopp;

  while(true){

      System.Console.WriteLine("Skriv stopp för att avsluta spelet.");
      stopp = Console.ReadLine();


      if(stopp.ToLower() == "stopp"){
        Textmellanrum();
        System.Console.WriteLine("Hejdå!");
        Thread.Sleep(3000); // så att man hinner inse att spelet är slut.
        Environment.Exit(0);
      }
      else{
        Textmellanrum();
        System.Console.WriteLine("Jag såg att du hade skrivit fel när du skriv in stopp, testa igen!");
        Textmellanrum();
      }
  }

}