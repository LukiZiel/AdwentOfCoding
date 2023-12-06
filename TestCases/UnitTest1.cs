//using DayOnePartTwo;

//namespace TestCases
//{
//    public class CalibrationTests
//    {
      
//        [Test]
//        [TestCase("1abc2", 12)]
//        [TestCase("pqr3stu8vwx", 38)]
//        [TestCase("a1b2c3d4e5f", 15)]
//        [TestCase("treb7uchet", 77)]
//        [TestCase("two2nine33dfsdoneeight5", 25)]
//        [TestCase("2twofourrbldqvfkvgzqrblmrkzr", 24)]
//        [TestCase("fivevdhgg5two1hpnjlvkeighttwo", 52)]
//        [TestCase("kdzd2dxknpninethnpktjdsskgzpseven", 27)]
//        [TestCase("4nine4", 44)]
//        [TestCase("sixrmzqqxzeightxzglghnnkfmvrlgfoursix4", 64)]
//        public void TestExtractDigits(string line, int expected)
//        {
//            Assert.That(Methods.ExtractDigit(line), Is.EqualTo(expected));

//        }

//        [Test]
//        public void CalculationTest1()
//        {
//            List<string> list = new List<string>
//            {
//                "two1nine",
//                "eightwothree",
//                "abcone2threexyz",
//                "xtwone3four",
//                "4nineeightseven2",
//                "zoneight234",
//                "7pqrstsixteen"
//            };
//            Assert.That(Methods.CalculateResult(list), Is.EqualTo(281));
//        }
//        [Test]
//        public void CalculationTest2()
//        {
//            List<string> list = new List<string>
//            {
//                "1abc2",
//                "pqr3stu8vwx",
//                "a1b2c3d4e5f",
//                "treb7uchet",
//                "two1nine",
//                "eightwothree",
//                "abcone2threexyz",
//                "xtwone3four",
//                "4nineeightseven2",
//                "zoneight234",
//                "7pqrstsixteen"
//            };
//            Assert.That(Methods.CalculateResult(list), Is.EqualTo(423));
//        }
//        [Test]
//        public void CalculationTest3()
//        {
//            List<string> list = new List<string>
//            {
//                "1abc2",
//                "pqr3stu8vwx",
//                "a1b2c3d4e5f",
//                "treb7uchet",
//                "two1nine",
//                "eightwothree",
//                "abcone2threexyz",
//                "xtwone3four",
//                "4nineeightseven2",
//                "zoneight234",
//                "7pqrstsixteen",
//                "one1two",
//                "three3four",
//                "five5six",
//                "seven7eight",
//                "nine9zero"
//            };
//            Assert.That(Methods.CalculateResult(list), Is.EqualTo(563));
//        }
//        [Test]
//        public void CalculationTest4()
//        {
//            List<string> list = new List<string>
//            {
//               "one1two", //12
//               "three3four",//34
//               "five5six",//56
//               "seven7eight",//78
//               "nine9zero"//90
//            };
//            Assert.That(Methods.CalculateResult(list), Is.EqualTo(270));
//        }
//        [Test]
//        public void CalculationTest5()
//        {
//            List<string> list = new List<string>
//            { 
//                "1abc2",
//                "pqr3stu8vwx",
//                "a1b2c3d4e5f",
//                "treb7uchet"
//            };
//            Assert.That(Methods.CalculateResult(list), Is.EqualTo(142));
//        }

//    }
//}