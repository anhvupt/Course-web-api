﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseDomain
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CourseCredit { get; set; }
        public int DepartmentID { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        //public List<CourseAssignment> CourseAssignments { get; set; }
    }
}
