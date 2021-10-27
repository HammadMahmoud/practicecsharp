public class Student{
    private int ID;
    private string Name;
    public Student(int ID, string Name){
        this.ID = ID;
        this.Name = Name;
    }
    public override string ToString()
    {
        return $"{ID}: {Name}";
    }
}