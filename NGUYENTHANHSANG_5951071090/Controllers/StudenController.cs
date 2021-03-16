using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NGUYENTHANHSANG_5951071090.Models;

namespace NGUYENTHANHSANG_5951071090.Controllers
{
    public class StudenController : ApiController
    {
        public class StudentController : ApiController
        {
            StudentInfo[] students = new StudentInfo[]
    {
            new StudentInfo {Id = 1, Name = "Nguyen", Lop = "CNTT K59",  NamSinh = "1998"},
            new StudentInfo {Id = 2, Name = "Thanh", Lop = "CHA K59",  NamSinh = "1999"},
            new StudentInfo {Id = 3, Name = "Sang", Lop = "OTO K59",  NamSinh = "2000"}
    };
            // GET: api/Student
            public IEnumerable<StudentInfo> Get()
            {
                return students;
            }

            // GET: api/Student/5
            public StudentInfo Get(int id)
            {
                if (id - 1 < students.Length)
                {
                    return students.ElementAt(id - 1);
                }

                return new StudentInfo
                {
                    Id = students.Length + 1,
                    Name = "Invalid ID",
                    Lop = "Error",
                    NamSinh = "Error"
                };
            }

            // PUT: api/Studen/5
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE: api/Studen/5
            public void Delete(int id)
            {
            }
        }
    }
}
