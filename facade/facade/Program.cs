using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    internal class Program
    {

        static void Main(string[] args)
        {
            RepMusic ReproducirMusic = new RepMusic();
            ReproducirMusic.Encendido();  // Enciende el sistema, reproduce música y muestra la interfaz
            Console.WriteLine("---------------");
            ReproducirMusic.Apagado();  // Detiene la reproducción, oculta la interfaz y apaga el sistema
        }
    }

    // Fachada: Interfaz sencilla para los clientes
    public class RepMusic
    {
        private Encender encenderSistema;
        private Reproducir ReproducirSistema;
        private InterfazUsuario userInterface;

        public RepMusic()
        {
            encenderSistema = new Encender();
            ReproducirSistema = new Reproducir();
            userInterface = new InterfazUsuario();
        }

        public void Encendido()
        {
            encenderSistema.Encendido();
            ReproducirSistema.Tocar();
            userInterface.Mostrar();
        }

        public void Apagado()
        {
            ReproducirSistema.Detener();
            userInterface.Ocultar();
            encenderSistema.Apagado();
        }
    }

    // Subsistema 1: Subsistema de encendido
    public class Encender
    {
        public void Encendido()
        {
            Console.WriteLine("Encendiendo el sistema");
        }

        public void Apagado()
        {
            Console.WriteLine("Apagando el sistema");
        }
    }

    // Subsistema 2: Subsistema de reproducción
    public class Reproducir
    {
        public void Tocar()
        {
            Console.WriteLine("Reproduciendo música");
        }

        public void Detener()
        {
            Console.WriteLine("Deteniendo la reproducción");
        }
    }

    // Subsistema 3: Subsistema de interfaz
    public class InterfazUsuario
    {
        public void Mostrar()
        {
            Console.WriteLine("Mostrando interfaz de usuario");
        }

        public void Ocultar()
        {
            Console.WriteLine("Ocultando interfaz de usuario");
        }
    }
}
