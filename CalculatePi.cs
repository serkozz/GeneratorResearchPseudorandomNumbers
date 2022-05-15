using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorResearchPseudorandomNumbers
{
    internal class CalculatePi
    {
        private const int unitCircleRadius = 1;
        List<System.Drawing.PointF> squarePoints = new List<System.Drawing.PointF>();
        List<System.Drawing.PointF> unitCirclePoints = new List<System.Drawing.PointF>();
        private decimal squarePointInUnitCircleProbability = 0;
        private decimal calculatedPiValue = 0;
        public CalculatePi(List<System.Drawing.PointF> squarePoints)
        {
            this.squarePoints = squarePoints;
            CreateUnitCirclePointsList(this.squarePoints);
            CalculatePointInCircleProbability();
            CalculatePiValue();
        }

        public int GetUnitCirclePointsCount()
        {
            return unitCirclePoints.Count;
        }

        public decimal GetSquarePointInUnitCircleProbability()
        {
            return squarePointInUnitCircleProbability;
        }

        public decimal GetCalculatedPiValue()
        {
            return calculatedPiValue;
        }

        private void CreateUnitCirclePointsList(List<System.Drawing.PointF> squarePoints)
        {
            unitCirclePoints.Clear();

            foreach (var point in squarePoints)
            {
                if (InsideUnitCircleCheck(point))
                {
                    unitCirclePoints.Add(point);
                }
            }
        }

        private bool InsideUnitCircleCheck(System.Drawing.PointF pointF)
        {
            if (Math.Sqrt(Math.Pow(pointF.X, 2) + Math.Pow(pointF.Y, 2)) <= unitCircleRadius)
            {
                return true;
            }
            else
                return false;
        }

        private void CalculatePointInCircleProbability()
        {
            squarePointInUnitCircleProbability = (decimal)unitCirclePoints.Count / (decimal)squarePoints.Count; // На самом деле можно и без приведения
        }

        private void CalculatePiValue()
        {
            calculatedPiValue = 4 * squarePointInUnitCircleProbability;
        }
    }
}
