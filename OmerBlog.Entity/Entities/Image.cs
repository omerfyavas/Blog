using OmerBlog.Core.Entities;


namespace OmerBlog.Entity.Entities
{
    public class Image : EntityBase
    {

        public string FileName { get; set; }

        public string FileType { get; set; }

        public ICollection<Image> Images { get; set; }
    }

}
