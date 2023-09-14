// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");

PCMotherboard motherboard1 = new PCMotherboard();
PCMotherboard motherboard2 = new PCMotherboard();

motherboard1.NameChipset = "AM-320";
motherboard1.LargeSize = 24.4;
motherboard1.RamSlots = 2;
motherboard1.PciExpressSlots = 3;
motherboard1.WifiEmbedded = false;

motherboard2.NameChipset = "AX-370";
motherboard2.LargeSize = 33.47;
motherboard2.RamSlots = 4;
motherboard2.PciExpressSlots = 4;
motherboard2.WifiEmbedded = true;

StarcraftAirUnit wraith = new StarcraftAirUnit();
wraith.Race = "Terran";
wraith.LifePoints = 120;
wraith.GroundDamage = 8;
wraith.AirDamage = 20;
wraith.UnitSpeed = 4.963;

class PCMotherboard
{
    public string NameChipset;
    public double LargeSize;
    public short RamSlots;
    public short PciExpressSlots;
    public bool WifiEmbedded;
}


class StarcraftAirUnit
{
    public string Race;
    public short LifePoints;
    public short GroundDamage;
    public short AirDamage;
    public double UnitSpeed;
}