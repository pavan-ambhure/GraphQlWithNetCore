using System;
using GraphQLWithNetCore.Schema.Mutations;
using GraphQLWithNetCore.Schema.Queries;

namespace GraphQLWithNetCore.Schema.Mutations;

public class Mutation
{
	private List<CourseResult> _courses;

	public Mutation()
	{
		_courses = new List<CourseResult>();
	}

	public CourseResult CreateCourse(CourseInput input)
	{
        CourseResult courseType = new CourseResult()
		{
			Id = Guid.NewGuid(),
			Name = input.Name,
			Subject = input.Subject,
			InstructorId = input.InstructorId
        };
		_courses.Add(courseType);
		return courseType;
	}

    public CourseResult UpdateCourse(Guid id, CourseInput input)
    {
		CourseResult courseResult = _courses.FirstOrDefault(c => c.Id == id)!;
		if(courseResult == null)
		{
			throw new GraphQLException(new Error("Not found!"));
		}
		courseResult.Name = input.Name;
		courseResult.Subject = input.Subject;
		courseResult.InstructorId = input.InstructorId;
		return courseResult;
    }

    public bool DeleteCourse(Guid id)
    {
        CourseResult courseResult = _courses.FirstOrDefault(c => c.Id == id)!;
        if (courseResult == null)
        {
            throw new GraphQLException(new Error("Not found!"));
        }
		_courses.RemoveAll(c => c.Id == id);
		return true;
    }
}

