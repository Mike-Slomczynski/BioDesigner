﻿namespace BioDesigner.Client.Models;

public class CodingSequence : GeneticPart
{
    public string Protein { get; set; }

    // Constructor
    public CodingSequence(Guid id, string name, string description, string protein)
        : base(id, name, description)
    {
        Protein = protein;
    }
}
