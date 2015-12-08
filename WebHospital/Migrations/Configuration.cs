namespace WebHospital.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


	internal sealed class Configuration : DbMigrationsConfiguration<WebHospital.ConfigurationEF.HospitalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WebHospital.ConfigurationEF.HospitalDbContext context)
        {
             // This method will be called after migrating to the latest version.

	        var doc1 = new Doctor {Id = 1, FirstName = "Andrew", LastName = "Lols", Qualification = "B"};
	        var doc2 = new Doctor {Id = 2, FirstName = "Gregory", LastName = "House", Qualification = "A"};
			context.Doctors.AddOrUpdate(doc1);
			context.Doctors.AddOrUpdate(doc2);
            context.Patients.AddOrUpdate(new Patient { Id = 1, FirstName = "Barack", LastName = "Obama", Disease = "Stomachache", DoctorId = 1 });
            context.Patients.AddOrUpdate(new Patient { Id = 2, FirstName = "Jack", LastName = "Sparrow", Disease = "Cancer", DoctorId = 2 });
            context.SaveChanges();

        }
    }
}
