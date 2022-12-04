namespace Models;

public class Product
{
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    
    public virtual Category Category { get; set; }
    
    public DateTime Created { get; set; } = DateTime.Now;
    
    public DateTime Updated { get; set; }
    
    public bool isActive { get; set; } = true;
}