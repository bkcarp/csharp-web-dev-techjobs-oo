using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job newJob = new Job();
        Job newJob2 = new Job();
        [TestMethod]
        public void TestSettingJobId()
        {
     
            Assert.IsFalse(newJob.Id == newJob2.Id);
        }

        [TestMethod]

        public void TestJobIncriment()
        {
            Assert.IsTrue(newJob2.Id - newJob.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job newJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        
            Assert.IsTrue(newJob.Name == "Product tester");
            Assert.IsTrue(newJob.EmployerName.Value == "ACME");
            Assert.IsTrue(newJob.EmployerLocation.Value == "Desert");
            Assert.IsTrue(newJob.JobType.Value == "Quality control");
            Assert.IsTrue(newJob.JobCoreCompetency.Value == "Persistence");

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job newJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(newJob3.Equals(job));

        }


    }
}
