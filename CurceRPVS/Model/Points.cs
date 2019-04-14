using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurceRPVS.Model
{
    public class Points
    {
        List<Points> listPoints = new List<Points>();

        public double X { get; set; }
        public double Y { get; set; }

        public Points() { }

        private Points(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        private void AddPoints(Phisics phisics)
        {
            for (double time = 0; time < phisics.time; time += phisics.time_interval)
                listPoints.Add(new Points(time, phisics.q(time)));
        }
        public List<Points> PointsList(Phisics phisics)
        {
            AddPoints(phisics);
            return listPoints;
        }

    }
}
