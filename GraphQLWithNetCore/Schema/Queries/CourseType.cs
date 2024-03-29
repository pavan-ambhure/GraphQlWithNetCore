﻿using System;
using GraphQLWithNetCore.Models;

namespace GraphQLWithNetCore.Schema.Queries;

public class CourseType
{
	public Guid Id { get; set; }
	public String? Name { get; set; }
	public IEnumerable<StudentType>? Students { get; set; }
	public Subject Subject { get; set; }

	[GraphQLNonNullType]
	public InstructorType? Instructor { get; set; }

}
