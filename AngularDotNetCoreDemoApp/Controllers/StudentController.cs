﻿using AngularDotNetCoreDemoApp.Models;
using Domain;
using IBusinessServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularDotNetCoreDemoApp.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService _studentService)
        {
            this.studentService = _studentService;
        }

        [HttpGet("all-available")]
        public IEnumerable<StudentFrontendModel> LoadAllActive()
        {
            return this.studentService.LoadAllActive().Select(x => ConvertToModel(x));
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //TODO: Use auto mapper inside 
        private static StudentFrontendModel ConvertToModel(StudentDto obj)
        {
            if (obj == null)
            {
                return new StudentFrontendModel();
            }

            return new StudentFrontendModel()
            {
                StudentId = obj.StudentId,
                GivenName = obj.GivenName,
                Surname = obj.Surname,
                Gender = obj.Gender,
                StudentPhoneNumber = obj.StudentPhoneNumber,
                StudentEmailAddress = obj.StudentEmailAddress,
                StudentNRIC = obj.StudentNRIC,
                StudentDateOfBirth = obj.StudentDateOfBirth,
                IsActive = obj.IsActive,
                IsDeleted = obj.IsDeleted,
                CreatedUserId = obj.CreatedUserId,
                UpdatedUserId = obj.UpdatedUserId,
                CreatedDateTime = obj.CreatedDateTime,
                UpdatedDateTime = obj.UpdatedDateTime,
            };
        }
    }
}