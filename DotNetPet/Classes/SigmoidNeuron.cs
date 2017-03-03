using System;

namespace DotNetPet
{
    public class SigmoidNeuron
    {
        private double[] inputs;
        private double[] weights;
        public double bias;

        public SigmoidNeuron(double bias)
        {
            this.bias = bias;
        }

        public void SetInputsAndWeights(double[] inputs, double[] weights)
        {
            if(inputs.Length != weights.Length)
            {
                throw new System.ArgumentException("Arguments inputs and weights must be of equal length", "inputs, weights");
            }

            this.inputs = inputs;
            this.weights = weights;
        }

        public double SigmoidalFunction()
        {
            double summation = 0.0;

            for (int x=0; x<inputs.Length; x++)
            {
                summation += ( this.weights[x] * this.inputs[x] );
            }

            return 1 / ( 1 + Math.Exp( (-summation) - this.bias) );
        }
    }
}