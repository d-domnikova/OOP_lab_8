class Box<T>
{
    public T value { get; set; }
    int n;

    public Box(T value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return $"{value.GetType().FullName}: {value}";
    }

    public int compareByValue<T>(List<Box<T>> list, T value)
    {
        foreach (Box<T> element in list)
        {
           if( Comparer<T>.Default.Compare(element.value, value) > 0) n++ ; 
        }
        return n ;
    }
}