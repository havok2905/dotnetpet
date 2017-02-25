using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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