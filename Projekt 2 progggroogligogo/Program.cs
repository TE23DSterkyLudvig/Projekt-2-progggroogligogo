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
