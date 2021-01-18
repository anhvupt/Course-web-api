﻿using CourseWebAPI.Infrastuctures.Models;
using CourseWebAPI.Infrastuctures.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Controllers
{
    [Route("api/Courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ICourseService _courseService;
        private IEnrollmentService _enrollmentService;
        public CoursesController(ICourseService courseService,
            IEnrollmentService enrollmentService)
        {
            _courseService = courseService;
            _enrollmentService = enrollmentService;
        }
        [HttpGet()]
        public async Task<IActionResult> GetList()
        {
            return Ok(await _courseService.GetList());
        }

        [HttpGet("{courseId}/enrollments")]
        public async Task<IActionResult> GetEnrolledStudents(int courseId)
        {
            return Ok(await _enrollmentService.GetEnrolledStudents(courseId));
        }
    }
}