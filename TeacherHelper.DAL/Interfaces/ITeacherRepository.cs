using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherHelper.DAL.Interfaces.Base;
using TeacherHelper.DAL.Models;

namespace TeacherHelper.DAL.Interfaces
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        void AddSubject(string teacherId, string subjectId);
        void AddGroup(string teacherId, string groupId);
        List<Subject> GetSubjects(string teacherId);
    }
}
