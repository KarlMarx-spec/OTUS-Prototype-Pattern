namespace OTUS_Prototype_Pattern
{
    public interface IMyCloneable<T> where T : class
    {
        T Clone();
    }
}
