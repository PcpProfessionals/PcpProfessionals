﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Components
{
    [Table("MotherBroad", Schema="COMPONENT")]
    public class MotherBoardEntity
    {
        public long Id { get; set; }
        public string Type { get; set; }

    }
}
