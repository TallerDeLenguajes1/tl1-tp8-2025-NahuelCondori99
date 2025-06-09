using Tareas;

//Cargo mis datos

//Tarea[] misTareas = new Tarea[3];

//No hace falta hacer el arreglo de tareas, puedo hacerlo directamente con la lista
    //misTareas[0]= new Tarea(1, "Programar en C#", 12);
    //misTareas[1]= new Tarea(2, "Llorar porque no me sale", 20);
    //misTareas[2]= new Tarea(3, "Reirme de la situacion", 10);

//Creo mis listas
List<Tarea> TareasPendientes = new List<Tarea>
{
    new Tarea(1, "Programar en C#", 12),
    new Tarea(2, "Llorar porque no me sale", 20),
    new Tarea(3, "Reirme de la situacion", 10),
    new Tarea(4, "Realizar la buena practica en C#", 30)
};


List<Tarea> TareasRealizadas = new List<Tarea>();

/*for (int i = 0; i < 3; i++)
{
    TareasPendientes.Add(misTareas[i]);

}*/

Console.WriteLine("Ingrese la ID de la tarea que ya realizo: ");
string idMov = Console.ReadLine();
int idMover = int.Parse(idMov);

for (int i = 0; i < 3; i++)//Usar un for no el foreach
{
    if (idMover == TareasPendientes[i].TareaId)
    {
        TareasRealizadas.Add(TareasPendientes[i]);
        TareasPendientes.RemoveAt(i);
        break;
    }
}

foreach (Tarea TareaP in TareasPendientes)
{
    Console.WriteLine("Tarea ID: " + TareaP.TareaId);
    Console.WriteLine("Descripcion: " + TareaP.Descripcion);
    Console.WriteLine("Duracion: " + TareaP.Duracion + " minutos");
}

Console.WriteLine("-------------------------");


foreach (Tarea TareaR in TareasRealizadas)
{
    Console.WriteLine("Tarea ID: " + TareaR.TareaId);
    Console.WriteLine("Descripcion: " + TareaR.Descripcion);
    Console.WriteLine("Duracion: " + TareaR.Duracion + " minutos");
}

Console.WriteLine("-------------------------");

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