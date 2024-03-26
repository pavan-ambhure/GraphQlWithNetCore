using System;
namespace GraphQLWithNetCore.Dtos
{
	public class InstructorDto
	{
        public Guid Id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public double Salary { get; set; }
    }
}

