# VehicleAPI

Bu projede, 'Vehicle' sınıfı, diğer tüm araç türleri için ortak özellikleri ve davranışları içeren bir temel sınıftır. 'Vehicle' sınıfı, Id, Color, ModelYear ve FuelType gibi ortak özellikleri tanımlar.
'Car', 'Bus', 'Boat' ve 'Plane' sınıfları, 'Vehicle' sınıfından türetilmiş sınıflardır.Bu türetilmiş sınıflar, Vehicle sınıfının özelliklerini miras alır ve onları genişletir. 'Car' sınıfı, kendi türüne özgü ekstra özellikleri 'HeadlightsOn' ve 'Wheels' özelliğini içerir.

http://localhost:5038

## API' nin özellikleri
- [GET] Kullanıcı arabaları.otobüsleri,tekneleri ve uçakları rengine göre seçebilir.
- [GET] Kullanıcı uçakları model yılına göre seçebilir.
- [GET] Kullanıcı tüm araçları model yılına göre artan şekilde listeleyebilir.
- [GET] Kullanıcı tüm araçları veya istediği sınıftaki tüm araçları listeleyebilir.
- [GET] Kullanıcı belirli renkteki tüm araçları listeleyebilir.
- [POST] Kullanıcı, aracın farlarını aracın kimliğine(ID) göre açıp kapatabilir.
- [POST] Kullanıcı, belirttiği sınıfa yeni araç ekleyebilir.
- [DELETE] Kullanıcı arabayı ve diğer tüm araçları silebilir.

## Kullanım

### Bu istek tüm araçları listeler.
- GET : /api/vehicles/all

![vehicles_all](https://github.com/muminkurnaz/web-api-project/assets/112796390/dd0591b7-1149-48ff-8511-f1018f51d31a)

### Bu istekler ilgili araçları listeler
- GET : /api/vehicles/cars
- GET : /api/vehicles/buses
- GET : /api/vehicles/planes
- GET : /api/vehicles/boats

![1](https://github.com/muminkurnaz/web-api-project/assets/112796390/2bec605f-ef92-4a1b-8593-3428d75a5dc4)

### Bu istekler istenilen araç sınıfını rengine göre listeler.
- GET : /api/vehicles/cars/color/red
- GET : /api/vehicles/buses/color/white
- GET : /api/vehicles/planes/color/white
- GET : /api/vehicles/boats/color/red

![2](https://github.com/muminkurnaz/web-api-project/assets/112796390/c2935d49-b33b-4a13-bf83-f8720c561c72)

### Bu istek tüm araçları rengine göre listeler.
- GET : /api/vehicles/color/red

![3](https://github.com/muminkurnaz/web-api-project/assets/112796390/f2185e2b-027c-431b-b456-8ad56b5c492b)

### Bu istek arabaları ID numarasına göre farları açıp kapatabilmeye yarar.
- POST : /api/vehicles/cars/1/headlights
 
![5](https://github.com/muminkurnaz/web-api-project/assets/112796390/7ac40fbf-87b0-44c4-81b2-949b11080a12)

### Bu istekler araçları ID numarasına göre silmeye yarar.
- DELETE : /api/vehicles/cars/6
- DELETE : /api/vehicles/boats/4
- DELETE : /api/vehicles/planes/1
- DELETE : /api/vehicles/buses/2

![4](https://github.com/muminkurnaz/web-api-project/assets/112796390/fc23cd00-652e-413a-a600-96977037d80d)

### Bu istekler ilgili sınıfa araç eklemeye yarar.
- POST : /api/vehicles/cars
- POST : /api/vehicles/buses
- POST : /api/vehicles/planes
- POST : /api/vehicles/boats
 
![6](https://github.com/muminkurnaz/web-api-project/assets/112796390/bbd437ab-fddf-4b95-8f55-8567d5fbc0f6)

### Bu istekler ilgili sınıfa ait araçları model yılına göre listeler.
- GET : /api/vehicles/planes/modelyear/2023
- GET : /api/vehicles/cars/modelyear/2024
- GET : /api/vehicles/buses/modelyear/2024
- GET : /api/vehicles/boats/modelyear/2022
 
![MODEL_YILINA_LİSTELE](https://github.com/muminkurnaz/web-api-project/assets/112796390/da9698d4-be0e-4632-ac5f-7f15a664a8d6)

### Bu istek tüm araçları model yılına göre artan şekilde listeler.
- GET : /api/vehicles/sorted/modelyear

![MODELYIL_SIRALAMA](https://github.com/muminkurnaz/web-api-project/assets/112796390/2242424b-4469-4069-a600-49bb190d3d7e)


### Gereksinimler
- .NET 8 SDK
- Visual Studio 2022 veya Visual Studio Code



