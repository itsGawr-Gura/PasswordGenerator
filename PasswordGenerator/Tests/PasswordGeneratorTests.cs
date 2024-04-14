using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;
using FluentAssertions;
using NUnit.Framework;

namespace PasswordGenerator.Tests
{
    public  class PasswordGeneratorTests
    {
        [Fact]
        public  void TestPasswordGenerator_GeneratePassword_ReturnPassword()
        {
            
                //
                int len = 8;
                bool remSim = false;
                bool remSpec = false;
                GeneratePassWord generatePassWord = new GeneratePassWord();
                //
                var result = generatePassWord.GeneratePassword(len, remSim, remSpec);
                //
                
                result.Should().NotBeNull();

            
        }
        
        /*public class Tests
        {
            [SetUp]
            public void SetUp() 
            {

            }
            [Test]
            public void Test1() 
            {
                Assert.Pass();
            }
        }
        */
    }
}
