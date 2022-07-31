using JobMaster;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

JobsMaster _jobsMaster = new JobsMaster();
//This is manual test
var rand = new Random();


_jobsMaster.AddJob(new Job(2001, 5, 2));
_jobsMaster.AddJob(new Job(2002, 5, 4));
_jobsMaster.AddJob(new Job(2003, 7, 3));
_jobsMaster.AddJob(new Job(2004, 9, 1));
_jobsMaster.AddJob(new Job(2005, 8, 3));

_jobsMaster.AssignJobs();
_jobsMaster.printInitialJobs();
_jobsMaster.printScheduledJobs();
_jobsMaster.printRejectedJobs();

return 0;
