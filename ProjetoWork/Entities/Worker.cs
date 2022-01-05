using System;
using ProjetoWork.Entities.Enums;
using ProjetoWork.Entities;


namespace ProjetoWork.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }

        void AddContract(HourContrat contract)
        {

        }
    }
}
