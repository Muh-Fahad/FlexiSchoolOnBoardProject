﻿using Repositories.Common;

namespace Repositories.Entities
{
    public class Student: BaseEntity
    {
        public string FullName { get; set; }
        public List<Subject> EnrolledSubjects { get; set; }
        public Student() => EnrolledSubjects = new List<Subject>();
    }
}
