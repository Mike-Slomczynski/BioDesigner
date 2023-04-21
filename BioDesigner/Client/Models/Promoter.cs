namespace BioDesigner.Client.Models;

public class Promoter : GeneticPart
{
    public double Strength { get; set; }

    // Constructor
    public Promoter(string id, string name, string description, double strength)
        : base(id, name, description)
    {
        Strength = strength;
    }
}
