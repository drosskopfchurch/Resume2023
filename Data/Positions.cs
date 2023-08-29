using Resume2023.Models;

namespace Resume2023.Data
{
    public static class Positions
    {
        public static Position ITCoordinator
        {
            get =>
                new Position
                {
                    Id = 1,
                    Name = "IT Coordinator",
                    Employer = Employers.PartnersInLeadership,
                    StartDate = new DateTime(2003, 11, 1),
                    EndDate = new DateTime(2005, 10, 1)
                };
        }
        public static Position SoftwareTechnicalSupport
        {
            get =>
                new Position
                {
                    Id = 2,
                    Name = "Software Technical Support",
                    Employer = Employers.ComplianceInformationSystems,
                    StartDate = new DateTime(2005, 11, 1),
                    EndDate = new DateTime(2007, 04, 1)
                };
        }
        public static Position QualityAssuranceEngineer
        {
            get =>
                new Position
                {
                    Id = 3,
                    Name = "QA Engineer",
                    Employer = Employers.ComplianceInformationSystems,
                    StartDate = new DateTime(2007, 04, 1),
                    EndDate = new DateTime(2010, 06, 1)
                };
        }
        public static Position QualityAssuranceEngineer3
        {
            get =>
                new Position
                {
                    Id = 4,
                    Name = "QA Engineer 3",
                    Employer = Employers.TheChurch,
                    StartDate = new DateTime(2010, 06, 1),
                    EndDate = new DateTime(2015, 04, 1)
                };
        }
        public static Position SoftwareEngineer3
        {
            get =>
                new Position
                {
                    Id = 5,
                    Name = "Software Engineer 3",
                    Employer = Employers.TheChurch,
                    StartDate = new DateTime(2015, 04, 1),
                    EndDate = new DateTime(2018, 10, 1)
                };
        }
        public static Position SoftwareEngineer4
        {
            get =>
                new Position
                {
                    Id = 6,
                    Name = "Software Engineer 4",
                    Employer = Employers.TheChurch,
                    StartDate = new DateTime(2018, 10, 1)
                };
        }

        public static IList<Position> All() => 
        typeof(Positions)
            .GetProperties()
            .Where(p =>
                        p != null &&
                        p.GetValue(null) != null &&
                        p.GetValue(null).GetType().Equals(typeof(Position)))
            .Select(p => (Position)p.GetValue(null))
            .ToList();

        public static IList<Position> PositionsForEmployer(int employerId) => 
        All()
        .Where(p => p.Employer.Id == employerId)
        .OrderByDescending(p => p.StartDate)
        .ToList();

        
    }
}