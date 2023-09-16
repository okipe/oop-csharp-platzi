using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHero : Hero, ISuperHero // ISuperHero es una interface. Acá está al costado del padre Hero
    {
        private string _Name;
        public int Id { get; set; } = 1;
        // Encapsulamos el Name
        public override string Name // Como la clase padre usa abstract, estamos poniendo un "override"
        {   get { return _Name; } // return del nombre sin modificar.
            set { _Name = value.Trim(); }  // el Value es variable reservada. Permite evitar los errores de añadir espacios gracias a Trim
        }

        public string NameAndSecretIdentity
        {
            get { return $"{Name} ({SecretIdentity})"; }
        }

        public string SecretIdentity { get; set; }
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
                sb.AppendLine($"{NameAndSecretIdentity} está usando el superpoder {powerItem.Name}.");
            }

            return sb.ToString();
        }

        public override string ToSaveTheWorld()
        {
            return $"{NameAndSecretIdentity} ha salvado el mundo";
        }

        public override string ToSaveTheEarth()
        {
            // return base.ToSaveTheEarth();
            return $"{NameAndSecretIdentity} ha salvado la tierra.";
        }
    }
}
