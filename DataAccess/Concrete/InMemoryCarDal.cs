using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal
    {
        List<Car> _cars;
      

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear="2019", DailyPrice=500, Description="BMW - M4"},
                new Car{Id=1, BrandId=2, ColorId=1, ModelYear="2018", DailyPrice=450, Description="BMW - 520d"},
                new Car{Id=2, BrandId=1, ColorId=1, ModelYear="2014", DailyPrice=400, Description="AUDI - A5 "},
                new Car{Id=3, BrandId=1, ColorId=1, ModelYear="2020", DailyPrice=500, Description="AUDI - A3 "}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.Id = car.Id;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;

            
        }
    }
}
