﻿using Projekt_MVC.Models;
using Projekt_MVC.Models.Car;
using Projekt_MVC.Services.Car;
namespace Projekt_MVC.Services
{
    public interface ICarService
    {
        public List<CarModel> GetCars();
        public void CreateCar(int id, string name, string model, string color, string year, string price, string description, EngineEnum engine, int horsePower);
        void DeleteCar(int id);
        void EditCar(int id, string name, string model, string color, string year, string price, string description, EngineEnum engine, int horsePower);
    }
}