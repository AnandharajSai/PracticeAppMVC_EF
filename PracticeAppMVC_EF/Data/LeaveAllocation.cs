using PracticeAppMVC_EF.Data.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeAppMVC_EF.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }
    }
}
