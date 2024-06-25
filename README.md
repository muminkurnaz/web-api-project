# VehicleAPI

Bu projede, 'Vehicle' sınıfı, diğer tüm araç türleri için ortak özellikleri ve davranışları içeren bir temel sınıftır. 'Vehicle' sınıfı, Id, Color, ModelYear ve FuelType gibi ortak özellikleri tanımlar.
'Car', 'Bus', 'Boat' ve 'Plane' sınıfları, 'Vehicle' sınıfından türetilmiş sınıflardır.Bu türetilmiş sınıflar, Vehicle sınıfının özelliklerini miras alır ve onları genişletir. 'Car' sınıfı, kendi türüne özgü ekstra özellikleri 'HeadlightsOn' ve 'Wheels' özelliğini içerir.

## API' nin özellikleri
• [GET] Kullanıcı arabaları.otobüsleri,tekneleri ve uçakları rengine göre seçebilir.
• [GET] Kullanıcı uçakları model yılına göre seçebilir.
• [GET] Kullanıcı tüm araçları model yılına göre artan şekilde listeleyebilir.
• [GET] Kullanıcı tüm araçları veya istediği sınıftaki tüm araçları listeleyebilir.
• [GET] Kullanıcı belirli renkteki tüm araçları listeleyebilir.
• [POST] Kullanıcı, aracın farlarını aracın kimliğine(ID) göre açıp kapatabilir.
• [POST] Kullanıcı, belirttiği sınıfa yeni araç ekleyebilir.
• [DELETE] Kullanıcı arabayı ve diğer tüm araçları silebilir.

### Kullanım
Bu istek tüm araçları listeler.
http://localhost:5038/api/vehicles/all

Bu istekler ilgili araçları listeler
http://localhost:5038/api/vehicles/cars
http://localhost:5038/api/vehicles/buses
http://localhost:5038/api/vehicles/planes
http://localhost:5038/api/vehicles/boats

Bu istek arabaları rengine göre listeler.
http://localhost:5038/api/vehicles/cars/color/red
Bu istek otobüsleri rengine göre listeler.
http://localhost:5038/api/vehicles/buses/color/white
Bu istek uçakları rengine göre listeler. 
http://localhost:5038/api/vehicles/planes/color/white
Bu istek tekneleri rengine göre listeler.
http://localhost:5038/api/vehicles/boats/color/red

Bu istek tüm araçları rengine göre listeler.
http://localhost:5038/api/vehicles/color/red

Bu istek arabaları ID numarasına göre farları açıp kapatabilmeye yarar.
http://localhost:5038/api/vehicles/cars/1/headlights

Bu istekler araçları ID numarasına göre silmeye yarar.
http://localhost:5038/api/vehicles/cars/6
http://localhost:5038/api/vehicles/boats/4
http://localhost:5038/api/vehicles/planes/1
http://localhost:5038/api/vehicles/buses/2

Bu istekler ilgili sınıfa araç eklemeye yarar.
http://localhost:5038/api/vehicles/cars
http://localhost:5038/api/vehicles/buses
http://localhost:5038/api/vehicles/planes
http://localhost:5038/api/vehicles/boats

Bu istekler ilgili sınıfa ait araçları model yılına göre listeler.
http://localhost:5038/api/vehicles/planes/modelyear/2023
http://localhost:5038/api/vehicles/cars/modelyear/2024
http://localhost:5038/api/vehicles/buses/modelyear/2024
http://localhost:5038/api/vehicles/boats/modelyear/2022

Bu istek tüm araçları model yılına göre artan şekilde listeler.
http://localhost:5038/api/vehicles/sorted/modelyear

### Gereksinimler
- .NET 8 SDK
- Visual Studio 2022 veya Visual Studio Code



