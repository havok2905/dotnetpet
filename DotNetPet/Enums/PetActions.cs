using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetPet
{
    public enum PetActions
    {
        Eat = 1,
        Drink = 2,
        Poop = 4,
        Pee = 8,
        Play = 16,
        Sleep = 32
    }
}