namespace BioDesigner.Client.Models;

public abstract class GeneticPart
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Function { get; set; } = string.Empty;


    // Constructor
    protected GeneticPart(Guid id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}
