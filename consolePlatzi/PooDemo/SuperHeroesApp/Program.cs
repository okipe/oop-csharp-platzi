using System.Text;
using SuperHeroesApp.Models;

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

var regeneration = new SuperPower();
regeneration.Name = "Regeneración";
regeneration.Description = "Capacidad de recuperar las partes del cuerpo dañadas";
regeneration.Level = LevelPower.LevelTwo;

// Superman (Marvel) hero
var superman = new SuperHero();

superman.Id = 1;
superman.Name = "Superman ";
superman.SecretIdentity = "Clark Ken";
superman.City = "Metropolis";

List<SuperPower> powersSuperman = new List<SuperPower>();
powersSuperman.Add(canFly);
powersSuperman.Add(superStrength);
superman.SuperPowers = powersSuperman;
// superman.ToUseSuperPower(); 
string resultSuperPowers = superman.ToUseSuperPower();
Console.WriteLine(resultSuperPowers);

// Professor X (marvil) hero
var professorX = new SuperHero();

professorX.Id = 2;
professorX.Name = "Yuri";
professorX.SecretIdentity = "Charles Xavier";
professorX.City = "New York City";

List<SuperPower> powersProfessorX = new List<SuperPower>();
powersProfessorX.Add(mindControl);
professorX.SuperPowers = powersProfessorX;

// Wolverine antihero
var wolverine = new Antihero();
wolverine.Id = 5;
wolverine.Name = "Wolverine";
wolverine.SecretIdentity = "Logan Howlett";
wolverine.CanFly = false;

List<SuperPower> powersWolverine = new List<SuperPower>();
powersWolverine.Add(regeneration);
powersWolverine.Add(superStrength);
wolverine.SuperPowers = powersWolverine;
string resultWolverineSuperPowers = wolverine.ToUseSuperPower();
Console.WriteLine(resultWolverineSuperPowers);

string actionAntihero = wolverine.ToDoAntiheroAction("Ataca a la policía");
Console.WriteLine(actionAntihero);

enum LevelPower
{
    LevelOne,
    LevelTwo,
    LevelThree
}

public record SuperHeroRecord(int Id, string Name, string SecretIdentity);