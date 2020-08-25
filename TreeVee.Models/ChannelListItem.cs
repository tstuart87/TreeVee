using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeVee.Data;

namespace TreeVee.Models
{
    public class ChannelListItem
    {
        public int ChannelId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Channel")]
        public int Number { get; set; }
        [Display(Name = "Genre")]
        public Genre ChannelGenre { get; set; }
        public string Description { get; set; }
    }
}
