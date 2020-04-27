using System;

namespace PersonalProjectLab
{
    public class CalculatorEngine
    {
        public decimal CalculateInertia(int width, int height)
        {
            decimal inertia = 0.00m;
            inertia = (decimal)(width * Math.Pow(height, 3) / 12);

            return inertia;
        }

      public decimal CalculateDeflection(int force, int length, int loadLength, decimal modulusE, decimal inertia)
        {
            decimal maxDeflection = 0.00m;
            decimal deflection = 0.00m;

            maxDeflection = (decimal)((-1) * force * (Math.Pow(loadLength,3) - 3 * length * Math.Pow(loadLength,2)))/(6 * modulusE * inertia);
            deflection = Math.Round(maxDeflection, 4);

            return deflection;
        }
       
    }
}
