using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipTutorial
{
    class Ship
    {
        //常數值
        const int Cycle_weight = 3;
        const int Car_weight = 5;
        const int Truck_weight = 11;
        const int Train_weight = 17;

        const int Max_weight = 10;
        //類別屬性
        public int Capacity { get; set; }
        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCarCount { get; set; }

        Random random = new Random();

        //方法(功能)
        public int getShipLoad()
        {
            return CycleCount * Cycle_weight + CarCount * Car_weight + TruckCount + Truck_weight + TrainCarCount * Train_weight;
        }

        public Ship()
        {
            CycleCount = 0;
            CycleCount = 0;
            TruckCount = 0;
            TrainCarCount = 0;

            Capacity = random.Next(Max_weight) * Cycle_weight + random.Next(Max_weight) * Car_weight + random.Next(Max_weight) * Train_weight + random.Next(Max_weight) * Train_weight;
        }

        public int overUnder()
        {
            return Capacity - getShipLoad();
        }
        public override string ToString()
        {
            return "Capacity = " + Capacity + ",CurrentLoad = " + getShipLoad();
        }


















    }
}
