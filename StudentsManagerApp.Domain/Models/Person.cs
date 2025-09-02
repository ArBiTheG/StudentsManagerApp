using StudentsManagerApp.Domain.Common;
using StudentsManagerApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Domain.Models
{
    public class Person: BaseModel
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        [Required]
        [StringLength(64)]
        public string MiddleName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        [StringLength(64)]
        public string LastName { get; set; } = string.Empty;
        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public GenderType Gender { get; set; }
        /// <summary>
        /// О личности
        /// </summary>
        [StringLength(65536)]
        public string About { get; set; } = string.Empty;


    }
}
