﻿using System;
using GraphQLWithNetCore.Models;

namespace GraphQLWithNetCore.Schema.Mutations
{
	public class CourseResult
	{
        public Guid Id { get; set; }
        public String? Name { get; set; }
        public Subject Subject { get; set; }
        public Guid InstructorId { get; set; }
    }
}

