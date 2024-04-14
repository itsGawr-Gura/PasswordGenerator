using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator;

namespace PasswordGeneratorTests
{
    [TestClass]
    public class PassGenTests
    {
        [TestMethod]
        public void PassGenerate_GeneratePassword_ReturnPassword()
        {
            //
            int len = 8;
            bool remSim = false;
            bool remSpec = false;
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.GeneratePassword(len, remSim, remSpec);
            //

            result.Should().NotBeNull();
        }
        [TestMethod]
        public void PassGenerate_GeneratePassword_ReturnPassword6()
        {
            //
            int len = 100;
            bool remSim = false;
            bool remSpec = false;
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.GeneratePassword(len, remSim, remSpec);
            //

            result.Should().NotBeNull();
        }
        [TestMethod]
        public void PassGenerate_GeneratePassword_ReturnPassword7()
        {
            //
            int len = 1;
            bool remSim = false;
            bool remSpec = false;
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.GeneratePassword(len, remSim, remSpec);
            //

            result.Should().NotBeNull();
        }
        [TestMethod]
        public void PassGenerate_GeneratePassword_ReturnPassword1()
        {
            //
            int len = 8;
            bool remSim = false;
            bool remSpec = false;
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.GeneratePassword(len, remSim, remSpec);
            //
            result.Should().HaveLength(len);
        }
        [TestMethod]
        public void PassGenerate_GeneratePassword_ReturnPassword2()
        {
            //
            int len = 8;
            bool remSim = false;
            bool remSpec = false;
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.GeneratePassword(len, remSim, remSpec);
            //
            result.Should().NotBeNullOrWhiteSpace();
        }
        [TestMethod]
        public void PassGenerate_GeneratePassword_ReturnPassword3()
        {
            //
            int len = 8;
            bool remSim = false;
            bool remSpec = true;
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.GeneratePassword(len, remSim, remSpec);
            //
            result.Should().NotContainAny("}", "{", "[", "]", "(", ")", "/", "\\", "\'", "\"", "`", "~", ",", ";", ":", ".", "<", ">");
        }
        [TestMethod]
        public void PassGenerate_GeneratePassword_ReturnPassword4()
        {
            //
            int len = 8;
            bool remSim = true;
            bool remSpec = false;
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.GeneratePassword(len, remSim, remSpec);
            //
            result.Should().NotContainAny("i", "l", "1", "L", "o", "0", "O");
        }
        [TestMethod]
        public void PassGenerate_GeneratePassword_ReturnPassword5()
        {
            //
            int len = 8;
            bool remSim = true;
            bool remSpec = true;
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.GeneratePassword(len, remSim, remSpec);
            //
            result.Should().NotContainAny("}", "{", "[", "]", "(", ")", "/", "\\", "\'", "\"", "`", "~", ",", ";", ":", ".", "<", ">", "i", "l", "1", "L", "o", "0", "O");
        }
        [TestMethod]
        public void PassGenerate_IsPassDupl_ReturnTrue()
        {
            //
            string password = "naruto";
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.IsPassDupl(password);
            //
            result.Should().BeTrue();
        }
        [TestMethod]
        public void PassGenerate_IsPassDupl_ReturnFalse()
        {
            //
            string password = "yge322791j'];/";
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.IsPassDupl(password);
            //
            result.Should().BeFalse();
        }
        [TestMethod]
        public void PassGenerate_IsPassDupl_ReturnTrue1()
        {
            //
            string password = "thinkup1";
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.IsPassDupl(password);
            //
            result.Should().BeTrue();
        }
        [TestMethod]
        public void PassGenerate_IsPassDupl_ReturnTrue2()
        {
            //
            string password = "mitchrobin14";
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.IsPassDupl(password);
            //
            result.Should().BeTrue();
        }
        [TestMethod]
        public void PassGenerate_IsPassDupl_ReturnTrue3()
        {
            //
            string password = "janell15";
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.IsPassDupl(password);
            //
            result.Should().BeTrue();
        }
        [TestMethod]
        public void PassGenerate_IsPassDupl_ReturnTrue4()
        {
            //
            string password = "blackilla";
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.IsPassDupl(password);
            //
            result.Should().BeTrue();
        }
        [TestMethod]
        public void PassGenerate_IsPassDupl_ReturnTrue5()
        {
            //
            string password = "2kidsjordydemy";
            var generatePassWord = new PassGenerate();
            //
            var result = generatePassWord.IsPassDupl(password);
            //
            result.Should().BeTrue();
        }








    }
}
