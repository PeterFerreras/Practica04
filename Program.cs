using System;

namespace ConsoleApp4
{
    class Program
    {
        static int a=0;
        
        public static void Multi()
        {

            do
            {
                Console.WriteLine("ingrese el numero que desea saber su tabla de mulplicacion");
                a = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 12; i++)
                {


                    if (a != -1)
                    {

                        Console.WriteLine(i + " X " + a + " = " + i * a);


                    }
                    else
                    {
                        break;

                    }

                }


                Console.Write("\nPresione enter para volver al menu y si digito -1 tambien presione enter");

                Console.ReadKey();
                Console.Clear();
            }

            while (a != -1);




        }

        public static void Dativiri()
        {
            int f;
            string g;
            Console.WriteLine("\nIngrese su Nombre");
            g = Console.ReadLine();
            Console.WriteLine("\nIngrese su edad");
            f = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNombre: " + g);
            if (f >= 18)
            {
                Console.Write("\nEs mayor de edad");

            }
            else {

                Console.Write("\nEs menor de edad");
            }


        }


        static void Main(string[] args)
        {
            //1-Un programa que pida al usuario 4 números, los memorice(utilizando un array), calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.
            /*
            int[] media = new int[5];
            int suma = 0;
            Console.WriteLine("Ingrese su primer numero:");
            media[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo numero:");
            media[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su tercero numero:");
            media[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su cuarto numero:");
            media[3] = Convert.ToInt32(Console.ReadLine());

            media[4] = media[0] + media[1] + media[2] + media[3];
            suma = media[4] / 4;

            Console.WriteLine("La media es: "+suma);
            Console.WriteLine("Los datos ingresados fueron: "+media[0]+"-"+media[1]+"-"+media[2]+"-"+media[3]);
            */

            //2-Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") y luego los muestre en el orden contrario al que se introdujeron.

            /*
            float[] reales = new float[5];

            Console.WriteLine("Ingrese su primer numero:");
            reales[0] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo numero:");
            reales[1] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese su tercero numero:");
            reales[2] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese su cuarto numero:");
            reales[3] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese su quinto numero:");
            reales[4] = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("\n");
            
            Console.Write(reales[4]+"\n");
            Console.Write(reales[3] + "\n");
            Console.Write(reales[2] + "\n");
            Console.Write(reales[1] + "\n");
            Console.Write(reales[0] + "\n");
            */

            //3-Un programa que almacene en un array el número de días que tiene cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes

            /*

             int a = 0;

             do
             {
                 int[] meses = new int[12];

                 meses[0] = 31;
                 meses[1] = 28;
                 meses[2] = 31;
                 meses[3] = 30;
                 meses[4] = 31;
                 meses[5] = 30;
                 meses[6] = 31;
                 meses[7] = 31;
                 meses[8] = 30;
                 meses[9] = 31;
                 meses[10] = 30;
                 meses[11] = 31;




                 Console.Write("Bienvenido/a al menu \n");
                 Console.Write("\nPresione 1 - enero \n");
                 Console.Write("Presione 2 - febrero \n");
                 Console.Write("Presione 3 - marzo \n");
                 Console.Write("Presione 4 - abril \n");
                 Console.Write("Presione 5 - mayo \n");
                 Console.Write("Presione 6 - junio \n");
                 Console.Write("Presione 7 - julio \n");
                 Console.Write("Presione 8 - agosto \n");
                 Console.Write("Presione 9 - septiembre \n");
                 Console.Write("Presione 10 - octubre \n");
                 Console.Write("Presione 11 - noviembre \n");
                 Console.Write("Presione 12 - diciembre \n");

                 Console.Write("\nEliga una opcion: \n");
                 a = Convert.ToInt32(Console.ReadLine());

                 switch (a)
                 {
                     case 1:
                         Console.Write("\nEnero cuenta con: "+meses[0]+ " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 2:
                         Console.Write("\nFebreo cuenta con: " + meses[1] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 3:
                         Console.Write("\nMarzo cuenta con: " + meses[2] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 4:
                         Console.Write("\nAbril cuenta con: " + meses[3] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 5:
                         Console.Write("\nMayo cuenta con: " + meses[4] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 6:
                         Console.Write("\nJunio cuenta con: " + meses[5] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 7:
                         Console.Write("\nJulio cuenta con: " + meses[6] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 8:
                         Console.Write("\nAgosto cuenta con: " + meses[7] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 9:
                         Console.Write("\nSeptiembre cuenta con: " + meses[8] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 10:
                         Console.Write("\nOctubre cuenta con: " + meses[9] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 11:
                         Console.Write("\nNoviembre cuenta con: " + meses[10] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     case 12:
                         Console.Write("\nDiciembre cuenta con: " + meses[11] + " Dias");
                         Console.Write("\nPresione enter para volver al menu....");
                         Console.ReadKey();

                         Console.Clear();
                         break;
                     default:
                         Console.Write("\nLa opcion que eligio no esta en el menu");
                         break;

                 }
             }

             while (a != 0);

             */

            //4-Un programa que pida al usuario 10 números y luego calcule y muestre cuál es el mayor de todos ellos

            /*
           int[] h = new int[11];
           int j = 0;
           int mayor=0;
           for(int i= 1; i <= 10; i++)
           {
               Console.WriteLine("Ingrese su "+i+" valor");
               h[i] = Convert.ToInt32(Console.ReadLine());
           }

           while (j < 10)
           {
               if (h[j] > mayor)

                   mayor = h[j];
                   j++;
           }

           Console.WriteLine("Este numero es el mayor de todos: " + mayor);
        
             
             */

            //5-Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han introducido

            /* int i;
          string nombre="";
          string[] nom = new string[100];
          Console.WriteLine("Introdusca un numero indeterminado de nombres, cuando quiera finalizar el programa presione enter");
          for ( i = 0; i <= 99; i++) {
          nom[i] = Console.ReadLine();
          nombre += nom[i];
          if(nom[i] == "")
           {
                      break;
           }
                                     }
          Console.WriteLine(nombre);*/

            //7-Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n".


            /*Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine();
            int l = nombre.Length;

            for (int a = 0; a < l; ++a)
            {
                
                Console.WriteLine(nombre[a]);
            }
               */


            //8-Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas.

            /* float[] k = new float[5];

          Console.WriteLine("\nIngrese la estatura de la 1er persona:");
          k[0] = Convert.ToSingle(Console.ReadLine());

          Console.WriteLine("\nIngrese la estatura de la 2da persona:");
          k[1] = Convert.ToSingle(Console.ReadLine());

          Console.WriteLine("\nIngrese la estatura de la 3era persona:");
          k[2] = Convert.ToSingle(Console.ReadLine());

          Console.WriteLine("\nIngrese la estatura de la 4ta persona:");
          k[3] = Convert.ToSingle(Console.ReadLine());

          Console.WriteLine("\nIngrese la estatura de la 5ta persona:");
          k[4] = Convert.ToSingle(Console.ReadLine());

          float suna = k[0] + k[1] + k[2] + k[3] + k[4];
          float b = suna / 5;

          int max = 0;
          int min = 0;


          if (b >= k[0])
          {
              min++;
          }
          else
          {
              max++;
          }

          if (b >= k[1])
          {
              min++;
          }
          else
          {
              max++;
          }

          if (b >= k[2])
          {
              min++;
          }

          else
          {
              max++;
          }


          if (b >= k[3])
          {
              min++;
          }
          else
          {
              max++;
          }


          if (b >= k[4])
          {
              min++;
          }
          else
          {
              max++;
          }

          Console.WriteLine("\nEl promedio de estatura es: " +b);
          Console.WriteLine("\nPersonas que son mas altas que el promedio: "+ max);
          Console.WriteLine("\nPersonas que son mas bajas o igual que el promedio: "+min );

          */
            
            
            //9-Crear una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.
            /*Multi();*/

            
            
            //10-Confeccionar una clase que permita carga el nombre y la edad de una persona. Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18)
            /*Dativiri();*/








        }
    }
}
