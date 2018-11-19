namespace FacadePattern
{
    public interface IShoppingCart<T>
    {
        T AddItem(T item);
        bool RemoveItem(T item);
    }
}
