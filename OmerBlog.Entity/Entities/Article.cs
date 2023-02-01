using OmerBlog.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace OmerBlog.Entity.Entities
{
    public class Article : EntityBase
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int ViewCount { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public Guid ImageId { get; set; }

        public Image Image { get; set; }
    }
}

