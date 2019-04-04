### Simple webshop in - C#

> C# assignment to build a webshop API 

### Languages Used:
- C# 
- MySQL

**( In this project we use an sqlite database to store information )**

---

#### Testers
- First name Lastname

#### Functionalities:

* [x] Add products
* [x] List all products
* [x] List single product
* [x] Buy product
* [x] View order

#### Example JSON to use for post (postman)

Add product
http://localhost:28071/api/items (Post)
{
        "name": "Bananananana",
        "price": 500,
        "img_url": "http://clipart-library.com/images/gieG7Leid.png",
        "description": "Detta är en bannan från ett banan träd någon stans i världen"
}

Get your uniq guid value - used to add product, and place order, view order
http://localhost:28071/api/myguid (Get)

Get Products
http://localhost:28071/api/items (Get)

Get Product by id
http://localhost:28071/api/items/id (Get)

Place product in cart 
http://localhost:28071/api/cart (Post)

{
	“guid”: “Your guid”,
	“product_id”: “id of the product you want”
}

Place your order
http://localhost:28071/api/placeorder (Post)
{
	    "name": “Your name”,
        "adress": “Delivery adress”,
        "phone": “Phone number”,
        "guid": "“***Your guid***"
}

Look at order 
http://localhost:28071/api/viewplacedorder2/yourGuid (Get)
{
	"guid": "Your guid"
}


---
YRGO - Assignment 2019 ( C# ) - 2019-04-04 09:00 URL https://github.com/erikarvidsson/E-Commerce
[Code License: MIT](https://github.com/erikarvidsson/E-Commerce/blob/master/LICENSE)
