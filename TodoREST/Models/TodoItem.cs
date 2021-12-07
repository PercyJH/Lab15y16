using System;
using System.Collections.Generic;
using System.Text;

namespace TodoREST.Models
{
	public class TodoItem
    {
        public string _id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string image_url { get; set; }
        public string synopsis { get; set; }
        public int episodes { get; set; }
        public bool airing { get; set; }
        public DateTime start_date { get; set; }
    }
}
