# Netflix
WPF app used to render results from a web API

This includes 2 solutions:
1) Netflix.WebAPI
2) Netflix.WPFApp

The API is written in .NET Core and returns 100 json objects (giving details of movies on Netflix) in this format:

{ 
 " userId ": 1, 
 " id ": 1, 
 " title ": "sunt aut facere repellat provident...", 
 " body ": "quia et suscipit\nsuscipi..."
}

The WPF app is also written in .NET Core and renders the 100 json objects on its UI, where each post is a separate square, 10 rows x 10 columns.

By default the id property is shown on each square. When clicking on any sqaure the id property on every square changes to the userId property.

To run this:
1) Clone the Netflix repo
3) Using Visual Studio open Netflix.WebAPI and select Play/Run -> this will run the API. To get the json object results go to localhost:xxxx/netflix
4) Using another Visual Studio open Netflix.WPFApp and select Play/Run -> this will launch the WPF app UI

Still to do:
1) Improve UI layout and design
2) Add logging to WPF app
