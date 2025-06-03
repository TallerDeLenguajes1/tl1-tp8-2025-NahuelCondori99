using Tareas;

//Cargo mis datos

Tarea[] misTareas = new Tarea[3];


    misTareas[0]= new Tarea(1, "Lavar la fruta", 12);
    misTareas[1]= new Tarea(2, "Lavar", 20);
    misTareas[2]= new Tarea(3, "programar", 10);
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

foreach (var item in TareasPendientes)
{
    Console.WriteLine("Tarea ID: " + item.TareaId);
    Console.WriteLine("Descripcion: " + item.Descripcion);
    Console.WriteLine("Duracion: " + item.Duracion);
}

