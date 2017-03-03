namespace DotNetPet
{
    public class Network
    {
        public int[] sizes;
        public double[,] weights;
        public double[,] biases;
        public SigmoidNeuron[,] neurons;
        public int numLayers;

        public Network(int[] sizes, double[,] weights, SigmoidNeuron[,] neurons)
        {
            this.sizes = sizes;
            this.weights = weights;
            this.neurons = neurons;
            this.numLayers = sizes.Length;
        }

        public double[] ForwardFeed(int layer, double[] inputs)
        {
            int numberOfNeurons = this.sizes[layer];
            double[] layerOutputs = new double[numberOfNeurons];

            for (int neuronIndex = 0; neuronIndex < numberOfNeurons; neuronIndex++)
            {
                double[] weights = new double[numberOfNeurons];
                for (int weightIndex = 0; weightIndex < numberOfNeurons; weightIndex++)
                {
                    weights[weightIndex] = this.weights[layer, weightIndex];
                }

                neurons[layer, neuronIndex].SetInputsAndWeights(inputs, weights);
                layerOutputs[neuronIndex] = neurons[layer, neuronIndex].SigmoidalFunction();
            }

            if (layer == this.sizes.Length - 1)
            {
                return layerOutputs;
            }

            return this.ForwardFeed(layer+1, layerOutputs);
        }
    }
}