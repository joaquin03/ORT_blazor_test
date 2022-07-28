namespace GastosORT.Data;

public class Gasto
{
    public int Id {get; set;}

    public DateTime Fecha { get; set; }

    public double Valor { get; set; }

    public Categoria Categoria {get; set; }

    public string? Comentario { get; set; }
}