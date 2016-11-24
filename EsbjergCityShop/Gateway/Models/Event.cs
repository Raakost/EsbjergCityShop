using System;

namespace Gateway.Models
{
    public class Event : AbstractId
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public DateTime DateOfEvent { get; set; }
    }
}
