using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Core.Models
{
    public enum Gender { male , female }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        private bool isActive = true;
        public bool IsActive
        {
            get => isActive;
            set => isActive = value;
        }
        public DateTime DateSartingWork { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<Role> Roles { get; set; }

    }
}
