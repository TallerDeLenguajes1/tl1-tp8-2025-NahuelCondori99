namespace Tareas;

public class Tarea 
{
    private int tareaId;
    private string descripcion;
    private int duracion;

    public Tarea(int tareaId, string descripcion, int duracion)
    {
        this.tareaId = tareaId;
        this.descripcion = descripcion;
        this.duracion = duracion;
    }

    public int TareaId { get => tareaId; set => tareaId = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; 
        set{
        if(value >10 || value <100)
        {
            duracion = value;
        }
    } }

    public void MostrarTareas()
    {
        Console.WriteLine("Tarea ID: " + tareaId);
        Console.WriteLine("Descripcion de la tarea: " + descripcion);
        Console.WriteLine("Duracion: " + duracion + " minutos");
        Console.WriteLine("--------------------------");
    }

    
    
    /*Validar que esté entre 10 y 100 Puedes añadir un constructor y métodos auxiliares si lo consideras necesario*/
}