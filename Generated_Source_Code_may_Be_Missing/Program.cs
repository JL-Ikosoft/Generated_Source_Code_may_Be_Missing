using Riok.Mapperly.Abstractions;

namespace Generated_Source_Code_may_Be_Missing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class PersonDto
    {
        public string? FirstName { get; set; }
    }

    public class PersonEntity
    {
        public string? FirstName { get; set; }
    }

    [Mapper(UseReferenceHandling = true)]
    public static partial class ExtMapper
    {
        public static partial PersonDto ToPersonDto(this PersonEntity obj);
    }

}
