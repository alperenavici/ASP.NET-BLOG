using Blog.Core.Entities;

namespace Blog.Entity.Entities;

public class Image: EntityBase
{
    public string fileName { get; set; }
    public string FileType { get; set; }
    
    
    public ICollection<Article> Articles { get; set; }
    
}