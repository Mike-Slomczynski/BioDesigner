namespace BioDesigner.Client.Models;

public class GeneticDevice
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public List<GeneticPart> Parts { get; set; }

    // Constructor
    public GeneticDevice(Guid id, string name, List<GeneticPart> parts)
    {
        Id = id;
        Name = name;
        Parts = parts;
    }
}
