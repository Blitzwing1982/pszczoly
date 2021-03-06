﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pszczoły
{
    public class Queen : Bee
    {
        public Queen(Worker[] workers)
            :base(275)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber = 0;

        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
                
                    return false;

 
            
        }

        public string WorkTheNextShift()
        {
            double totalConsumption = 0;
            for (int i = 0; i <workers.Length; i++)
            {
                totalConsumption += workers[i].GetHoneyConsumption();
                totalConsumption += GetHoneyConsumption();
            }
            shiftNumber++;
            string report = "Raport zmiany numer" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Robotnica numer " + (i + 1) + " zakończyła swoje zadanie\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Robotnica numer " + (i + 1) + " nie pracuje\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                        report += "Robotnica numer" + (i + 1) + " robi'" + workers[i].CurrentJob + "' jeszcze przez " + workers[i].ShiftsLeft + " zmiany\r\n";
                    else
                        report += "Robotnica numer " + (i + 1) + " zakończy'" + workers[i].CurrentJob + "' potej zmianie\r\n";
                        
            }

            report += "Całkowite spożycie miodu: " + totalConsumption + " jednostek";
            return report;
        }
        public override double GetHoneyConsumption()
        {
            double consumption = 0;
            double largestWorkerConsumption = 0;
            int workersDoingJobs = 0;

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption = workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    workersDoingJobs++;
                
                    
                
            }
            consumption += largestWorkerConsumption;
            if (workersDoingJobs >= 3)
                consumption += 30;
            else
            {
                consumption += 20;
            }
            return consumption;
        }
             
    }
}
