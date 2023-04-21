namespace BioDesigner.Client.Models
{
    public class SimulationResult
    {
        public string? Id { get; set; }
        public GeneticCircuit? Circuit { get; set; }
        public DateTime Timestamp { get; set; }
        public double Score { get; set; }
        public IDictionary<string, object> AdditionalData { get; set; }

        public SimulationResult()
        {
            AdditionalData = new Dictionary<string, object>();
        }
    }
    
}
