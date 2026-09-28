namespace oop_01
{
    internal class Program
    {
        public static int numofelement = 0;
        public static void adddata(Shipment shipment,DeliveryAddress deliveryAddress,DeliveryCenter deliveryCenter)
        {
            Console.WriteLine($"Enter Shipment {++numofelement} Data");
            Console.Write($"Tracking Code : ");
            shipment.trackingcode = Console.ReadLine();
            Console.Write($"Description : ");
            shipment.description = Console.ReadLine();
            Console.Write($"Weight : ");
            shipment.weight = int.Parse(Console.ReadLine());
            Console.Write($"Delivery Fee : ");
            shipment.deliveryfee = int.Parse(Console.ReadLine());
            Console.Write($"City : ");
            deliveryAddress.City = Console.ReadLine();
            Console.Write($"Street : ");
            deliveryAddress.Street = Console.ReadLine();
            Console.Write($"Bulding Number : ");
            deliveryAddress.BuildingNumber = int.Parse(Console.ReadLine());
            shipment.Destination = deliveryAddress;
            if (deliveryCenter.AddShipment(shipment))
            {
                Console.WriteLine("Shipment added successfully.");
            }
            else
            {
                numofelement--;
                Console.WriteLine("No Place available");
            }
        }

        public static void printallelemnt(DeliveryCenter deliveryCenter)
        {
            for (int i = 0; i < numofelement; i++)
            {
                Shipment shipment2 = deliveryCenter[i];

                Console.WriteLine($"Tracking Code : {shipment2.trackingcode}");
                Console.WriteLine($"Description : {shipment2.description}");
                Console.WriteLine($"Wieght : {shipment2.weight}");
                Console.WriteLine($"Delivery Fee :{shipment2.deliveryfee}");
                Console.WriteLine($"Destination : {shipment2.Destination.GetFullAddress()}");
                Console.WriteLine($"Estimated Cost : {shipment2.EstimatedCost}");
            }
        }

        public static void searchbycode(DeliveryCenter deliveryCenter)
        {
            Console.WriteLine("enter a tracking code to search : ");
            Shipment shipment1 = deliveryCenter[Console.ReadLine()];
            if (shipment1.description != null)
            {
                Console.WriteLine($"Shipment found : {shipment1.trackingcode} - {shipment1.description}");
            }
            else
            {
                Console.WriteLine("Shipment is not found");
            }
        }

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

            #region  Console Application

            //DeliveryCenter deliveryCenter=new DeliveryCenter();
            //Shipment shipment=new Shipment();
            //DeliveryAddress deliveryAddress=new DeliveryAddress();

            //int choice;
            //do
            //{
            //    adddata(shipment, deliveryAddress, deliveryCenter);
            //    Console.WriteLine();
            //    Console.WriteLine("Do you want to continue? Enter 1 for yes or 0 for NO");
            //    choice = int.Parse(Console.ReadLine());
            //}
            //while (choice == 1);
            //Console.WriteLine();
            //Console.WriteLine("if you want print all shipments enter 1 for print or 0 to exit");

            //if(int.Parse(Console.ReadLine())==1)
            //{
            //    printallelemnt(deliveryCenter);
            //}
            //Console.WriteLine();
            //Console.WriteLine("if you want Search for the shipment using code enter 1 to continue or 0 to exit");
            //while (int.Parse(Console.ReadLine())==1)
            //{
            //    searchbycode(deliveryCenter);
            //    Console.WriteLine();
            //    Console.WriteLine("Do you want to continue? Enter 1 for yes or 0 for NO");
            //}
            #endregion

            #region Demonstrate the DeliveryAddress struct copy behavior.

            //DeliveryAddress original = new DeliveryAddress("Cairo", "Tahrir Street", 10);

            //DeliveryAddress copy = original;
            //copy.City = "Alexandria";

            //Console.WriteLine(original.City);
            //Console.WriteLine(copy.City);
            #endregion
        }
    }
}
