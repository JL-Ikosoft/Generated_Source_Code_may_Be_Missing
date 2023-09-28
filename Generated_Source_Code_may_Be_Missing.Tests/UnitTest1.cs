namespace Generated_Source_Code_may_Be_Missing.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            PersonEntity personEntity = new() { FirstName = "John" };

            PersonDto personDto = personEntity.ToPersonDto();

            Assert.NotNull(personDto);
            Assert.Equal(personDto.FirstName, personEntity.FirstName);
        }
    }
}