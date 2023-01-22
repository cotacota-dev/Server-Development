using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI
{
    [Table("users")]
    public class User
    {
        [Key, Required]
        public int user_id
        {
            get;
            set;
        }
        [Required]
        public string? email
        {
            get;
            set;
        }
        [Required]
        public string? password
        {
            get;
            set;
        }

    }
}

