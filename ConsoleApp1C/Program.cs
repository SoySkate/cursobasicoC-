using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp1C
{
    class Program
    {
        static void FisrtFunction(string text)
        {
            Console.WriteLine("DIOSSS MI PRIMERA FUNCION XDDD: " + text +
                "\n esta es una pausa despues de la primera funcion xd");

        }
        static int DevuelveEntero(int a)
        {
            return a;
        }
        static void MiniBucle()
        {
            int i;
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine(i);

            }
        }
        static void DameArray()
        {
            int[] numeros = new int[] {1111,2222,3333,4444,5555,6666};
            int i;
            //Podría rellenar el array con el bucle tambien     
            for ( i =0; i<numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            //De esta forma tambien se puede pero es más tostón ;)
            //int[] numeros = new int[5];

            //numeros[0] = 1;
            //numeros[1] = 2;
            //numeros[2] = 4;
            //numeros[3] = 6;
            //numeros[4] = 3;
        }
        static void Cubo()
        {
            int[,] cube = new int[3,3] { { 1,1,1 }, { 2,2,2 }, { 3,3,3 } };
           
            
            int i, j;
            for(i = 0; i<3; i++)
            {
                Console.WriteLine("Line:");

                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine(cube[i, j]);
                }
            }
        }
        static void randomArray()
        {  //Generar una variable random
            Random aleatorio = new Random();

            int[] registro = new int[10];
            string sumaRegistro = "";
            for (int i = 0; i < 10; i++)
            {
                registro[i] = aleatorio.Next(0, 5) + 1;
              
                sumaRegistro += registro[i].ToString();

            }
            Console.WriteLine(sumaRegistro);
        }

        static string Iva(int numero)
        {
            float precio;
            //float precioFinal;
            precio = numero * 0.21f;
            //precioFinal = precio + numero;
          
            return "El iva de " + numero+ " es: " +(precio + numero);
        }

        static void listaFunction()
        {
            List<string> compra = new List<string>();
            compra.Add("Agua");
            compra.Add("Pasta");
            compra.Add("Manzanas");
            compra.Add("Vino");

            compra.Insert(0, "Leche");

            //FORMAS PARA ELIMINAR MEDIANTE NOMBRE O POSICION
            //compra.Remove("Vino");
            //compra.RemoveAt(4);
            

            for (int i=0; i< compra.Count; i++)
            {
                Console.WriteLine(compra[i]);
            }
        }
        static List<string> creaLista(string nombrelista)
        {
                List<string> nombreLista = new List<string>();
            string[] lista = new string[] { "Pan", "Panacota", "Panbimbo", "Panga", "Pans&Company", "Pangolin", "Pambtumaca xddd" };
            //nombreLista.Add("Pan");
            //nombreLista.Add("Panacota");
            //nombreLista.Add("Panbimbo");
            //nombreLista.Add("Panga");
            //nombreLista.Add("Pans&Companyxdd");
            //nombreLista.Add("Pangolin");
            for (int i = 0;  i< lista.Length; i++)
            {
                nombreLista.Add(lista[i]);
            }
            return nombreLista;
        }
        static void imprimirList(List<string> listaname)
        {
            for (int i = 0; i<listaname.Count; i++)
            {
                Console.WriteLine((i+1)+"-"+listaname[i]);
            }
            
        }

        static void cadenaycaracter()
        {
            string cadena = "texto";
            char[] caracter = { 't', 'e', 'x', 't', 'o' };

            Console.WriteLine(cadena[2]);
            Console.WriteLine(caracter[2]);
        }
        static int ParseroInt(string name)
        {
            try
            {
                return int.Parse(name);
            }
            catch {
                return 0;
                    }
        }
        static int ParseroInt(float num)
        {
            try
            {
                return (int) num;
            }
            catch
            {
                return 0;
            }
        }
        static string ParseroString(int num1)
        {
            try
            {
                return num1.ToString();
            }
            catch
            {
                return "error al parsear";
            }
        }
        static string ParseroString(float num1)
        {
            try
            {
                return num1.ToString();
            }
            catch
            {
                return "error al parsear";
            }
        }
        static float ParseroFloat(int num)
        {
            try
            {
                return (float)num;
            }
            catch
            {
                return 0;
            }
        }
        static float ParseroFloat(string num)
        {
            try
            {
                return float.Parse(num);
            }
            catch
            {
                return 0;
            }
        }
        static void FuncionesCadena()
        {
            string cadena = "arquitecto";
            //lenght de la cadena
            int longitud = cadena.Length;
            //si contiene o no el caracter
            bool contiene = cadena.Contains("r");
            //muestra el indice del caracter
            int indice = cadena.IndexOf('a');
            //Elimina el caracter del indice especificado
            string corte = cadena.Remove(5);
            //Remplaza un caracter por otro
            string remplazo = cadena.Replace('a', '*');
            //Borra parte de la cadena
            string trozoborrado = cadena.Substring(3, 3);

            Console.WriteLine(cadena +" ," + longitud + " ,"+ contiene + " ,"+indice + " ,"+corte + " ,"+remplazo + " ,"+trozoborrado);
        }
        static void MathFunction()
        {
            //generamlmente estas funciones usan el "double" (decimal igualmente)
            double num = 5.4;
            double result;
            //Redondeoa hacia abajo
            result = Math.Floor(num);
            Console.WriteLine(result+"\n");
            //Redondea hacia arriba
            result = Math.Ceiling(num);
            Console.WriteLine(result + "\n");
            //Hace la potencia del num elevado al numero despues de la coma
            result = Math.Pow(num,3);
            Console.WriteLine(result + "\n");
            //Hace la raíz cuadrada del num
            result = Math.Sqrt(num);
            Console.WriteLine(result + "\n");
            //Trunca los decimales (Elimina los decimales)
            result = Math.Truncate(num);
            Console.WriteLine(result + "\n");

        }

        struct Direccion
        {
            public string calle;
            public int numero;
            public char letra;
            public string cp;
            public string localidad;
        }
        class Carta
        {
            //Atributos/Miembros
            int numero;
            int palo;
            string[] palos = { "Oros", "Copas", "Espadas", "Bastos" };

            //Construcor
            public Carta(int n, int p)
            {
                numero = n;
                palo = p;
            }
            //Metodo
            public void escribirCarta()
            {
                Console.WriteLine(numero + " de "+palos[palo]);
            }
        }
        static void Main(string[] args)
        {
            Class1.Hola();
            Console.WriteLine("Hello World");
            Console.WriteLine();

            //Comentamos una linea
            /*comentamos
              varias lineas*/
            //recomendation about constant declaration with low bar at the variable beginning.
            // const int _a = 2;
            //const  int _b = 3;
            //  float total;
            //  Boolean frase = false;
            //  int resultado;
            //  resultado = _a + _b;
            //  float iva = ((float)resultado)*0.21f;
            //  total = resultado + iva;
            //  if (resultado> _a)
            //  { frase = true; }
            //  else
            //  {
            //      Console.WriteLine("el resultado es menos que la varibale _a");
            //  }

            //  if(frase == true) //Los operadores recuerda que este es de comparacion ==
            //      //y este es de asignacion =
            //  { 
            //  Console.WriteLine("Hello World400 este es mi resultado: " + resultado +" y este es el iva: "+ iva+ "  y el total es: "+ total);
            //  }

            Boolean c = true;
 do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Menú options:\n");
            Console.WriteLine("Select 1, 2, 3 or any option menu PLEASE :)");
            Console.WriteLine("1.For 1st option");
            Console.WriteLine("2.For 2nd option");
            Console.WriteLine("3.MiniBUcle");
                Console.WriteLine("4.For Give me an array");
                Console.WriteLine("5.For numbers of the cube (bidimensional array)");
                Console.WriteLine("6.For Add random numbers in to an array");
                Console.WriteLine("7.For Calculate the price with Iva tax.");
                Console.WriteLine("8.Mostrar Lista compra.");
                Console.WriteLine("9.Crear Lista con opciones.");
                Console.WriteLine("10.Diferencias entre string y char.");
                Console.WriteLine("11.Conversion de valores.");
                Console.WriteLine("12.Funciones de cadena.");
                Console.WriteLine("13.Funcion MATH.");
                Console.WriteLine("14.Mini ejercicio switch case.");
                Console.WriteLine("15.Crear structure y poner datos.");
                Console.WriteLine("16.Crear Objetos de una class.");
                Console.WriteLine("5.EXIT  \n");

            string b = Console.ReadLine();
           
                //do while to loop the switch menu"""
                if (c == true)
                {
                    switch (b)
                    {

                        case "1":
                            Console.WriteLine("1st option");
                            FisrtFunction("hola soy el texto de la funcion xd");
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.WriteLine("2nd option");
                            Console.WriteLine(DevuelveEntero(5));
                            Console.ReadKey();

                            break;
                        case "3":
                            Console.WriteLine("3th option");
                            MiniBucle();
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.WriteLine("4th option");
                            DameArray();
                            Console.ReadKey();
                            break;
                        case "0":
                            c = false;
                            break;
                        case "5":
                            Console.WriteLine("5.Mostrando la funcion cube..");
                            Cubo();
                            Console.ReadKey();
                            break;
                        case "6":
                            Console.WriteLine("6.Mostrando la funcion randomarray..");
                            randomArray();
                            Console.ReadKey();
                            break;
                        case "7":
                            Console.WriteLine("7.Mostrando la funcion CalcularIVA..");
                            Console.WriteLine("Introduzca un numero para sumarle el iva:");
                            int numero;
                            try {  
                                numero = int.Parse(Console.ReadLine());
                                Console.WriteLine(Iva(numero));
                            }
                            catch {
                                Console.WriteLine("No ha introducido ningún nada, o no era valido el caracter.");
                            }
                            Console.ReadKey();
                            break;
                        case "8":
                            Console.WriteLine("8.Mostrando la lista de la compra..");
                            listaFunction();
                            Console.ReadKey();
                            break;

                        case "9":
                            Console.WriteLine("9.Creando Lista con opciones... \n Introduca el nombre de la lista:");
                            string nombre;
                            List<string> imprimir;
                             nombre =  Console.ReadLine();
                            try {
                               imprimir =  creaLista(nombre);
                                imprimirList(imprimir);
                            }
                            catch {
                                Console.WriteLine("La lista no se ha creado..");
                                    }
                            Console.ReadKey();
                            break;
                        case "10":
                            Console.WriteLine("10.Mostrando diferencia entre string y char...");
                            cadenaycaracter();
                            Console.ReadKey();
                            break;
                        case "11":
                            Console.WriteLine("11.Mostrando Datos Convertidos...");
                            Console.WriteLine("Parse a int un string o float:");
                            Console.WriteLine(ParseroInt("12345"));
                            Console.WriteLine(ParseroInt(2.34f));
                            Console.WriteLine("Parse a string un float o int:");
                            Console.WriteLine(ParseroInt(2.34f));
                            Console.WriteLine(ParseroInt(234));
                            Console.WriteLine("Parse a float un string o int:");
                            Console.WriteLine(ParseroInt("12345"));
                            Console.WriteLine(ParseroInt(234));

                            Console.ReadKey();
                            break;
                        case "12":
                            Console.WriteLine("12.Mostrando algunas de las posibles fucniones de cadena...");
                            FuncionesCadena();
                            Console.ReadKey();
                            break;
                        case "13":
                            Console.WriteLine("13.Mostrando opciones de la funcion MATH...");
                            MathFunction();
                            Console.ReadKey();
                            break;
                        case "14":
                            Console.WriteLine("14.Switch..");
                            Boolean menu2 = true;
                            do {
                                Console.WriteLine("\n\n_____________________________");
                                Console.WriteLine("1.De cm a pulgadas.");
                            Console.WriteLine("2.De kg a libras.");
                            Console.WriteLine("3.De km a millas.");
                            Console.WriteLine("4.De grados a radianes.");
                            int opcion = int.Parse(Console.ReadLine());
                            if (menu2 == true)
                            {
                                switch (opcion)
                                {
                                    case 1:
                                        Console.WriteLine("Introduce los centimetros:");
                                        string cm = Console.ReadLine();
                                        float conversion = ParseroFloat(cm);
                                        float pulgadas = conversion * 0.39370f;
                                        Console.WriteLine("Las pulgadas son:"+pulgadas);
                                        break;
                                    case 2:
                                        Console.WriteLine("Introduce los quilogramos:");
                                        string kg = Console.ReadLine();
                                        float conversion2 = ParseroFloat(kg);
                                        float libras = conversion2 * 2.20462262f;
                                        Console.WriteLine("Las libras son:" + libras);
                                        break;
                                    case 3:
                                        Console.WriteLine("Introduce los quilometros:");
                                        string km = Console.ReadLine();
                                        float conversion3 = ParseroFloat(km);
                                        float millas = conversion3 * 0.621371192f;
                                        Console.WriteLine("Las millas son:" + millas);
                                        break;
                                    case 4:
                                        Console.WriteLine("Introduce los grados:");
                                        string grados = Console.ReadLine();
                                        float conversion4 = ParseroFloat(grados);
                                        float radianes = conversion4 * 0.0174532925f;
                                        Console.WriteLine("Las radianes son:" + radianes);
                                        break;
                                    case 5:
                                        Console.WriteLine("Saliendo");
                                        menu2 = false;
                                        break;
                                    default:
                                        Console.WriteLine("You didn't choose any viable option...");
                                        Console.ReadKey();
                                        break;
                                }
                               
                            }
                            } while (menu2 == true);
                            
                            break;
                        case "15":
                            Direccion dir;
                            Console.WriteLine("15.Añadiendo datos en una estructura...");
                            dir.calle = "PL Cabrinetty";
                            dir.numero = 13;
                            dir.letra = 'A';
                            dir.cp = "17520";
                            dir.localidad = "Puigecrda";
                            //Salida de los datos por pantalla
                            Console.WriteLine("La calle donde vives es:"+dir.calle);
                            Console.WriteLine("El numero donde vives es:" + dir.numero);
                            Console.WriteLine("La letra es:" + dir.letra);
                            Console.WriteLine("El codigo postal es:" + dir.cp);
                            Console.WriteLine("La Localidad donde vives es:" + dir.localidad);

                            Console.ReadKey();
                            break;
                        case "16":
                            Console.WriteLine("16.Mostrando creacion de objeto..");
                            //Carta(1,1) estoy accediendo al constructo poniendo unos valores

                            Carta card = new Carta(1, 1);
                            card.escribirCarta();
                            //Otra forma de crear un objeto:
                            Carta card2;
                            card2 = new Carta(3, 2);
                            card2.escribirCarta();
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("You didn't choose any viable option...");
                            Console.ReadKey();
                            break;
                    }
                }
            } while (c == true);
            

          
        }

    }
}
