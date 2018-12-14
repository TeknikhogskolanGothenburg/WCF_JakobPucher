using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RentalCarService
{
    [ServiceContract]
    public interface IRentalCarServiceREST
    {

        [OperationContract(Name = "AddnewCarREST")]
        [WebInvoke(Method = "POST", UriTemplate = "Cars",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        void AddNewCar(Car car);

        [OperationContract(Name = "GetCarByIdREST")]
        [WebGet(UriTemplate = "Cars/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        Car GetCarById(string id);

        [OperationContract(Name = "GetAllCarsREST")]
        [WebGet(UriTemplate = "Cars",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        Car[] GetAllCars();

        [OperationContract(Name = "RemoveCarREST")]
        [WebInvoke(Method = "DELETE", UriTemplate = "Cars/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        void RemoveCar(string id);

    }
}
