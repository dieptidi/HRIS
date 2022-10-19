using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string HeadDepartment { get; set; }
        public int? RoomNumber { get; set; }
    }
}
