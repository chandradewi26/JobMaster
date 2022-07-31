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

            Job _job = _jobsMaster.GetInitialJob(0);

            Assert.AreEqual(5, _job.DueDate, "The Due date are different");
            Assert.AreEqual(2, _job.ProcessingTime, "The Processing Time are different");
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