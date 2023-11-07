namespace GenericsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ///////////////////////////////////////////////////////
            Console.WriteLine("Method Overloading");
            Console.WriteLine("==================");

            // Int
            var intArr = new ArraysGeneric().CreateArray(45, 98);
            foreach (var num in intArr)
                Console.WriteLine(num);
            // Double
            var doubleArr = new ArraysGeneric().CreateArray(45.3, 98.7);
            foreach (var num in doubleArr)
                Console.WriteLine(num);
            // String
            var stringArr = new ArraysGeneric().CreateArray("Richard", "Stefan");
            foreach (var name in stringArr)
                Console.WriteLine(name);

            // ///////////////////////////////////////////////////////
            Console.WriteLine("\nGeneric Method");
            Console.WriteLine("==============");

            // Int
            var intArrGen = new ArraysGeneric().CreateArrayGeneric(45, 98);
            foreach (var num in intArrGen)
                Console.WriteLine(num);
            // Double
            var doubleArrGen = new ArraysGeneric().CreateArrayGeneric(45.3, 98.7);
            foreach (var num in doubleArrGen)
                Console.WriteLine(num);
            // String
            var stringArrGen = new ArraysGeneric().CreateArrayGeneric("Richard", "Stefan");
            foreach (var name in stringArrGen)
                Console.WriteLine(name);

        }
    }
}