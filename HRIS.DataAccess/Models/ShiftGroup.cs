using System;
using System.Collections.Generic;

#nullable disable

namespace HRIS.DataAccess.Models
{
    public partial class ShiftGroup
    {
        public ShiftGroup()
        {
            EmployeeShiftGroupDemos = new HashSet<EmployeeShiftGroupDemo>();
        }

        public long Id { get; set; }
        public bool ModayWork { get; set; }
        public TimeSpan? MondayFrom { get; set; }
        public TimeSpan? MondayTo { get; set; }
        public bool TuesdayWork { get; set; }
        public TimeSpan? TuesdayFrom { get; set; }
        public TimeSpan? TuesdayTo { get; set; }
        public bool WednesdayWork { get; set; }
        public TimeSpan? WednesdayFrom { get; set; }
        public TimeSpan? WednesdayTo { get; set; }
        public bool ThursdayWork { get; set; }
        public TimeSpan? ThursdayFrom { get; set; }
        public TimeSpan? ThursdayTo { get; set; }
        public bool FridayWork { get; set; }
        public TimeSpan? FridayFrom { get; set; }
        public TimeSpan? FridayTo { get; set; }
        public bool SaturdayWork { get; set; }
        public TimeSpan? SaturdayFrom { get; set; }
        public TimeSpan? SaturdayTo { get; set; }
        public bool SundayWork { get; set; }
        public TimeSpan? SundayFrom { get; set; }
        public TimeSpan? SundayTo { get; set; }

        public virtual ICollection<EmployeeShiftGroupDemo> EmployeeShiftGroupDemos { get; set; }
    }
}
