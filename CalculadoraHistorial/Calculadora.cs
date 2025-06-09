
using HistorialOperacion;
namespace EspacioCalculadora;

class Calculadora
{
    private double resultado;
    private List<Operaciones> historial;

    public Calculadora()
    {
        resultado = 0;
        historial = new List<Operaciones>();
    }

    public double Resultado => resultado;

    public void Sumar(double termino)
    {
        historial.Add(new Operaciones(resultado, termino, TipoOperacion.Suma));
        resultado += termino;
    }

    public void Restar(double termino)
    {
        historial.Add(new Operaciones(resultado, termino, TipoOperacion.Resta));
        resultado -= termino;
    }

    public void Multiplicar(double termino)
    {
        historial.Add(new Operaciones(resultado, termino, TipoOperacion.Multiplicacion));
        resultado *= termino;
    }

    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            historial.Add(new Operaciones(resultado, termino, TipoOperacion.Division));
            resultado /= termino;
        }
        else
        {
            Console.WriteLine("Error: no se puede dividir por cero.");
        }
    }

    public void Limpiar()
    {
        historial.Add(new Operaciones(resultado, 0, TipoOperacion.Limpiar));
        resultado = 0;
    }

    public void MostrarHistorial()
    {
        Console.WriteLine("\n--- Historial de Operaciones ---");
        foreach (var op in historial)
        {
            Console.WriteLine($"{op.Operacion} => {op.ResultadoAnterior} con {op.NuevoValor} = {op.Resultado}");
        }
    }
}
