using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usoif.models
{
    internal class Evaluate
    {
        public Evaluate() { }
        public string EvalAge(int age)

        {
            if (!(age < 0 && age > 12)) return "Eres un niño";
            else if (age >= 13 && age <= 25) return "Eres un joven";
            else if (age >= 26) return "Eres un adulto";
            return "Edad no admitidas";
        }
        {
        return" Error es mensaje


    }
}
