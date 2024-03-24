using System;
namespace GraphQLWithNetCore.Schema.Queries
{
	public class StudentType
	{
		public Guid Id { get; set; }
		public String? FirstName { get; set; }
		public String? LastName { get; set; }
		public Double Gpa { get; set; }
	}
}

