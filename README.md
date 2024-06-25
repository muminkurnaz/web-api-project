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


### Gereksinimler
- .NET 8 SDK
- Visual Studio 2022 veya Visual Studio Code

