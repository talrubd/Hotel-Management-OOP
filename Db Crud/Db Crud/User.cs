﻿using System.ComponentModel.DataAnnotations;

namespace Db_Crud
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}