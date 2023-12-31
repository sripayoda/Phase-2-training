﻿using JwtAuth.Models;
using JwtAuth.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuth.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        public IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            List<Student> students;
            try
            {
                students = await _student.GetAllStudents();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(students);
        }

        [HttpGet("{rollno}")]
        public async Task<ActionResult<Student>> GetStudentByRollno(int rollno)
        {
            Student student;
            try
            {
                student = await _student.GetStudentByRollno(rollno);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(Student student)
        {
            Student addedstudent;
            try
            {
                addedstudent = await _student.AddStudent(student);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(addedstudent);
        }

        [HttpPut]
        public async Task<ActionResult<Student>> UpateStudent(int rollno, Student student)
        {
            Student? updatedstudent;
            try
            {
                updatedstudent = await _student.UpdateStudent(rollno, student);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(updatedstudent);
        }

        [HttpDelete]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int rollno, [FromHeader(Name = "Authorization")] string authorizationHeader)
        {

            List<Student> students;
            try
            {
                students = await _student.DeleteStudent(rollno);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(students);
        }

    }
}
