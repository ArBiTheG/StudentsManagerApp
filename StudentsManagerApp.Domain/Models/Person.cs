using StudentsManagerApp.Domain.Common;
using StudentsManagerApp.Domain.Interfaces;
using StudentsManagerApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Domain.Models
{
    /// <summary>
    /// Класс модели <c>Личность</c>
    /// </summary>
    public class Person: Entity, ICloneable<Person>
    {
        /// <summary>
        /// Имя личности
        /// </summary>
        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия личности
        /// </summary>
        [Required]
        [StringLength(64)]
        public string MiddleName { get; set; }
        /// <summary>
        /// Отчество личности
        /// </summary>
        [StringLength(64)]
        public string? LastName { get; set; }
        /// <summary>
        /// День рождения личности
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// Пол личности
        /// </summary>
        public GenderType Gender { get; set; }
        /// <summary>
        /// О личности
        /// </summary>
        [StringLength(65536)]
        public string About { get; set; }

        public Person()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            BirthDay = DateTime.Now;
            Gender = GenderType.Male;
            About = string.Empty;
        }
        public Person(Person person): base(person)
        {
            FirstName = person.FirstName;
            MiddleName = person.MiddleName;
            LastName = person.LastName;
            BirthDay = person.BirthDay;
            Gender = person.Gender;
            About = person.About;
        }

        public Person Clone()
        {
            return new Person(this);
        }
    }
}
