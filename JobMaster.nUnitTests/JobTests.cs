using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMaster.nUnitTests
{
    public class JobTests
    {
        //Arrange
        private Job _job;
        [SetUp]
        public void Setup()
        {
            _job = new Job(2001, 5, 2);
        }

        [Test]
        public void ToString_Test()
        {
            //Act --> Creating new job --> convert the job to string
            string result = _job.ToString();

            //Assert
            Assert.AreEqual(result, "ADR-2001, Process Time : 2, Due Date : 5", "ToString should return the correct string");
        }

        [TearDown]
        public void TearDown()
        {
            _job = null;
        }

    }
}
