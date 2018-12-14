using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BL;
using Domain;

namespace RentalCarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RentalCarService" in both code and config file together.
    public class RentalCarService : IRentalCarService, IRentalCarServiceREST
    {
        public void AddNewCar(Car car)
        {
            new CarService().Add(car);
        }

        //Message Contract Exempel
        public CarInfo GetCarById(int id)
        {
            var service = new CarService();
            var car = service.GetById(id);
            CarInfo carInfo = new CarInfo
            {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                RegNr = car.RegNr,
                Year = car.Year
            };
            return carInfo;
        }

        public Car GetCarById(string id)
        {
            var service = new CarService();
            var car = service.GetById(int.Parse(id));
            return car;
        }

        public void RemoveCar(int id)
        {
            new CarService().Remove(id);
        }

        public void RemoveCar(string id)
        {
            new CarService().Remove(int.Parse(id));
        }

        public Car[] GetAllCars()
        {
            var service = new CarService();
            var cars = service.GetAllCars();
            return cars.ToArray();
        }

        public Car[] GetAvailableCars(DateTime start, DateTime end)
        {
            return new CarService().GetAvailableCars(start, end).ToArray();
        }

        public List<Customer> GetAllCustomers()
        {
            return new CustomerService().GetAll();
        }

        public void RemoveCustomer(int id)
        {
            new CustomerService().Remove(id);
        }

        public List<Booking> GetAllBookings()
        {
            var bs = new BookingService();
            return bs.GetAllBookings();
        }

        public void RemoveBooking(int id)
        {
            var bs = new BookingService();
            var booking = bs.Get(id);
            bs.Remove(booking);
        }

        public void EditCustomer(Customer customer)
        {
            var cs = new CustomerService();
            cs.Update(customer);

        }

        public void AddCustomer(Customer customer)
        {
            var cs = new CustomerService();
            cs.Add(customer);
        }

        public void CreateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByEmail(string email)
        {
            var cs = new CustomerService();
            var customer = cs.Get(email);
            return customer;
        }

        public Customer GetCustomer(int id)
        {
            var cs = new CustomerService();
            var customer = cs.Get(id);
            return customer;
        }

        public void ReturnCar(int id)
        {
            new BookingService().IsReturned(id);
        }
    }
}