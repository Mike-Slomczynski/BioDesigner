namespace BioDesigner.Client.Models;

public class RBS : GeneticPart
{
    public double Efficiency { get; set; }

    // Constructor
    public RBS(string id, string name, string description, double efficiency)
        : base(id, name, description)
    {
        Efficiency = efficiency;
    }
}
