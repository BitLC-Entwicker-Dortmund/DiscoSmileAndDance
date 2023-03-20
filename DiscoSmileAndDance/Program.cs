namespace DiscoSmileAndDance {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Disco!");
            Person einePerson = new Person();

            Console.WriteLine(einePerson.GetHashCode());

            Disco unsereDisco = new Disco();

            unsereDisco.NimmAuf(einePerson);

            Person zurueck = unsereDisco.GehRaus();

            Console.WriteLine(  zurueck.GetHashCode()); // aus Disco
            Console.ReadLine();
        }
    }
}