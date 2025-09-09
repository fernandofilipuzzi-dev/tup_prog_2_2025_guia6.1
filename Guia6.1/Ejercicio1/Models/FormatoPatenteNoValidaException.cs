
namespace Ejercicio1.Models;

public class FormatoPatenteNoValidaException:ApplicationException
{
    public FormatoPatenteNoValidaException() : base("Formato patente no válido") { }

    public FormatoPatenteNoValidaException(string message) : base(message) { }

    public FormatoPatenteNoValidaException(string message, Exception innerException) : base(message, innerException) { }
}
