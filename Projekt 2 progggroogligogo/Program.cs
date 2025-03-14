Motståndare farmor = new();
farmor.Hp = 200;
farmor.skada = [20, 30, 40 ];
farmor.attacker = ["godis","löstandshugg", "shotgun"];

Motståndare sorkMästaren = new();
sorkMästaren.Hp = 120;
sorkMästaren.skada = [10,20,Random.Shared.Next(1,50)];
sorkMästaren.attacker = ["gnaga", "sorkattack", "digerdöden"];

Motståndare kebabMan =new();
kebabMan.Hp = 150;
kebabMan.skada = [20, Random.Shared.Next(5,40), 50];
kebabMan.attacker = ["kebabspett", "köttklump", "bepsi"];


System.Console.WriteLine("                                                      Bertils Liv");
System.Console.WriteLine("""
                            __________               __  .__.__    ___.                 
                            \______   \ ____________/  |_|__|  |   \_ |__   ____ ___.__.
                             |    |  _// __ \_  __ \   __\  |  |    | __ \ /  _ <   |  |
                             |    |   \  ___/|  | \/|  | |  |  |__  | \_\ (  <_> )___  |
                             |______  /\___  >__|   |__| |__|____/  |___  /\____// ____|
                                    \/     \/                           \/       \/    
""");

while(true){
    System.Console.WriteLine("Är du redo att börja");
    if(){

    }
}

System.Console.WriteLine("Ditt namn är Bertil");
System.Console.WriteLine("Du vaknar upp en vanlig morgon, dricker ditt kaffe och går ut");


Console.ReadLine();
