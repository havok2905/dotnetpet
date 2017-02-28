using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetPet;

namespace DotNetPet.Tests
{
    [TestClass]
    public class SigmoidNeuronTest
    {
        [TestMethod]
        public void TestSigmoidalFunction()
        {
            NeuronInput inputA = new NeuronInput(0.67, 1.5);
            NeuronInput inputB = new NeuronInput(0.5, 1.0);
            NeuronInput inputC = new NeuronInput(0.8, 0.8);

            NeuronInput[] inputs = new NeuronInput[3];

            inputs[0] = inputA;
            inputs[1] = inputB;
            inputs[2] = inputC;

            SigmoidNeuron neuron = new SigmoidNeuron(inputs, 3.0);

            double output = neuron.SigmoidalFunction();
            double expected = 0.99420529989699;
            double delta = expected - output;
            
            Assert.AreEqual(output, expected, delta);
        }
    }
}
