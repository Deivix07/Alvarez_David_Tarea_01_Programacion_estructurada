using System;

// Alvarez_David_Ejercicio_3    3ero TSDS

// agrupa todas las clases y el programa principal
namespace Ejercicio_3
{
    /* 1)   Crea una clase llamada "Persona" con atributos como nombre, edad y DNI. 
            Luego, implemente métodos para la clase, como obtener y establecer valores para los atributos
    */

    class Persona  // Clase Persona
    {
        private string nombre; // Almacena el nombre
        private int edad;      // Almacena la edad
        private string dni;    // Almacena el DNI

        public Persona(string nombre, int edad, string dni)     // Constructor para inicializar los atributos de la clase
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        // Métodos para obtener y establecer el nombre
        public string Get_nombre() => nombre;
        public void Set_nombre(string nombre) => this.nombre = nombre;

        // Métodos para obtener y establecer la edad
        public int Get_edad() => edad;
        public void Set_edad(int edad) => this.edad = edad;

        // Métodos para obtener y establecer el DNI
        public string Get_dni() => dni;
        public void Set_dni(string dni) => this.dni = dni;

        // Método para imprimir la información de la persona
        public void Mostrar_informacion()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, DNI: {dni}");
        }
    }

    /* 2)	Crea una clase que represente un punto en el plano cartesiano. 
            La clase debe tener los siguientes atributos: x, y. 
            Los métodos deben permitir establecer y obtener los valores de los atributos
    */
    class Punto    // Clase Punto que representa un punto en el plano
    {
        private double x; // Coordenada X
        private double y; // Coordenada Y

        public Punto(double x, double y)   // Constructor para inicializar las coordenadas
        {
            this.x = x;
            this.y = y;
        }

        // Métodos para obtener y establecer la coordenada X
        public double Get_X() => x;
        public void Set_X(double x) => this.x = x;

        // Métodos para obtener y establecer la coordenada Y
        public double Get_Y() => y;
        public void Set_Y(double y) => this.y = y;

        // Método que imprime las coordenadas del punto
        public void Mostrar_punto()
        {
            Console.WriteLine($"Punto: ({x}, {y})");
        }
    }
    
    /* 3)	Crea una clase que represente un círculo. La clase debe tener los siguientes 
            atributos: x, y, radio. Los métodos deben permitir establecer y obtener los
            valores de los atributos. 
            También debe tener un método que calcule el área del círculo
    */
    class Circulo   // Clase Circulo que representa un círculo en el plano
    {
        private double x;      // Coordenada X
        private double y;      // Coordenada Y
        private double radio;  // Radio del círculo

        public Circulo(double x, double y, double radio)  // Constructor para inicializar los atributos
        {
            this.x = x;
            this.y = y;
            this.radio = radio;
        }

        // Método para obtener y establecer la coordenada x
        public double Get_X() => x;
        public void Set_X(double x) => this.x = x;

        // Método para obtener y establecer la coordenada y
        public double Get_Y() => y;
        public void Set_Y(double y) => this.y = y;

        // Método para obtener y establecer el radio
        public double Get_Radio() => radio;
        public void Set_Radio(double radio) => this.radio = radio;

        // Método para calcular el área del círculo  "Fórmula A = π * radio^2"
        public double Calcular_area() => Math.PI * Math.Pow(radio, 2);

        // Método para imprimir la información del círculo
        public void Mostrar_circulo()
        {
            Console.WriteLine($"Centro: ({x}, {y}), Radio: {radio}, Área: {Calcular_area():F2}");
        }
    }
   

    /* 4)	Crea una clase que represente una persona. La clase debe tener los 
            siguientes atributos: nombre, apellido, edad, género. 
            Los métodos deben permitir establecer y obtener los valores de los atributos. 
            También debe tener un método que imprima la información de la persona.
    */
    class Persona_ext     // Clase Persona_ext, tiene más atributos que la clase Persona
    {
        private string nombre;    // Nombre
        private string apellido;  // Apellido
        private int edad;         // Edad
        private string genero;    // Género

        public Persona_ext(string nombre, string apellido, int edad, string genero)   // Constructor para inicializar los atributos
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
        }

        // Métodos para obtener y establecer los valores de los atributos
        public string Get_nombre() => nombre;
        public void Set_nombre(string nombre) => this.nombre = nombre;

        public string Get_apellido() => apellido;
        public void Set_apellido(string apellido) => this.apellido = apellido;

        public int Get_edad() => edad;
        public void Set_edad(int edad) => this.edad = edad;

        public string Get_genero() => genero;
        public void Set_genero(string genero) => this.genero = genero;

        // Método para imprimir la información
        public void Mostrar_info()
        {
            Console.WriteLine($"Nombre: {nombre} {apellido}, Edad: {edad}, Género: {genero}");
        }
    }

    // Clase principal con el método para obtener y establecer atributos
    class Program
    {
        static void Main(string[] args)
        {
            // Prueba de la clase Persona
            Console.WriteLine("--Clase Persona--");
            Persona persona1 = new Persona("Alex", 19, "12345678");  //nombre, edad, dni
            persona1.Mostrar_informacion();

            // Prueba de la clase Punto
            Console.WriteLine("\n--Clase Punto--");
            Punto punto = new Punto(3.5, 7.2);       //x, y
            punto.Mostrar_punto();

            // Prueba de la clase Circulo
            Console.WriteLine("\n--Clase Círculo--");
            Circulo circulo = new Circulo(2.0, 3.0, 5.0);    //x, y, radio
            circulo.Mostrar_circulo();

            // Prueba de la clase Persona_ext
            Console.WriteLine("\n--Clase Persona Extendida--");
            Persona_ext persona_ext1 = new Persona_ext("Danny", "Pérez", 30, "Femenino");  //nombre, apellido, edad, genero
            persona_ext1.Mostrar_info();
        }
    }
}