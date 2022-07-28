namespace GastosORT.Data;

public class SystemData
{
    public List<Gasto> ListaGastos { get; set; } = new List<Gasto>();

    public List<Categoria> ListaCategorias {get; set;} = new List<Categoria>();

    public SystemData()
    {
        this.SeedCategorias();
        this.SeedGastos();
    }

    private void SeedGastos()
    {
        string[] Categorias = new[]{ "Noche", "Personal", "Comida", "Casa", "Otros",};
        string[] Comentarios = new[]{ "H&M", "Super Ivan", "VMN", "Alquiler", "UTE", };

        DateTime startDate = DateTime.Now;
        for (int index=0; index<6; index++){
            Gasto item = new Gasto();
            item.Id = index;
            item.Fecha = startDate.AddDays(index);
            item.Valor = (100+index)*index;
            item.Categoria = ListaCategorias[index%(Categorias.Length)];
            item.Comentario = Comentarios[index%(Comentarios.Length)];
            
            ListaGastos.Add(item);
        }
    }
     private void SeedCategorias()
    {
        string[] Categorias = new[]{ "Noche", "Personal", "Comida", "Casa", "Otros",};

        for (int index=0; index<Categorias.Length; index++){
            Categoria item = new Categoria();
            item.Id = index;
            item.Nombre = Categorias[index];
        
            ListaCategorias.Add(item);
        }
    }

    public Gasto GetSingleGasto(int id)
    {
        return ListaGastos.Find(gasto => gasto.Id == id);
    }

    public void CreateGasto(Gasto newGasto)
    {
        ListaGastos.Add(newGasto);
    }

    public void UpdateGasto(Gasto gasto, int Id)
    {
        Gasto toEdit = GetSingleGasto(Id);

        toEdit.Fecha = gasto.Fecha;
        toEdit.Valor = gasto.Valor;
        toEdit.Categoria = gasto.Categoria;
        toEdit.Comentario = gasto.Comentario;
    }

    public void DeleteGasto(Gasto gasto)
    {
        ListaGastos.Remove(gasto);
    }


    public Categoria GetSingleCategoria(int id)
    {
        return ListaCategorias.Find(gasto => gasto.Id == id);
    }

}
