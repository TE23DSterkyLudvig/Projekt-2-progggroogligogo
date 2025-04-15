System.Console.WriteLine("Nu kör vi");
textMellanrum();

helaKoden();



//innehåller hela huvudkoden
static void helaKoden(){
    
List<string> fiender = ["farmoder","sorkMästare", "kebabMannen"];

int vilkenFiende = 0;

// jag använder min klass kämpe för att skapa alla olika kämpar bland annat spelaren.
kämpe du = new(){
Hp = 300,
skada = [30, 40, 50 ],
attacker = ["Drake","Dissa", "Bingufy"]
};

kämpe farmor = new(){
Hp = 200,
skada = [20, 30, 40 ],
attacker = ["godis","löstandshugg", "shotgun"]
};


kämpe sorkMästaren = new() {
Hp = 120,
skada = [10,20,Random.Shared.Next(1,50)],
attacker = ["gnaga", "sorkattack", "digerdöden"]
};


kämpe kebabMan =new() {
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
    Console.WriteLine("Är du redo att börja? Skriv ja eller nej!");
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



//farmor
while(true){
    textMellanrum();
    Console.WriteLine("Vilket väljer du? Alternativ 1, besegra farmor eller alternativ 2, vänta i kön?");
    string farmorVal = Console.ReadLine();
    int.TryParse( farmorVal, out int farmorValNum);

// om man väljer att attackera
    if(farmorValNum == 1){
        textMellanrum();
        Console.WriteLine("Du väljer att slåss mot farmor!");
        motståndareStrid(vilkenFiende, fiender ,farmor.Hp, du.Hp, farmor.skada, du.skada, farmor.attacker,du.attacker, energidricka,kebabrulle);
        vilkenFiende ++;
        död(du.Hp);
        break;
    }
    // om man väljer att inte göra något.
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
    // om man skriver fel
    else{
        textMellanrum();
        System.Console.WriteLine("Testa igen");
        textMellanrum();
    }
}

textMellanrum();
System.Console.WriteLine("Du får din korvmacka och går vidare");




textMellanrum();
System.Console.WriteLine("Påväg hemåt igen träffar du Sorkmästaren som av någon anledning vill slår dig. Vad gör du?");
textMellanrum();
System.Console.WriteLine(@"Alternativ 1, slåss mot sorkmästaren så att han slutar slå dig.
Alternativ 2, ge in till Sorkmästaren så att han drar därifrån."
);

//Sorkmästaren
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
        Console.WriteLine("Du väljer att bara stå still nära Sorkmästaren.");
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

System.Console.WriteLine("Sorkmästaren flyr!");
textMellanrum();



System.Console.WriteLine("När du kommer hem så märker du att en kebab man står i dörr öppningen med ett spett.");
textMellanrum();
System.Console.WriteLine("Han går till attack! Alternativ 1 kämpa emot. Alternativ 2 låt honom smeta dig med kebab.");
textMellanrum();
System.Console.WriteLine(@"Alternativ 1
eller
alternativ 2?");

string kebabVal;

// Kebabmannen.
while(true){
    textMellanrum();
    System.Console.WriteLine("Vad gör du, skriv 1 eller 2.");
    kebabVal = Console.ReadLine();
    int.TryParse(kebabVal, out int kebabValNum);

    if(kebabValNum == 1){
        textMellanrum();
        Console.WriteLine("Du väljer att slåss mot kebabmannen!");
        motståndareStrid(vilkenFiende, fiender ,kebabMan.Hp, du.Hp, kebabMan.skada, du.skada, kebabMan.attacker,du.attacker, energidricka,kebabrulle);
        död(du.Hp);
        break;  
    }
    else if(kebabValNum == 2){
        textMellanrum();
        Console.WriteLine("Du väljer att bli smetad av kebabmannen.");
        if(slumpa() == 2){
            textMellanrum();
            System.Console.WriteLine("Han petar dig med spettet och du förlorar 3 i hälsa.");
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


// du överlever dagen.
System.Console.WriteLine("Kebabmannen försvinner och lämnar endast efter sig en rulle kött.");
textMellanrum();
System.Console.WriteLine("Du går och lägger dig och sover.");

stopp();

Console.ReadLine();
}


//Återanvändbar funktion som ger tidsmellrum mellan skriven text
static void textMellanrum() {
    Thread.Sleep(1500);
}




// själva stridsprocessen
static int motståndareStrid(int vilkenFiende, List<string> fiender, int hälsa, int dinHälsa, List<int> skada, List<int> dinaSkador, List<string> attacker, List<string> dinaAttacker, int energidricka, int kebabrulle) {

int slumptal = slumpa();

while (dinHälsa > 0 || hälsa > 0 ){
System.Console.WriteLine($"Du har tillgång till 3 attacker");

// Skriver ut alla attacker man har tillgång till.
for (int i = 0; i < dinaAttacker.Count; i++)
{
    System.Console.WriteLine($"{dinaAttacker[i]} gör {dinaSkador[i]} i skada");
    textMellanrum();
}

System.Console.WriteLine($"Du har {dinHälsa} i hälsa.");
textMellanrum();
System.Console.WriteLine($"{fiender[vilkenFiende]} har {hälsa} i hälsa.");

int attackValNum;

while(true){
    System.Console.WriteLine("Vilken attack vill du använda. SKriv 1 till 3. Eller powerup");
    string Val = Console.ReadLine();

// ifall man väljer en powerup.
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


    if(attackBool == false ){
        // om val är powerup så ignoreras attackBool
        if(Val.ToLower() == "powerup"){
            System.Console.WriteLine("Du har använt en powerup!");
            textMellanrum();
        }

        else{
        System.Console.WriteLine("skriv 1 2 eller 3!");
        textMellanrum();
        }

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
 textMellanrum();
System.Console.WriteLine($"Du använder {dinaAttacker[attackValNum]} och gör {dinaSkador[attackValNum]}!");
hälsa -= dinaSkador[attackValNum];


 textMellanrum();
System.Console.WriteLine($"{fiender[vilkenFiende]} attackerar med {attacker[slumptal]} och gör {skada[slumptal]} i skada");
dinHälsa -= skada[slumptal];

//ifall någon hälsa blir under noll blir hälsa istället noll.
hälsa = Math.Max(0,hälsa); ;
dinHälsa = Math.Max(0,dinHälsa);

textMellanrum();
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

textMellanrum();
System.Console.WriteLine("Tryck enter för att fortsätta!");

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


//En funktion som ger ett slumptal varje gång.
static int slumpa(){

    int slump = Random.Shared.Next(0,3); // ett tal från 0 och 2
    return slump;
}

//En powerup som ger tillbacka hälsa
static void energidryck(int dinHälsa, int energidricka) {
    System.Console.WriteLine($"Du dricker en energidricka och återfår {energidricka} i hp.");
    dinHälsa += energidricka;
}

// En powerup som dubblar den skada du gör.
static List<int> kebab( List<int> dinaSkador, int kebabrulle, List<string> dinaAttacker) {

    // en For loop som dubblar alla listvärden.
    for (int i = 0; i < dinaSkador.Count; i++)
    {
        dinaSkador[i] *= kebabrulle;
        textMellanrum();
        System.Console.WriteLine($"{dinaAttacker[i]} gör nu {dinaSkador[i]} i skada!");
    }
    return dinaSkador;

}

// En funktion som kollar ifall du är död)
static void död(int dinHälsa) {
    if(dinHälsa <= 0){
        System.Console.WriteLine("Du är död, skriv vad som heslt för att avsluta.");
        Console.ReadLine();
        Environment.Exit(0); // stänger ner programmet. om dinhälsa är 0
    }
}

//Själva avslutningen av spelet.
static void stopp() {

    string stopp;

  while(true){

      System.Console.WriteLine("Skriv stopp för att avsluta spelet.");
      stopp = Console.ReadLine();


      if(stopp.ToLower() == "stopp"){
        textMellanrum();
        System.Console.WriteLine("Hejdå!");
        Thread.Sleep(3000); // så att man hinner inse att spelet är slut.
        Environment.Exit(0);
      }
      else{
        textMellanrum();
        System.Console.WriteLine("Jag såg att du hade skrivit fel när du skriv in stopp, testa igen!");
        textMellanrum();
      }
  }

}