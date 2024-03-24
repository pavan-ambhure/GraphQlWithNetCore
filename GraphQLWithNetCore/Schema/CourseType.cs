using System;
namespace GraphQLWithNetCore.Schema;

public class CourseType
{
	public Guid Id { get; set; }
	public String Name { get; set; }
	public IEnumerable<StudentType> Students { get; set; }
	public Subject Subject { get; set; }
	public InstructorType Instructor { get; set; }

}
public enum Subject
{
	Mathematics,
	Science,
	History
}
