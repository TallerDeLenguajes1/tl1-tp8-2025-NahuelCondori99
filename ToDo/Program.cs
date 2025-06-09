using Tareas;

//Creo mis listas
List<Tarea> TareasPendientes = new List<Tarea>
{
    new Tarea(1, "Programar en C#", 12),
    new Tarea(2, "Llorar porque no me sale", 20),
    new Tarea(3, "Reirme de la situacion", 10),
    new Tarea(4, "Realizar la buena practica en C#", 30)
};

List<Tarea> TareasRealizadas = new List<Tarea>();

Console.WriteLine("-------------------------");

int seguir = 1;

while (seguir != 0)
{
    Console.WriteLine("-----MENU-----\n1-Ingresar ID para mover tarea pendiente a realizada.\n2-Buscar tarea por descripcion.\n3-Mostrar tareas Pendientes.\n4-Mostrar tareas Realizadas.\n0-Finalizar.\nIngresar opcion: ");
    int opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            Console.WriteLine("Ingrese la ID de la tarea que ya realizo: ");
            string idMov = Console.ReadLine();
            int idMover = int.Parse(idMov);

            for (int i = 0; i < 3; i++)//Usar un for no el foreach
            {
                if (idMover == TareasPendientes[i].TareaId)
                {
                    TareasRealizadas.Add(TareasPendientes[i]);
                    TareasPendientes.RemoveAt(i);
                }
            }
            break;
        case 2:
            static void BuscarxDescripcion(List<Tarea> TareasPendientes)
            {
                Console.WriteLine("Ingrese descripcion de la tarea pendiente para iniciar la busqueda:");
                string descripB = Console.ReadLine();
                bool encontrado = false;

                foreach (Tarea descrip in TareasPendientes)
                {
                    if (descrip.Descripcion.Contains(descripB, StringComparison.OrdinalIgnoreCase) && descrip.Descripcion != null)
                    {
                        descrip.MostrarTareas();
                        encontrado = true;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No hay tareas pendientes con esa descripcion.");
                }
            }

            BuscarxDescripcion(TareasPendientes);
            break;
        case 3:
            foreach (Tarea TareaP in TareasPendientes)
            {
                Console.WriteLine("Tarea ID: " + TareaP.TareaId);
                Console.WriteLine("Descripcion: " + TareaP.Descripcion);
                Console.WriteLine("Duracion: " + TareaP.Duracion + " minutos");
            }

            Console.WriteLine("-------------------------");
            break;
        case 4:
            foreach (Tarea TareaR in TareasRealizadas)
            {
                Console.WriteLine("Tarea ID: " + TareaR.TareaId);
                Console.WriteLine("Descripcion: " + TareaR.Descripcion);
                Console.WriteLine("Duracion: " + TareaR.Duracion + " minutos");
            }
            break;
        case 0:
            break;
    }
    Console.WriteLine("Ingresar 0 para salir.");
    int seguir1 = int.Parse(Console.ReadLine());
    seguir = seguir1;
}