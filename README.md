# VehicleAPI

In this project, the 'Vehicle' class is a base class that contains common properties and behaviors for all other vehicle types. The 'Vehicle' class defines common properties such as Id, Color, ModelYear, and FuelType. The 'Car', 'Bus', 'Boat', and 'Plane' classes are derived from the 'Vehicle' class. These derived classes inherit the properties of the 'Vehicle' class and extend them. The 'Car' class includes additional features specific to its type, such as the 'HeadlightsOn' and 'Wheels' properties.

## API Features
- [GET] Users can select cars, buses, boats, and planes by color.
- [GET] Users can select planes by model year.
- [GET] Users can list all vehicles by model year in ascending order.
- [GET] Users can list all vehicles or all vehicles of a specific class.
- [GET] Users can list all vehicles of a specific color.
- [POST] Users can turn the headlights of a car on or off by the vehicle's ID.
- [POST] Users can add a new vehicle to the specified class.
- [DELETE] Users can delete cars and all other vehicles.

## Usage

### This request lists all vehicles.
- GET : /api/vehicles/all

![vehicles_all](https://github.com/muminkurnaz/web-api-project/assets/112796390/dd0591b7-1149-48ff-8511-f1018f51d31a)

### These requests list the respective vehicles.
- GET : /api/vehicles/cars
- GET : /api/vehicles/buses
- GET : /api/vehicles/planes
- GET : /api/vehicles/boats

![1](https://github.com/muminkurnaz/web-api-project/assets/112796390/2bec605f-ef92-4a1b-8593-3428d75a5dc4)

### These requests list the desired vehicle class by color.
- GET : /api/vehicles/cars/color/red
- GET : /api/vehicles/buses/color/white
- GET : /api/vehicles/planes/color/white
- GET : /api/vehicles/boats/color/red

![2](https://github.com/muminkurnaz/web-api-project/assets/112796390/c2935d49-b33b-4a13-bf83-f8720c561c72)

### This request lists all vehicles by color.
- GET : /api/vehicles/color/red

![3](https://github.com/muminkurnaz/web-api-project/assets/112796390/f2185e2b-027c-431b-b456-8ad56b5c492b)

### This request is used to turn the headlights on or off by car ID.
- POST : /api/vehicles/cars/1/headlights

![5](https://github.com/muminkurnaz/web-api-project/assets/112796390/7ac40fbf-87b0-44c4-81b2-949b11080a12)

### These requests are used to delete vehicles by ID.
- DELETE : /api/vehicles/cars/6
- DELETE : /api/vehicles/boats/4
- DELETE : /api/vehicles/planes/1
- DELETE : /api/vehicles/buses/2

![4](https://github.com/muminkurnaz/web-api-project/assets/112796390/fc23cd00-652e-413a-a600-96977037d80d)

### These requests are used to add vehicles to the specified class.
- POST : /api/vehicles/cars
- POST : /api/vehicles/buses
- POST : /api/vehicles/planes
- POST : /api/vehicles/boats

![6](https://github.com/muminkurnaz/web-api-project/assets/112796390/bbd437ab-fddf-4b95-8f55-8567d5fbc0f6)

### These requests list vehicles of the respective class by model year.
- GET : /api/vehicles/planes/modelyear/2023
- GET : /api/vehicles/cars/modelyear/2024
- GET : /api/vehicles/buses/modelyear/2024
- GET : /api/vehicles/boats/modelyear/2022

![MODEL_YILINA_LİSTELE](https://github.com/muminkurnaz/web-api-project/assets/112796390/da9698d4-be0e-4632-ac5f-7f15a664a8d6)

### This request lists all vehicles by model year in ascending order.
- GET : /api/vehicles/sorted/modelyear

![MODELYIL_SIRALAMA](https://github.com/muminkurnaz/web-api-project/assets/112796390/2242424b-4469-4069-a600-49bb190d3d7e)

### Requirements
- .NET 8 SDK
- Visual Studio 2022 or Visual Studio Code
