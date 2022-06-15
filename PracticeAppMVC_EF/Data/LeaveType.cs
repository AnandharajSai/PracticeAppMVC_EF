﻿using PracticeAppMVC_EF.Data.Migrations;

namespace PracticeAppMVC_EF.Data
{
    public class LeaveType : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
