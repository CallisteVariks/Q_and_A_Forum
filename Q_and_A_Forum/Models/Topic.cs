using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Q_and_A_Forum.Models
{
    public class Topic
    {
        [Key]
        public int TopicID { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Reply> Replies { get; set; }

    }
}