namespace Parejas
{
    public enum Rangos{
        MuyJoven,Joven,Plenitud,Madurez,Vejez
    }
    public class Persona
    {
        public Persona(string nombre, char sexo, int edad){
            this.nombre=nombre;
            this.sexo=sexo;
            this.edad=edad;
           
        }
        public string nombre {get; set;}

        public char sexo {get;set;}

        public int edad {get; set;}

        public Rangos RangoE{ 
            get => edad switch{
                <20=>Rangos.MuyJoven,
                <30=>Rangos.Joven,
                <40=>Rangos.Plenitud,
                <50=>Rangos.Madurez,
                _=>Rangos.Vejez
            };
        }


        public override string ToString() => $"({nombre}, edad= {edad}, sexo= {sexo})";
    }
}