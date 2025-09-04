using StudentsManagerApp.Domain.Common;
using StudentsManagerApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Domain.Models
{
    /// <summary>
    /// Класс модели <c>Студент</c>
    /// </summary>
    public class Student : Entity, ICloneable<Student>
    {
        /// <summary>
        /// Идентификатор личности
        /// </summary>
        [Required]
        public int PersonId { get; set; }
        /// <summary>
        /// Объект личности
        /// </summary>
        [Required]
        public virtual Person? Person { get; set; }
        /// <summary>
        /// Идентификатор группы
        /// </summary>
        [Required]
        public int GroupId { get; set; }
        /// <summary>
        /// Объект группы
        /// </summary>
        [Required]
        public virtual Group? Group { get; set; }

        public Student()
        {
            
        }
        public Student(Student student): base(student)
        {
            PersonId = student.PersonId;
            Person = student.Person?.Clone();
            GroupId = student.GroupId;
            Group = student.Group?.Clone();
        }

        public Student Clone()
        {
            return new Student(this);
        }
    }
}
