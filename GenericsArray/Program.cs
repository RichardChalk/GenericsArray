namespace GenericsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ///////////////////////////////////////////////////////
            Console.WriteLine("Generic Method");
            Console.WriteLine("==============");
            
            // Int
            var intArr = new ArraysGeneric().CreateArrayGeneric(45, 98);
            foreach (var num in intArr)
                Console.WriteLine(num);
            // Double
            var doubleArr = new ArraysGeneric().CreateArrayGeneric(45.3, 98.7);
            foreach (var num in doubleArr)
                Console.WriteLine(num);
            // String
            var stringArr = new ArraysGeneric().CreateArrayGeneric("Richard", "Stefan");
            foreach (var name in stringArr)
                Console.WriteLine(name);

            // ///////////////////////////////////////////////////////
            Console.WriteLine("\nMethod Overloading");
            Console.WriteLine("==================");

            // Int Generic
            var intArrGen = new ArraysGeneric().CreateArray(45, 98);
            foreach (var num in intArr)
                Console.WriteLine(num);
            // Double
            var doubleArrGen = new ArraysGeneric().CreateArray(45.3, 98.7);
            foreach (var num in doubleArr)
                Console.WriteLine(num);
            // String
            var stringArrGen = new ArraysGeneric().CreateArray("Richard", "Stefan");
            foreach (var name in stringArr)
                Console.WriteLine(name);
        }
    }
}