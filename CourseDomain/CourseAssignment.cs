﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseDomain
{
    public class CourseAssignment
    {
        public int CourseID { get; set; }
        public int InstructorID { get; set; }
        public Course Course {get; set;}
        public Instructor Instructor { get; set; }
    }
}
