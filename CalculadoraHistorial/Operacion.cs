namespace HistorialOperacion;

    public enum TipoOperacion
    {
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar   //Representa la acción de borrar el resultado actual o el historial
    }

public class Operaciones
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    public Operaciones(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }

    public double ResultadoAnterior { get => resultadoAnterior; }
    public double NuevoValor { get => nuevoValor; }
    public TipoOperacion Operacion { get => operacion; }
    
    public double Resultado
    {
        get
        {
            return operacion switch
            {
                TipoOperacion.Suma => resultadoAnterior + nuevoValor,
                TipoOperacion.Resta => resultadoAnterior - nuevoValor,
                TipoOperacion.Multiplicacion => resultadoAnterior * nuevoValor,
                TipoOperacion.Division => nuevoValor != 0 ? resultadoAnterior / nuevoValor : throw new DivideByZeroException("No se puede dividir por cero."),
                TipoOperacion.Limpiar => 0,
                _ => throw new InvalidOperationException("Operación no válida.")
            };
        }
    }
}
