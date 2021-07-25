using AbstractFactory.Business.Interface;
using System;

namespace AbstractFactory.Business
{
    public class WoodTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("Create new wood table");
        }
    }
}