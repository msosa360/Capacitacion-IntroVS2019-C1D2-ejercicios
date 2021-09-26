using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Noticias de la Galaxia!");
            IterarLista();
            Console.ReadKey();
        }

        private static void IterarLista()
        {
            var lasGalaxias = new List<Galaxia>
        {
            new Galaxia() { Nombre="Tadpole", AñosLuz=400, TipoGalaxia=new TipoGalaxia('S')},
            new Galaxia() { Nombre="Pinwheel", AñosLuz=25, TipoGalaxia=new TipoGalaxia('S')},
            new Galaxia() { Nombre="Cartwheel", AñosLuz=500, TipoGalaxia=new TipoGalaxia('L')},
            new Galaxia() { Nombre="Small Magellanic Cloud", AñosLuz=.2, TipoGalaxia=new TipoGalaxia('I')},
            new Galaxia() { Nombre="Andromeda", AñosLuz=3, TipoGalaxia=new TipoGalaxia('S')},
            new Galaxia() { Nombre="Maffei 1", AñosLuz=11, TipoGalaxia=new TipoGalaxia('E')}
        };

            foreach (Galaxia laGalaxia in lasGalaxias)
            {
                Console.WriteLine(laGalaxia.Nombre + "  " + laGalaxia.AñosLuz + ",  " + laGalaxia.TipoGalaxia);
            }

            // SALIDA ESPERADA:
            //  Tadpole  400,  Spiral
            //  Pinwheel  25,  Spiral
            //  Cartwheel, 500,  Lenticular
            //  Small Magellanic Cloud .2,  Irregular
            //  Andromeda  3,  Spiral
            //  Maffei 1,  11,  Elliptical
        }
    }

    public class Galaxia
    {
        public string Nombre { get; set; }
        public double AñosLuz { get; set; }
        public object TipoGalaxia { get; set; }
    }

    public class TipoGalaxia
    {
        public TipoGalaxia(char type)
        {
            switch (type)
            {
                case 'S':
                    MiTipoGalaxia = Type.Espiral;
                    break;
                case 'E':
                    MiTipoGalaxia = Type.Eliptica;
                    break;
                case 'l':
                    MiTipoGalaxia = Type.Irregular;
                    break;
                case 'L':
                    MiTipoGalaxia = Type.Lenticular;
                    break;
                default:
                    break;
            }
        }
        public object MiTipoGalaxia { get; set; }
        private enum Type { Espiral, Eliptica, Irregular, Lenticular }
    }
}
