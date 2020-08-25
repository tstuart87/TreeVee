using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeVee.Data;
using TreeVee.Models;

namespace TreeVee.Services
{
    public class ChannelService
    {
        private readonly Guid _userId;

        public ChannelService(Guid userId)
        {
            _userId = userId;
        }

        public ChannelService()
        {

        }

        public IEnumerable<ChannelListItem> GetChannels()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Channels
                        .Select(
                            e =>
                                new ChannelListItem
                                {
                                    ChannelId = e.ChannelId,
                                    Name = e.Name,
                                    Number = e.Number,
                                    ChannelGenre = e.ChannelGenre,
                                    Description = e.Description
                                });

                return query.ToArray().OrderBy(e => e.Number);
            }
        }

        public bool CreateChannel(ChannelCreate model)
        {
            var entity = new Channel()
            {
                ChannelId = model.ChannelId,
                Name = model.Name,
                Number = model.Number,
                ChannelGenre = model.ChannelGenre,
                Description = model.Description
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Channels.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
