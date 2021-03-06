﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApplication.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
