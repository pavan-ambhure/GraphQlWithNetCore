using System;
namespace GraphQLWithNetCore.Dtos
{
	public class StudentDto
	{
        public Guid Id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public Double Gpa { get; set; }
    }
}

