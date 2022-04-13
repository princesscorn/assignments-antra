using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Antra.DapperLearn.Data.Entity;
using Antra.DapperLearn.Data.Repositories;
namespace Antra.DapperLearn.ConsoleApp
{
    
    internal class ManageDepartment
    {
        IRepository<Department> _repository;
        public ManageDepartment ()
        {
            _repository = new DepartmentRepository();
        }
        void AddDepartment()
        {
            Department d = new Department();
            Console.WriteLine("Enter Department Name = ");
            d.DName = Console.ReadLine();
            Console.WriteLine("Enter Location = ");
            d.Loc = Console.ReadLine();
            _repository.Insert(d);
        }

        void PrintAll()
        {
            var collection = _repository.GetAll();
            foreach (var d in collection)
            {
                Console.WriteLine($"{d.Id} \t {d.DName} \t {d.Loc}");
            }
        }

        public void Run()
        {
            PrintAll();
        }
    }    
}
