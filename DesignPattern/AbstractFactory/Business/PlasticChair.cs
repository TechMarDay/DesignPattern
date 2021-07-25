using AbstractFactory.Business.Interface;
using System;

namespace AbstractFactory.Business
{
    public class PlasticChair : IChair
    {
        public void Create()
        {
            Console.WriteLine("Create new plastic chair");
        }
    }
}