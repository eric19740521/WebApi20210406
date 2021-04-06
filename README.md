# WebApi20210406

dotnet5 C# WebApi 簡單應用


參考資料:
https://www.youtube.com/channel/UCsb1wk-deZhVorMJ4Q_nWRg/featured 凱哥寫程式

https://ithelp.ithome.com.tw/articles/10194989



1.建立專案webapi03
dotnet new webapi

測試是否可用???
http://localhost:5000/swagger/index.html

http://localhost:5000/WeatherForecast

2.Controllers 加入一個控制器
ValuesController.cs

http://localhost:5000/api/values

砍掉WeatherForecastController.cs/WeatherForecast.cs
看是否能動作???

3.複製 ValuesController.cs ,改寫成 MembersController.cs
命名空間改成webapi03


4.

get  http://localhost:5000/api/members

get  http://localhost:5000/api/members/{id}

post http://localhost:5000/api/members         members

put  http://localhost:5000/api/members/{id}         members

delete http://localhost:5000/api/members/{id}


程式碼
https://github.com/eric19740521/WebApi20210406.git




