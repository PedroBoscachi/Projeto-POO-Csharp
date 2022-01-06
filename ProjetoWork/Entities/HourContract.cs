using System;

namespace ProjetoWork.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuerPerHour { get; set; }
        public int Hours { get; set; } 

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuerperhour, int hours)
        {
            Date = date;
            ValuerPerHour = valuerperhour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return this.ValuerPerHour * this.Hours;
        }
    }
}
