namespace ConsoleApp.Tests
{
    [TestFixture]
    public class HelloWorldServiceTests
    {
        private HelloWorldService _helloWorldService;

        [SetUp]
        public void SetUp()
        {
            _helloWorldService = new HelloWorldService();
        }

        [Test]
        public void IsHelloWorld()
        {
            var result = _helloWorldService.GetHelloWorld();

            Assert.That("Hello World!", Is.EqualTo(result));
        }
    }
}