﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniHockey.Models
{
    public class Tournament
    {
        public IEnumerable<SelectListItem> Teams { get; set; }

        [DisplayName("Team1")]
        public int Team1Id { get; set; }
        [DisplayName("Team2")]
        public int Team2Id { get; set; }
    }
}