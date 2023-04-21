namespace BioDesigner.Client.Models;

public class DefaultGeneticDevice : GeneticDevice
{
    public DefaultGeneticDevice() : base(Guid.Empty, "Unknown", new List<GeneticPart>())
    { }
}
