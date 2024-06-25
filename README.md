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
GET : http://localhost:5038/api/vehicles/all
![vehicles_all](https://github.com/muminkurnaz/web-api-project/assets/112796390/dd0591b7-1149-48ff-8511-f1018f51d31a)

### Bu istekler ilgili araçları listeler
GET : /api/vehicles/cars
GET : /api/vehicles/buses
GET : /api/vehicles/planes
GET : /api/vehicles/boats

### Bu istek arabaları rengine göre listeler.
GET : /api/vehicles/cars/color/red
Bu istek otobüsleri rengine göre listeler.
GET : /api/vehicles/buses/color/white
Bu istek uçakları rengine göre listeler. 
GET : /api/vehicles/planes/color/white
Bu istek tekneleri rengine göre listeler.
GET : /api/vehicles/boats/color/red

### Bu istek tüm araçları rengine göre listeler.
GET : /api/vehicles/color/red

### Bu istek arabaları ID numarasına göre farları açıp kapatabilmeye yarar.
POST : /api/vehicles/cars/1/headlights
![ıd_far_ac_kapa](https://github.com/muminkurnaz/web-api-project/assets/112796390/e905e9b4-1625-48f4-bdde-287d4b6378b2)


Bu istekler araçları ID numarasına göre silmeye yarar.
DELETE : /api/vehicles/cars/6
DELETE : /api/vehicles/boats/4
DELETE : /api/vehicles/planes/1
DELETE : /api/vehicles/buses/2

Bu istekler ilgili sınıfa araç eklemeye yarar.
POST : /api/vehicles/cars
POST : /api/vehicles/buses
POST : /api/vehicles/planes
POST : /api/vehicles/boats
![arac_ekleme](https://github.com/muminkurnaz/web-api-project/assets/112796390/06c38d45-80ad-4a6b-ad30-0a05b4d66231)


Bu istekler ilgili sınıfa ait araçları model yılına göre listeler.
GET : /api/vehicles/planes/modelyear/2023
GET : /api/vehicles/cars/modelyear/2024
GET : /api/vehicles/buses/modelyear/2024
GET : /api/vehicles/boats/modelyear/2022
![MODEL_YILINA_LİSTELE](https://github.com/muminkurnaz/web-api-project/assets/112796390/da9698d4-be0e-4632-ac5f-7f15a664a8d6)

Bu istek tüm araçları model yılına göre artan şekilde listeler.
GET : http://localhost:5038/api/vehicles/sorted/modelyear
![MODELYIL_SIRALAMA](https://github.com/muminkurnaz/web-api-project/assets/112796390/2242424b-4469-4069-a600-49bb190d3d7e)

### Postman Test Ekran Görüntüleri


### Gereksinimler
- .NET 8 SDK
- Visual Studio 2022 veya Visual Studio Code



