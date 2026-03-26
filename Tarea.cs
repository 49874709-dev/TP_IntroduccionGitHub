public class Tarea
{
    private int ID;
    private string descripcion;  
    private bool completada;

    public Tarea(int ID, string descripcion, bool completada){
        this.ID = ID;
        this.descripcion = descripcion;
        this.completada = completada;
    }
    public int getID(){
        return ID;
    }
    public string getDesc(){
        return descripcion;
    }
    public bool getcCompletada(){
        return completada;
    }

}