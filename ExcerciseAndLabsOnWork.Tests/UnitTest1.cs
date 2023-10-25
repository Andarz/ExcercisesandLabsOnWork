using QueueNumbers;
namespace ExcerciseAndLabsOnWork.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPrintQueueNumbersMethod()
        {
            // Arrange            
            Queue<int> nums = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            string expected = "2, 4";
            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Перенаправляем вывод в StringWriter
                QueueNumbers.QueueNumbers.PrintEvenNumbers(nums);
                string actual = sw.ToString().Trim();
                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}