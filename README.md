![Picture of various baked goods on a wooden table.](https://www.snackandbakery.com/ext/resources/images/bakeryproducts.jpg?1432238179)
# Pierre's Bakery Vendor and Order Tracker
#### an MVC application to help Pierre track the vendors that purchase baked goods from him and the orders belonging to those vendors.
#### By Suzanne Schuber

## Technologies Used

* ASP.NET MVC
* MSTest,
* C# 
* HTML
* CSS
* Git
* Razor Views

## This app contains the following features:
* The homepage is a splash page welcoming Pierre and providing him with a link to a vendors page. 
* The vendors page contains a link to a page presenting Pierre with a form he can fill out to create a new vendor and after the form is submitted, Pierre is routed back to the homepage.
* Pierre is able to click a vendor's name and go to a new page that will display all of that vendor's orders.
* Pierre is provided with a link to a page presenting him with a form to create a new order for a particular vendor.

## Setup/Installation Requirements

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called "VendorOrderTracker". 
3. Run `dotnet watch run` in the command line to start the project in development mode with a watcher.

## Known Bugs
The order info for each vendor seems to be populating but not showing up on the page. A number is visable but not the order info that has been entered.

## License
MIT License

Copyright (c) 2023 Suzanne Schuber

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.