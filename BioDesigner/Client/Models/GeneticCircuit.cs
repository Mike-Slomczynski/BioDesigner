namespace BioDesigner.Client.Models;

public class GeneticCircuit
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<GeneticDevice> Devices { get; set; }

    // Constructor
    public GeneticCircuit(Guid id, string name, List<GeneticDevice> devices)
    {
        Id = id;
        Name = name;
        Devices = devices;
    }
}
