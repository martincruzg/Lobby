using System;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Lobby
{
    class Inputs
    {
/*        public static string GetName(string NameText)
        {
            if (string.IsNullOrEmpty(Window_CheckIn.TextBoxName.Text))
                NewMethod();



        }*/
/*            string? Name;
            while (true)
            {
                Console.Write("Enter a name: ");
                Name = Console.ReadLine();

                if (!string.IsNullOrEmpty(Name) && Regex.IsMatch(Name, @"^[a-zA-Z\s]+$"))
                {
                    break;
                }

                Console.WriteLine("Entrada inválida. Por favor, ingrese un nombre válido.");
            }

            return Name;
        }
*/
        /*        public static string GetName(string Name)
                {
                    while (true)
                    {
                        Console.Write("Enter a name: ");

                        if (!string.IsNullOrEmpty(Name) && Regex.IsMatch(Name, @"^[a-zA-Z\s]+$"))
                        {

                            break;
                        }

                        Console.WriteLine("Entrada inválida. Por favor, ingrese un nombre válido.");
                    }

                    return Name;
                }*/


        // public static int GetRoom()
        // {
        //     int Room = new int();
        //     Room = Console.Read();
        //     return 0;
        // }

        /*        public static int GetRoom()
                {
                    int room;
                    while (true)
                    {
                        Console.Write("Ingrese un número de habitación: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out room))
                        {
                            // Verificar si el valor ingresado está dentro del rango permitido
                            if (room >= 1 && room <= (HotelFeatures.Floors * HotelFeatures.RoomPerFloor))
                            {
                                // Restamos 1 al valor ingresado para obtener el índice del arreglo
                                // ya que los índices de los arreglos comienzan desde 0.
                                return room - 1;
                            }
                        }

                        // Si la entrada es inválida o está fuera del rango, mostrar mensaje de error y solicitar nuevamente.
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número de habitación válido.");
                    }
                }*/

        /*
                public static int GetNumGuests()
                {
                    int roomGuests;
                    while (true)
                    {
                        Console.Write("Ingrese la cantidad e huespedes: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out roomGuests))
                        {
                            // Verificar si el valor ingresado está dentro del rango permitido
                            if (0 < roomGuests && roomGuests < 5)
                            {
                                // Restamos 1 al valor ingresado para obtener el índice del arreglo
                                // ya que los índices de los arreglos comienzan desde 0.
                                return roomGuests;
                            }
                        }

                        // Si la entrada es inválida o está fuera del rango, mostrar mensaje de error y solicitar nuevamente.
                        Console.WriteLine("Entrada inválida. Los huspedes deben ser como minimo 1 y maximo 4");
                    }
                }*/
    }
}
