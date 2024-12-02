﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisa_sMinuteManagement.Models
{
    public class MeetingItemStatus
    {
        public int MeetingItemStatusID { get; set; }
        public int MeetingID { get; set; }
        public int MeetingItemID { get; set; }
        public string Status { get; set; }
        public string ResponsiblePerson { get; set; }

        public MeetingItem MeetingItem { get; set; }
    }
}
