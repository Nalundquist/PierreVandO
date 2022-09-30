# Pierre's Bakery Vendor and Order Interface

### Created by Noah Lundquist in September of 2022

## Links

* [Repository](https://github.com/nalundquist/PierreVandO)

## Description

A Vendor and Order interface for Pierre's Bakery.  Uses Models, Views and Controllers through ASP.NET Core to display user inputs in lists.  Build in C#, HTML and CSS.  The narrator of the prompts is somewhat restrained in tone but thinks the world of Pierre (and not much of his customers).

## Features

* Stores Vendor names and descriptions and Orders from said Vendors with fields based on a title for the order, description, price and date.
* Orders can be looked at individually.
* More Gluten
* Spartan CSS styling (color scheme is a little garish tbh)
* Uses a layout and partials to decrease the amount of repeated code.


## Technologies Used

* Built in VS Code (v.1.70.1) using the following languages:
	* C#
	* HTML
	* CSS

## Installation

* Download [Git Bash](https://git-scm.com/downloads)
* Input the following into Git Bash to clone this repository onto your computer:

		>git clone https://github.com/nalundquist/PierreVandO

* Enter the cloned project folder "PierreVandO/PierreVandO" and type:

		>dotnet restore

followed by

		>dotnet build

and finally

		>dotnet run

Follwing this you can navigate to http://localhost:5000 in the browser of your choice to navigate around the vendor/order interface.  

## Known Bugs

* Orders made under a specific Vendor can be accessed under other Vendor's VendorId field; I.E. if you make two vendors "Trudy's Cafe" and "Bartholemew's Sandwiches" they would have VendorId 1 and 2, respectively.  If you made two croissant orders to Trudy's they would have OrderId 1 and 2 and both be listed under orders made by Trudy's when clicking on her link on the Vendor List page, routing you to "../vendors/1/orders/{orderId}".  However, if you were to type "../vendors/2/orders/{orderId}" into your browser with the order number of either of these orders the text on the page/links would act as though this order was made through Bartholemew's.  Could be remedied by making orderId of items tied to the VendorId making said order but I don't have the time to fix such at this point.  

## License

Licensed under [GNU GPL 3.0](https://www.gnu.org/licenses/gpl-3.0.en.html)