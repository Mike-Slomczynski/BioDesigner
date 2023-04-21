namespace BioDesigner.Client.Models;

public abstract class GeneticPart
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Constructor
    protected GeneticPart(string id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}
