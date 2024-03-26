using System;
using GraphQLWithNetCore.Models;
using GraphQLWithNetCore.Schema.Queries;

namespace GraphQLWithNetCore.Dtos
{
	public class CourseDtos
	{

        public Guid Id { get; set; }
        public String? Name { get; set; }
        public IEnumerable<StudentDto>? Students { get; set; }
        public Subject Subject { get; set; }

        public Guid InstructorId { get; set; }
        public InstructorDto? Instructor { get; set; }

    }
}

