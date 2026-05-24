using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Classes.Observer
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;

            if (this.previousCPULoad == 0) this.previousCPULoad = 0.01f;

            float cpuDifference = Math.Abs(currentLoad - this.previousCPULoad) / this.previousCPULoad;

            if (cpuDifference >= 0.10f)
            {
                this.Notify();
                this.previousCPULoad = currentLoad;
            }

            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentRAM = this.AvailableRAM;

            if (this.previousRAMAvailable == 0) this.previousRAMAvailable = 1f;

            float ramDifference = Math.Abs(currentRAM - this.previousRAMAvailable) / this.previousRAMAvailable;

            if (ramDifference >= 0.10f)
            {
                this.Notify();
                this.previousRAMAvailable = currentRAM;
            }

            return currentRAM;
        }
    }
}
