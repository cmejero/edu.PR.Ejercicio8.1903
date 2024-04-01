namespace edu.PR.Ejercicio6._1903
{
    internal class Program
    {
        static string rutaTextoUno = "C:\\Users\\Carlos\\Desktop\\Cs1\\PROGRAMACION\\ficheroParaActividades\\TextoUno.txt";
        static string rutaTextoDos = "C:\\Users\\Carlos\\Desktop\\Cs1\\PROGRAMACION\\ficheroParaActividades\\TextoDos.txt";
        static string rutaTextoTres = "C:\\Users\\Carlos\\Desktop\\Cs1\\PROGRAMACION\\ficheroParaActividades\\TextoTres.txt";


        static void Main(string[] args)
        {


            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                opcionUsuario = menuYSeleccion();

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Has seleccionado cerrar menu");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Has seleccionado texto uno");
                        menuTextoUno();
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado texto dos");
                        menuTextoDos();
                        break;
                    case 3:
                        Console.WriteLine("Has seleccionado texto tres");
                        menuTextoTres();
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no corresponde con ninguna");
                        break;
                }

            } while (!cerrarMenu);




        }

        static private int menuYSeleccion()
        {
            int opcionSeleccionada;
            Console.WriteLine("Elija una opción para modificar");
            Console.WriteLine("################################");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.texto uno");
            Console.WriteLine("2.texto dos");
            Console.WriteLine("3.texto tres");
            Console.WriteLine("################################");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;

        }


        static private void menuTextoUno()
        {
            if (File.Exists(rutaTextoUno))
            {

                int opcionUsuario;
                bool cerrarMenu = false;

                do
                {
                    opcionUsuario = menuYSeleccionTextoUno();

                    switch (opcionUsuario)
                    {
                        case 0:
                            Console.WriteLine("Has seleccionado volver");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("has indicado modificar línea");
                            modificarLineaTUno();
                            break;
                        case 2:
                            Console.WriteLine("Has seleccionado agregar texto en posicion especifica");
                            textoUnoPosicion();
                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada no corresponde con ninguna");
                            break;
                    }

                } while (!cerrarMenu);
            }
            else
            {
                Console.WriteLine("El fichero indicado no existe");
            }
        }


        static private int menuYSeleccionTextoUno()
        {
            int opcionSeleccionada;
            Console.WriteLine("Elija una opción");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Modificar línea");
            Console.WriteLine("2.Agregar texto en posición especifica");
            Console.WriteLine("_________________________________________");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;

        }


        static private void modificarLineaTUno()
        {
            using (StreamReader sr = new StreamReader(rutaTextoUno))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }
            Console.WriteLine("Introduzca el texto que deseas");

            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca la línea que deseas introducir el texto");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());

            try
            {

                string[] lineas = File.ReadAllLines(rutaTextoUno);


                if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                {

                    lineas[numeroLinea - 1] = textoUsuario;


                    File.WriteAllLines(rutaTextoUno, lineas);

                    Console.WriteLine("El texto se ha escrito correctamente en la línea especificada.");
                }
                else
                {
                    Console.WriteLine("El número de línea especificado está fuera del rango del archivo.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer/escribir el archivo: " + e.Message);
            }

            using (StreamReader sr = new StreamReader(rutaTextoUno))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }


        static private void textoUnoPosicion()
        {
            using (StreamReader sr = new StreamReader(rutaTextoUno))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");

            }

            Console.WriteLine("Introduzca el texto que deseas");
            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca la línea que deseas introducir el texto");
            int numLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca la posicion");
            int posicion = Convert.ToInt32(Console.ReadLine());

            try
            {
                string[] filas = File.ReadAllLines(rutaTextoUno);

                if (numLinea >= 1 && numLinea <= filas.Length)
                {
                    string linea = filas[numLinea - 1];

                    if (posicion >= 0 && posicion <= linea.Length)
                    {
                        string nuevaLinea = linea.Insert(posicion, textoUsuario);

                        filas[numLinea - 1] = nuevaLinea;

                        File.WriteAllLines(rutaTextoUno, filas);

                        Console.WriteLine("El texto ha sido introducido correctamente");
                    }
                    else
                    {
                        Console.WriteLine("la posicion indicada no corresponde con el texto");
                    }
                }
                else
                {
                    Console.WriteLine("la línea indicada no corresponde con el texto");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
            }
            using (StreamReader sr = new StreamReader(rutaTextoUno))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }





        }





        static private void menuTextoDos()
        {
            if (File.Exists(rutaTextoDos))
            {
                int opcionUsuario;
                bool cerrarMenu = false;

                do
                {
                    opcionUsuario = menuYSeleccionTextoUno();

                    switch (opcionUsuario)
                    {
                        case 0:
                            Console.WriteLine("Has seleccionado volver");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("has indicado modificar línea");
                            modificarLineaTDos();
                            break;
                        case 2:
                            Console.WriteLine("Has seleccionado agregar texto en posicion especifica");
                            textoUnoPosicion();
                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada no corresponde con ninguna");
                            break;
                    }

                } while (!cerrarMenu);
            }
            else
            {
                Console.WriteLine("El archivo indicado no existe");
            }
        }


        static private int menuYSeleccionTextoDos()
        {
            int opcionSeleccionada;
            Console.WriteLine("Elija una opción");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Modificar línea");
            Console.WriteLine("2.Agregar texto en posición especifica");
            Console.WriteLine("_________________________________________");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;

        }
        static private void modificarLineaTDos()
        {

            using (StreamReader sr = new StreamReader(rutaTextoDos))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }

            Console.WriteLine("Introduzca el texto que deseas");
            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca la línea que deseas introducir el texto");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());

            try
            {

                string[] lineas = File.ReadAllLines(rutaTextoUno);


                if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                {

                    lineas[numeroLinea - 1] = textoUsuario;


                    File.WriteAllLines(rutaTextoUno, lineas);

                    Console.WriteLine("El texto se ha escrito correctamente en la línea especificada.");
                }
                else
                {
                    Console.WriteLine("El número de línea especificado está fuera del rango del archivo.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer/escribir el archivo: " + e.Message);
            }

            using (StreamReader sr = new StreamReader(rutaTextoDos))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }




        static private void textoDosPosicion()
        {
            using (StreamReader sr = new StreamReader(rutaTextoDos))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }


            Console.WriteLine("Introduzca el texto que deseas");
            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca la línea que deseas introducir el texto");
            int numLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca la posicion");
            int posicion = Convert.ToInt32(Console.ReadLine());

            try
            {
                string[] filas = File.ReadAllLines(rutaTextoDos);

                if (numLinea >= 1 && numLinea <= filas.Length)
                {
                    string linea = filas[numLinea - 1];

                    if (posicion >= 0 && posicion <= linea.Length)
                    {
                        string nuevaLinea = linea.Insert(posicion, textoUsuario);

                        filas[numLinea - 1] = nuevaLinea;

                        File.WriteAllLines(rutaTextoDos, filas);

                        Console.WriteLine("El texto ha sido introducido correctamente");
                    }
                    else
                    {
                        Console.WriteLine("la posicion indicada no corresponde con el texto");
                    }
                }
                else
                {
                    Console.WriteLine("la línea indicada no corresponde con el texto");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
            }

            using (StreamReader sr = new StreamReader(rutaTextoDos))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }





        }


        static private void menuTextoTres()
        {
            if (File.Exists(rutaTextoUno))
            {
                int opcionUsuario;
                bool cerrarMenu = false;

                do
                {
                    opcionUsuario = menuYSeleccionTextoUno();

                    switch (opcionUsuario)
                    {
                        case 0:
                            Console.WriteLine("Has seleccionado volver");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("has indicado modificar línea");
                            modificarLineaTTres();
                            break;
                        case 2:
                            Console.WriteLine("Has seleccionado agregar texto en posicion especifica");
                            textoUnoPosicion();
                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada no corresponde con ninguna");
                            break;
                    }

                } while (!cerrarMenu);
            }
            else
            {
                Console.WriteLine("El archivo indicado no existe");
            }
        }


        static private int menuYSeleccionTextoTres()
        {
            int opcionSeleccionada;
            Console.WriteLine("Elija una opción");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Modificar línea");
            Console.WriteLine("2.Agregar texto en posición especifica");
            Console.WriteLine("_________________________________________");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;

        }
        static private void modificarLineaTTres()
        {
            using (StreamReader sr = new StreamReader(rutaTextoTres))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }


            Console.WriteLine("Introduzca el texto que deseas");
            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca la línea que deseas introducir el texto");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());

            try
            {

                string[] lineas = File.ReadAllLines(rutaTextoUno);


                if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                {

                    lineas[numeroLinea - 1] = textoUsuario;


                    File.WriteAllLines(rutaTextoUno, lineas);

                    Console.WriteLine("El texto se ha escrito correctamente en la línea especificada.");
                }
                else
                {
                    Console.WriteLine("El número de línea especificado está fuera del rango del archivo.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer/escribir el archivo: " + e.Message);
            }
            using (StreamReader sr = new StreamReader(rutaTextoTres))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }





        static private void textoTresPoscion()
        {
            using (StreamReader sr = new StreamReader(rutaTextoTres))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }


            Console.WriteLine("Introduzca el texto que deseas");
            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca la línea que deseas introducir el texto");
            int numLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca la posicion");
            int posicion = Convert.ToInt32(Console.ReadLine());

            try
            {
                string[] filas = File.ReadAllLines(rutaTextoTres);

                if (numLinea >= 1 && numLinea <= filas.Length)
                {
                    string linea = filas[numLinea - 1];

                    if (posicion >= 0 && posicion <= linea.Length)
                    {
                        string nuevaLinea = linea.Insert(posicion, textoUsuario);

                        filas[numLinea - 1] = nuevaLinea;

                        File.WriteAllLines(rutaTextoTres, filas);

                        Console.WriteLine("El texto ha sido introducido correctamente");
                    }
                    else
                    {
                        Console.WriteLine("la posicion indicada no corresponde con el texto");
                    }
                }
                else
                {
                    Console.WriteLine("la línea indicada no corresponde con el texto");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
            }
            using (StreamReader sr = new StreamReader(rutaTextoTres))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");
            }





        }
    }
}