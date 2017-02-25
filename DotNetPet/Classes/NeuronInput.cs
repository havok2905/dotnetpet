namespace DotNetPet
{
    public class NeuronInput
    {
        public double weight;
        public double value;

        public NeuronInput(double value, double weight)
        {
            this.value = value;
            this.weight = weight;
        }
    }
}