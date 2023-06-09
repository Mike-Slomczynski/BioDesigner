﻿namespace BioDesigner.Client.Models;

public class Terminator : GeneticPart
{
    public double TerminationEfficiency { get; set; }

    // Constructor
    public Terminator(Guid id, string name, string description, double terminationEfficiency)
        : base(id, name, description)
    {
        TerminationEfficiency = terminationEfficiency;
    }
}
