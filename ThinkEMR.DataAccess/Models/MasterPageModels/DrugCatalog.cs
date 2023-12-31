﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkEMR_Care.DataAccess.Models.MasterPageModels
{
    public class DrugCatalog
    {
            [Key]
            public int Id { get; set; }
            public string Speciality { get; set; }
            public string Type { get; set; }
            public string Medicine { get; set; }
            public string Dose { get; set; }
            public string When { get; set; }
            public string Where { get; set; }
            public string Frequency { get; set; }
            public string Duration { get; set; }
            public int Qty { get; set; }
            public string Instructions { get; set; }
            public bool Status { get; set; }
        
    }
}
