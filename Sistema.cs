using System.Collections.Generic;
using System;

namespace Parejas
{
    public class Sistema
    {
        public bool Descendendia(Persona a, Persona b)
        {
            if(Math.Abs(a.RangoE-b.RangoE)<=1 && Math.Abs(a.edad-b.edad)<=12 && a.sexo!=b.sexo) 
                return true;
            else{
                 return false;
            }
        }

         public List<Persona> Personas { get; } = new()
        {
         new Persona("Marta",20,'F'),
         new Persona("Leire",28,'F'),
         new Persona("Uxue",18,'F'),
         new Persona("Oscar",18,'M'),
         new Persona("Ignacio",66,'M'),
         new Persona("Ender",67,'M'),
         new Persona("Lorena",15,'F'),
         new Persona("Mayali",6,'F'),
         new Persona("Xabi",100,'M'),
         new Persona("Lucas",60,'M')   
        };

        public List<(Persona, Persona)> PosibleP(List<Persona> personas)
        {

            var parejas = new List<(Persona, Persona)>();

            for(int i=0; i<personas.Count-1;i++){

                for (int j=i+1; j<personas.Count;j++){

                    if (Descendendia(personas[i],personas[j]))

                        parejas.Add((personas[i],personas[j]));

                }
            }          
            return parejas;
        }
    }
}