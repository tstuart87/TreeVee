using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeVee.Data
{
    public enum Genre 
    {
        Comedy,
        Food,
        Lifestyle,
        Movies,
        Music,
        Nature,
        News,
        Sports,
        Tech,
        TV
    }

    public class Channel
    {
        [Key]
        public int ChannelId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public Genre ChannelGenre { get; set; }
        public string Description { get; set; }
    }
}
