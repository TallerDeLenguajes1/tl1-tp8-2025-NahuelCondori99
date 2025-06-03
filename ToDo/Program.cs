using Tareas;

//Cargo mis datos

Tarea[] misTareas = new Tarea[3];

//No hace falta hacer el arreglo de tareas, puedo hacerlo directamente con la lista
    misTareas[0]= new Tarea(1, "Programar en C#", 12);
    misTareas[1]= new Tarea(2, "Llorar porque no me sale", 20);
    misTareas[2]= new Tarea(3, "Reirme de la situacion", 10);
    /*Console.WriteLine("Ingresar Descripcion:");
    descrip = Console.ReadLine();
    Console.WriteLine("Ingresar duracion:");
    dura = int.Parse(Console.ReadLine());
    id = i+1;
    misTareas[i] = new Tarea(tareaId, descripcion, duracion); */


//Creo mis listas
List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();

for (int i = 0; i < 3; i++)
{
    TareasPendientes.Add(misTareas[i]);

}

Console.WriteLine("Ingrese la ID de la tarea que ya realizo: ");
string idMov = Console.ReadLine();
int idMover = int.Parse(idMov);

foreach (Tarea tareaBus in TareasPendientes)
{
    if (idMover == tareaBus.TareaId)
    {
        TareasRealizadas.Add(tareaBus);
        TareasPendientes.Remove(tareaBus);
    }
}

foreach (var TareaP in TareasPendientes)
{
    Console.WriteLine("Tarea ID: " + TareaP.TareaId);
    Console.WriteLine("Descripcion: " + TareaP.Descripcion);
    Console.WriteLine("Duracion: " + TareaP.Duracion + " minutos");
}

Console.WriteLine("-------------------------");

/*
foreach (var item in TareasRealizadas)
{
    Console.WriteLine("Tarea ID: " + item.TareaId);
    Console.WriteLine("Descripcion: " + item.Descripcion);
    Console.WriteLine("Duracion: " + item.Duracion);
}
*/
