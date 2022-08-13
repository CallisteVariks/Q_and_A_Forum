using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Q_and_A_Forum.Models
{
    public class Reply
    {
        [Key]
        public int ReplyID { get; set; }
        public string UserId { get; set; }

        public int TopicID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}