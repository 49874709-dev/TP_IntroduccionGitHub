public class GestorTareas{
    Dictionary<int, Tarea> dicTareas = new Dictionary <int, Tarea>();
    Dictionary<int, Tarea> dicTareasDispo = new Dictionary <int, Tarea>();

    public GestorTareas(){
        tareas = new List<Tarea>();
        tareasDispo = new List<Tarea>();
    }

    public void AgregarNuevasTareas()
    {
        int numID = numeroSuma = 1;
        Tarea tareaAgregada = new Tarea( ID, descripcion, completada);
        dicTareas.Add(ID, tareaAgregada);
        numeroSuma++;
        
    }
        public Tarea BuscarTraea( int IDbuscar){
           
        return ;
    }
     public void MarcarTareaComoCompleta(){


    }
    public void MostrarTodasTareas(){

    }
    public void MostrarTareasPendientes(){

    }
}