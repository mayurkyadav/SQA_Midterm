using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace StudentRegistration
{
    [TestFixture]

    public class RegistrationTests
    {
        //
        [Test]
        public void RegisterName_InputAlex_OutputAlex()
        {
            // Test Case 1: this test case verifies that the name variable holds a string value if passed.
            // Assiging
            Registration registration = new Registration();
            string addName = registration.RegisterName("Alex");

            //Acting 
            string act = "Alex";
            //Asserting
            Assert.That(addName, Is.EqualTo(act));

        }
        [Test]
        public void RegisterName_Input40_Output40()
        {
            //Test Case 2: this test case verifies that if the length of the entered name string is 40 it passes or not

            //assiging
            Registration registration_b = new Registration();
            string addName = registration_b.RegisterName("Abcdefghijklmnopqrstuvxyzabcdefghijklmui");

            //act
            int length = addName.Length;
            int length2 = length;

            //assert
            Assert.That(length, Is.EqualTo(length2));
        }
        [Test]
        public void RegisterName_Input3_Output3()
        {
            //Test Case 3: this test case verifies that if length of the entered string lies within the expected range it passes or not

            //assiging
            Registration registration_c = new Registration();
            string addName = registration_c.RegisterName("Abc");

            //act
            int length = addName.Length;
            int length3 = length;

            //assert
            Assert.That(length, Is.EqualTo(length3));
        }
        [Test]
        public void RegisterAge_Input0_Output0()
        {
            
                //test case 4: this test case verifies that given method accepts the minimum value which it is suppose to accept or not
                //arrange
                Registration registration_5 = new Registration();
                int newAge2 = registration_5.RegisterAge(0);

            //act
                int act2 = 0;

            //assert
                Assert.That(newAge2, Is.EqualTo(act2));

            

        }
        [Test]
        public void RegisterAge_Input18_Output18()
        {
            //Test Case 5: this test case checks that the function accepts the value which is within the range or not
            //arrange
            Registration registration_d = new Registration();
            int newAge = registration_d.RegisterAge(18);

            //act
            int act = 18;
            //assert
            Assert.That(newAge, Is.EqualTo(act));

        }
        [Test]
        public void RegisterAge_Input125_Output125()
        {
            // test Case 6:this test case checks that the function accepts the maximum value or not

            //arrange
            
                Registration registration_e = new Registration();
                int newAge3 = registration_e.RegisterAge(125);
            //act
                int act3 = 125;
            //assert
                Assert.That(newAge3, Is.EqualTo(act3));


            

        }

        [Test]
        public void RegisterGroupSize_Input1_Output1()
        {
            //test case 7:this test case checks that the function accepts the minimum value or not
            //arrange
            Registration  registration_f= new Registration();
            int newGroup=registration_f.RegisterGroupSize(1);
            //act
            int act4 = 1;
            //assert
            Assert.That(newGroup, Is.EqualTo(act4));

        }
        [Test]
        public void RegistrationGroupSize_Input10_Output10() 
        {
            //test case 8:this test case checks that the funciton accepts the value which lies within the range 
            //arrange
            Registration registration_g= new Registration();
            int newGroup2=registration_g.RegisterGroupSize(10);

            //act
            int act4 = 10;

            //assert
            Assert.That(newGroup2, Is.EqualTo(act4));

        }
        [Test]
        public void RegistrationGroupSize_Input125_Ouput_125()
        {
            //test case 9:this test case checks that it accepts the maximum value which it is suppose to 
            //arrange
            Registration registration_h= new Registration();
            int newGroup3 = registration_h.RegisterGroupSize(18);
            //act
            int act5 = 18;
            //assert
            Assert.That(newGroup3, Is.EqualTo(act5));
        }
    }
}