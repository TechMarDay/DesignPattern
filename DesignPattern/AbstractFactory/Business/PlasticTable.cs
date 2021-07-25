using AbstractFactory.Business.Interface;
using System;

namespace AbstractFactory.Business
{
    public class PlasticTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("Create new Plastic table");
        }
    }
}