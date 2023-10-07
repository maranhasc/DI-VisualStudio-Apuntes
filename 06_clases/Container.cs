public class Container{
 private int  _capacity;

 public Container(int capacity) => _capacity = capacity;

    public override string ToString(){
        return $"Contenedor con capacidad: {_capacity}";
    }

    //metodo getter 
    //public int GetCapacity(){
      //  return _capacity;
    //}
    public int GetCapacity() => this._capacity;



    //metodo setter
  //  public void SetCapacity(int capacity){
    //    _capacity = capacity;

    //}s
    public void SetCapacity(int capacity) => this._capacity = capacity;

 

}