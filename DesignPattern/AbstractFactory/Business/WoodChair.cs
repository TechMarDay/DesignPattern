using AbstractFactory.Business.Interface;
using System;

namespace AbstractFactory.Business
{
    public class WoodChair : IChair
    {
        public void Create()
        {
            Console.WriteLine("Create new wood chair");
        }
    }
}