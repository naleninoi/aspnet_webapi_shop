namespace Models;

public class Category
{
    public int Id { get; set; }
    
    public string Title { get; set; }

    public ICollection<Product> Products { get; set; }
    
    public DateTime Created { get; set; } = DateTime.Now;
    
    public DateTime Updated { get; set; }

    public bool isActive { get; set; } = true;
}