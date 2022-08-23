using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherHelper.BLL.Interfaces.Base;
using TeacherHelper.BLL.ModelsDTO;

namespace TeacherHelper.BLL.Interfaces
{
    public interface ITeacherService : IService<TeacherDTO>
    {
        void AddSubject(string teacherId, string subjectId);
        List<SubjectDTO> GetSubjects(string teacherId);
    }
}
