using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{   
    [Table("Photos")] // the Photo property will get named Photos in the database
    public class Photo
    {
        public int Id { get; set; }
        public string Url {get; set;}
        public bool IsMain {get; set;}
        public bool IsApproved {get; set;}
        public string PublicId {get; set;}
        public AppUser AppUser {get; set;}
        public int AppUserId {get; set;}
    }
}