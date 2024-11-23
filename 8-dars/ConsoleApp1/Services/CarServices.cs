using System.Collections.Generic;
using System;


internal class CarService
{
    private List<Car> cars;

    public CarService()
    {
        cars = new List<Car>();
        DataSeed();
    }
    public Car AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        cars.Add(car);

        return car;
    }

    public bool DeleteCar(Guid studentId)
    {
        var exists = false;
        foreach (var car in cars)
        {
            if (car.CarId == studentId)
            {
                cars.Remove(car);
                exists = true;
                break;
            }
        }

        return exists;
    }

    public bool UpdateCar(Car updateCar)
    {
        for (var i = 0; i < cars.Count; i++)
        {
            if (cars[i].CarId == updateCar.CarId)
            {
                cars[i] = updateCar;
                return true;
            }
        }

        return false;
    }

    public List<Car> GetAllCars()
    {
        return cars;
    }

    public Car GetById(Guid carId)
    {
        foreach (var car in cars)
        {
            if (car.CarId == carId)
            {
                return car;
            }
        }

        return null;
    }

    private void DataSeed()
    {
        var firstCar = new Car()
        {
            CarId = Guid.NewGuid(),
            CarType = "chaevrolet",
            CarName = "Malibu",
            CarColor = "oq",
            CarPrice = 19000,
        };
        var secondCar = new Car()
        {
            CarId = Guid.NewGuid(),
            CarType = "chaevrolet",
            CarName = "Spark",
            CarColor = "mokriy",
            CarPrice = 9000,
        };

        cars.Add(firstCar);
        cars.Add(secondCar);

    }
}