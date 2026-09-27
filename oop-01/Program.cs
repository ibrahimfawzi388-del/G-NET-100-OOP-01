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

            #region Question_02
            //a) Identify at least three problems with this design from an encapsulation perspective.
            //All fields are public, so they can be accessed and modified directly.
            //There is no validation to prevent invalid values.
            //The data is not protected, which violates encapsulation.
            //b) How can private fields and public properties improve this design?
            // Make the fields private and use public properties to control access to the data and validate values before modifying them
            #endregion

            #region Create one DeliveryAddress value, copy it into a second variable, modify the copy, and print both values to prove that the original did not change.

            //DeliveryAddress address = new DeliveryAddress("sohag", "elzahraa", 17);
            //DeliveryAddress addresscopy = address;
            //addresscopy.City = "cairo";
            //addresscopy.Street = "tttttttt";
            //addresscopy.BuildingNumber = 10;
            //Console.WriteLine(address.GetFullAddress());
            //Console.WriteLine(addresscopy.GetFullAddress());
            #endregion
        }
    }
}
