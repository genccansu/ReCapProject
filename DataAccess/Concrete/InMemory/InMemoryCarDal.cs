
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
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=1, DailyPrice=50000, ModelYear=2010, Description="Opel Vectra"},
                new Car{ Id=2, BrandId=1, ColorId=1, DailyPrice=48000, ModelYear=2009, Description="Opel Corsa"},
                new Car{ Id=3, BrandId=2, ColorId=2, DailyPrice=90000, ModelYear=2008, Description="Jeep Rubicon"},
                new Car{ Id=4, BrandId=3, ColorId=3, DailyPrice=22000, ModelYear=2018, Description="BMW "},
                new Car{ Id=5, BrandId=2, ColorId=4, DailyPrice=500000, ModelYear=2019, Description="Ranch Rover"}

            };
        }




        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int CarId)
        {

            return _cars.Where(c => c.Id == CarId).ToList();
        }

           public void Update(Car car)
            {
                Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

                carToUpdate.Id = car.Id;
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;

            }
        }

        
    } 
