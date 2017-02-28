using System;

namespace DotNetPet
{
    public class SigmoidNeuron
    {

        public NeuronInput[] inputs;
        public double bias;

        public SigmoidNeuron(NeuronInput[] inputs, double bias)
        {
            this.bias = bias;
            this.inputs = inputs;
        }

        // Calculate the output of this neuron firing
        public double SigmoidalFunction()
        {
            double summation = 0.0;

            for (int x=0; x<inputs.Length; x++)
            {
                summation += ( this.inputs[x].weight * this.inputs[x].value );
            }

            return 1 / ( 1 + Math.Exp( (-summation) - this.bias) );
        }
    }
}