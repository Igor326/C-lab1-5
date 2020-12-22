using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class CarService
    {
        public delegate void ServiceDelegate(Car carToService);

        public void TuneWheelAlignment(Car car)
        {
            car.WheelAlignmentTuned = true;
        }
        public void Paint(Car car)
        {
            car.Painted = true;
        }
        public void ChangeOil(Car car)
        {
            car.OilChanged = true;
        }
        public void FullInspect(Car car)
        {
            car.FullInspected = true;
        }
        public void ReplaceWheels(Car car)
        {
            car.WheelsReplaced = true;
        }
        public void RepairBody(Car car)
        {
            car.BodyRepaired = true;
        }
    }
}
