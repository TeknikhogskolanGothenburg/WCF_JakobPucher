using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL;
using Domain;

namespace RentalCarService
{
    [ServiceContract]
    public interface IRentalCarService
    {
        [OperationContract]
        Car[] GetAllCars();

        [OperationContract]
        Car[] GetAvailableCars(DateTime start, DateTime end);

        [OperationContract]
        void AddNewCar(Car car);

        [OperationContract]
        void RemoveCar(int id);

        [OperationContract]
        void RemoveCustomer(int id);

        [OperationContract]
        List<Customer> GetAllCustomers();

        [OperationContract]
        List<Booking> GetAllBookings();

        [OperationContract]
        void RemoveBooking(int id);

        [OperationContract]
        void CreateBooking(Booking booking);

        [OperationContract]
        void EditCustomer(Customer customer);

        [OperationContract]
        void AddCustomer(Customer customer);

        [OperationContract]
        Customer GetCustomerByEmail(string email);

        [OperationContract]
        Customer GetCustomer(int id);

        [OperationContract]
        void ReturnCar(int id);
    }
}