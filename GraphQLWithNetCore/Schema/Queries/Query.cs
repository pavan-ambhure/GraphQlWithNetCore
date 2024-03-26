using System;
using Bogus;
using GraphQLWithNetCore.Models;

namespace GraphQLWithNetCore.Schema.Queries
{
    public class Query
    {
        [GraphQLDeprecated("THIS IS DEPRECATED")]
        public string Instructions => "Hi! My name is pavan";

        private readonly Faker<InstructorType> _instructorFaker;
        private readonly Faker<CourseType> _courseFaker;
        private readonly Faker<StudentType> _studentFaker;

        public Query()
        {
            _instructorFaker = new Faker<InstructorType>()
             .RuleFor(c => c.Id, f => Guid.NewGuid())
             .RuleFor(c => c.FirstName, f => f.Name.FirstName())
             .RuleFor(c => c.LastName, f => f.Name.LastName())
             .RuleFor(c => c.Salary, f => f.Random.Double(0, 10000));

            _studentFaker = new Faker<StudentType>()
               .RuleFor(c => c.Id, f => Guid.NewGuid())
               .RuleFor(c => c.FirstName, f => f.Name.FirstName())
               .RuleFor(c => c.LastName, f => f.Name.LastName())
               .RuleFor(c => c.Gpa, f => f.Random.Double(0, 4));

            _courseFaker = new Faker<CourseType>()
              .RuleFor(c => c.Id, f => Guid.NewGuid())
              .RuleFor(c => c.Name, f => f.Name.FirstName())
              .RuleFor(c => c.Subject, f => f.PickRandom<Subject>())
              .RuleFor(e => e.Instructor, GetInstructor())
              .RuleFor(e => e.Students, GetStudents());
        }

        public IEnumerable<CourseType> GetCourses()
        {
            return _courseFaker.Generate(5);
        }


        public InstructorType GetInstructor()
        {

            return _instructorFaker.Generate();
        }

        public IEnumerable<StudentType> GetStudents()
        {
            return _studentFaker.Generate(5);
        }

        public StudentType GetStudentById(Guid id)
        {
            var student = _studentFaker.Generate();
            student.Id = id;
            return student;
        }
    }
}

