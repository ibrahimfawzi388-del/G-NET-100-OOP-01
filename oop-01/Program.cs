namespace oop_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //DeliveryAddress(struct) is a value type so the value is copied into the new variable not the address Modifying the copy does not affect the original.
            //What happens when a Customer variable is copied into another variable and one variable modifies the object
            //Customer is a reference type(class) so the reference(address) is copied not the object itself.Both variables point to the same object, so modifying it through one variable affects the other.
            #endregion
        }
    }
}
