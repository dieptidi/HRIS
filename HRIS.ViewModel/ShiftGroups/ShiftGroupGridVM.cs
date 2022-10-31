using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.ViewModel.ShiftGroups
{
    public class ShiftGroupGridVM
    {
        public long Id { get; set; }
        public bool ModayWork { get; set; }
        public string MondayFrom { get; set; }
        public string MondayTo { get; set; }
        public bool TuesdayWork { get; set; }
        public string TuesdayFrom { get; set; }
        public string TuesdayTo { get; set; }
        public bool WednesdayWork { get; set; }
        public string WednesdayFrom { get; set; }
        public string WednesdayTo { get; set; }
        public bool ThursdayWork { get; set; }
        public string ThursdayFrom { get; set; }
        public string ThursdayTo { get; set; }
        public bool FridayWork { get; set; }
        public string FridayFrom { get; set; }
        public string FridayTo { get; set; }
        public bool SaturdayWork { get; set; }
        public string SaturdayFrom { get; set; }
        public string SaturdayTo { get; set; }
        public bool SundayWork { get; set; }
        public string SundayFrom { get; set; }
        public string SundayTo { get; set; }
    }
}
