using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
  
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

                new Car { CarId = 0123, BrandId = 20, ColorId = 2, ModelYear = 2020, DailyPrice = 1500, Description = "very fast", CarName = "BMW" },
               new Car { CarId = 3, BrandId = 30, ColorId = 42, ModelYear = 2010, DailyPrice = 1000, Description = "otomatic", CarName = "Honda" },
               new Car { CarId = 013, BrandId = 50, ColorId = 7, ModelYear = 2021, DailyPrice = 3500, Description = "confortable", CarName = "RangeRover" },
               new Car { CarId = 023, BrandId = 10, ColorId = 5, ModelYear = 1920, DailyPrice = 1500, Description = "vintage car", CarName = "Mercedes" },

            };


        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car) 
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int CategoryId)
        {
          return _cars.Where(c=>c.CategoryId==CategoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarName = car.CarName;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
