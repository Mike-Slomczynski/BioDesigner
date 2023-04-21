namespace BioDesigner.Client.Models;

public class GeneticDevice
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List<GeneticPart> Parts { get; set; }

    // Constructor
    public GeneticDevice(string id, string name, List<GeneticPart> parts)
    {
        Id = id;
        Name = name;
        Parts = parts;
    }
}
