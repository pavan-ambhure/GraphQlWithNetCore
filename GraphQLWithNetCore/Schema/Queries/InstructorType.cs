using System;
namespace GraphQLWithNetCore.Schema.Queries
{
	public class InstructorType
	{
        public Guid Id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public double Salary { get; set; }
    }
}

