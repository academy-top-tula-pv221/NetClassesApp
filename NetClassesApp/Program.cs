namespace NetClassesApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address()
            {
                city = "Moscow",
                street = "Tverskaya"
            };

            address.Write();

            AddressWork(ref address);

            address.Write();

            //Address address2 = address;
            //address2.city = "Tula";
            //address.Write();

            //PersonStruct person1 = new() { name = "Bob", age = 23, address = address };
            //person1.Write();
            //person1.address.Write();

            //PersonStruct person2 = person1;
            //person2.name = "Joe";
            //person2.address.city = "Tula";

            //person1.Write();
            //person1.address.Write();
        }

        static void AddressWork(ref Address address)
        {
            address.city = "Orel";
            address = new Address() { city = "Ufa", street = "Lenina" };
            address.Write();
        }
    }
}