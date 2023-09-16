using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal abstract class Hero // Siempre que usamos abstract, estamos forzando que las clases hijas también hagan esa implementación.
    {
        public abstract string Name { get; set; }

        public abstract string ToSaveTheWorld(); // Con abstract no tenemos que defirnir una lógica en particular, sino que herede. La clase que lo contenga también debe ser abstracta. 

        public virtual string ToSaveTheEarth()
        {
            return $"{Name} ha salvado la tierra";
        }
    }
}
