﻿using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IStudentService
    {
        IEnumerable<StudentDto> GetStudents(Guid schoolId, bool trackChanges);
        StudentDto GetStudent(Guid schoolId, Guid id, bool trackChanges);
        StudentDto CreateStudentForSchool(Guid schoolId,StudentForCreationDto studentForCreation, bool trackChanges);
    }
}
