class Program
{
    static void Main(string[] args)
    {
        GestorTareas gestorTareas = new GestorTareas();
        Dictionary<int, Tarea> dicTareas2;
        dicTareas2 = gestorTareas.gGetDicTareas();
       int menu;
        do
        {
        menu = ingresarNumero("ingresa el numero de lo que quieras hacer (Agregar nuevas tareas(1), Buscar una tarea por su Id(2), Marcar una tarea como completada(3), Mostrar todas las tareas(3) Mostrar la cantidad de tareas pendientes(4))");
        switch(menu) 
        {
            case 1: 
                GestorTareas.AgregarTarea(ingresarNumero("Ingrese el Id"),ingresarTexto("Ingrese la descripcion"),ingresarTexto("Ingrese si esta completa o no"));
            break;

            case 2: 
                
            break;

            case 3: 
             foreach (Tarea item in dicTareas2){
             console.WriteLine("tarea: "+item.getID()+" "+item.getDesc()+" "+" "+item.getcCompletada()+" esta completa");}
             break;

            case 4:
                
            break;

            case 5:

            break;

        }
        }while(menu != 6);
    }
   
     static int ingresarNumero(string mensaje) 
     {
     int numero;
     bool pude;
     Console.WriteLine(mensaje);
     do
     {
         pude = int.TryParse(Console.ReadLine(), out numero);
         if (pude == false)
         {
             Console.WriteLine("debes poner un numero!!");
         }
     } while (pude == false);

     return numero;
     }
  
     static string ingresarTexto(string mensaje)
 {
     string texto;
     do
     {
         Console.WriteLine(mensaje);
         texto = Console.ReadLine();
         if (texto == null)
         {
             Console.WriteLine("ingresa el texto nuevamente");
         }
     }while(texto == null);
    
     return texto;
 }

 static double ingresarNumeroConComa(string mensaje)
 {
     double numeroConDecimales;
     bool pude;
     Console.WriteLine(mensaje);
     do
     {
         pude = double.TryParse(Console.ReadLine(), out numeroConDecimales);
         if (pude == false)
         {
             Console.WriteLine("debes ingresar una letra");
         }
     } while (pude == false);
     return numeroConDecimales;
 }

}