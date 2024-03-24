using System;
namespace GraphQLWithNetCore.Schema.Mutations
{
	public class CourseInput
	{
        public String? Name { get; set; }
        public Queries.Subject Subject { get; set; }
        public Guid InstructorId { get; set; }
    }
}

