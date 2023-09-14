using System.Text;

Console.WriteLine("Superheros information");

var canFly = new SuperPower();
canFly.Name = "Volar";
canFly.Description = "Capacidad de volar y planear por los aires";
canFly.Level = LevelPower.LevelTwo;

var superStrength = new SuperPower();
superStrength.Name = "Super fuerza";
superStrength.Description = "Capacidad de fuerza físcia extraordinaria";
superStrength.Level = LevelPower.LevelThree;

var mindControl = new SuperPower();
superStrength.Name = "Control mental";
superStrength.Description = "Capacidad de controlar la voluntad de un ser vivo";
superStrength.Level = LevelPower.LevelThree;

// Superman (Marvel) hero
var superman = new SuperHero();

superman.Id = 1;
superman.Name = "Superman";
superman.SecretIdentity = "Clark Ken";
superman.City = "Metropolis";

// Superman 2
var superman2 = new SuperHero();

superman.Id = 1;
superman.Name = "Superman";
superman.SecretIdentity = "Clark Ken";
superman.City = "Metropolis";

Console.WriteLine(superman == superman2); // Console: False

// Con record, se compara mejor los valores
SuperHeroRecord superHeroRecord1 = new (1, "Superman", "Clark Ken");
SuperHeroRecord superHeroRecord2 = new(1, "Superman", "Clark Ken");

Console.WriteLine(superHeroRecord1 == superHeroRecord2); // Console: True

/* List<SuperPower> powersSuperman = new List<SuperPower>();
powersSuperman.Add(canFly);
powersSuperman.Add(superStrength);
superman.SuperPowers = powersSuperman;
// superman.ToUseSuperPower(); 
string resultSuperPowers = superman.ToUseSuperPower();
Console.WriteLine(resultSuperPowers);
*/

// Professor X (marvil) hero
var professorX = new SuperHero();

professorX.Id = 2;
professorX.Name = "Yuri";
professorX.SecretIdentity = "Charles Xavier";
professorX.City = "New York City";

List<SuperPower> powersProfessorX = new List<SuperPower>();
powersProfessorX.Add(mindControl);
professorX.SuperPowers = powersProfessorX;

class SuperHero
{
    public int Id;
    public string Name;
    public string SecretIdentity;
    public string City;
    public List<SuperPower> SuperPowers;
    public bool CanFly;
    
    // Constructor, alternativa a "Señalar valores por defecto". Es propia del paradigma POO.
    public SuperHero()
    {
        Id = 1;
        SuperPowers = new List<SuperPower>();
        CanFly = false;
    }

    public string ToUseSuperPower()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var powerItem in SuperPowers)
        {
            sb.AppendLine($"{Name} está usando el superpoder {powerItem.Name}.");
        }

        return sb.ToString();
    }
}

class SuperPower
{
    public string Name;
    public string Description;
    public LevelPower Level;

    public SuperPower()
    {
        Level = LevelPower.LevelOne; 
    }
}

enum LevelPower
{
    LevelOne,
    LevelTwo,
    LevelThree
}

public record SuperHeroRecord(int Id, string Name, string SecretIdentity);