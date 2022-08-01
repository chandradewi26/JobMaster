namespace JobMaster.nUnitTests
{
    public class JobsMasterTests
    {
        //Arrange
        private JobsMaster _jobsMaster;  
        [SetUp]
        public void AssignJobs()
        {
            _jobsMaster = new JobsMaster();
        }

        [Test]
        public void AddJobs_Test()
        {
            //Act
            _jobsMaster.AddJob(new Job(2001, 5, 2));
            _jobsMaster.AddJob(new Job(2002, 10, 3));

            Job _job0 = _jobsMaster.GetInitialJob(0);
            Job _job1 = _jobsMaster.GetInitialJob(1);

            //Assert
            Assert.AreEqual(5, _job0.DueDate, "-- _jobMasters[0] 's due date");
            Assert.AreEqual(2, _job1.ProcessingTime, "-- _jobMasters[0] 's processing time");
            Assert.AreEqual(10, _job0.DueDate, "-- _jobMasters[1] 's due date");
            Assert.AreEqual(3, _job1.ProcessingTime, "-- _jobMasters[1] 's processing time");
            Assert.AreEqual(1, _jobsMaster._initialLastIndex, "Index was updated properly");
        }

        [Test]
        public void AssignJobs_Test()
        {
            //Act
            _jobsMaster.AddJob(new Job(2001, 5, 2));
            _jobsMaster.AddJob(new Job(2002, 5, 4));
            _jobsMaster.AddJob(new Job(2003, 7, 3));
            _jobsMaster.AddJob(new Job(2004, 9, 1));
            _jobsMaster.AddJob(new Job(2005, 8, 3));
            _jobsMaster.AssignJobs();

            //Assert
            Assert.AreEqual("ADR-2001", _jobsMaster.GetScheduledJob(0).GetId(), "The ID is wrong 1");
            Assert.AreEqual("ADR-2004", _jobsMaster.GetScheduledJob(_jobsMaster._scheduledLastIndex).GetId(), "The ID is wrong 2");
            Assert.AreEqual("ADR-2002", _jobsMaster.GetRejectedJob(0).GetId(), "The ID is wrong 3");
            Assert.AreEqual("ADR-2002", _jobsMaster.GetRejectedJob(_jobsMaster._rejectedLastIndex).GetId(), "The ID is wrong 4");
        }

        [TearDown]
        public void TearDown()
        {
            _jobsMaster = null;
        }
    }
}