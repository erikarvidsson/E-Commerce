CREATE TABLE Orders (
    id int NOT NULL AUTO_INCREMENT,
    name varchar(128) NOT NULL,
    adress varchar(128) NOT NULL,
    number text NOT NULL,
    phone int NOT NULL,
    CONSTRAINT Orders_pk PRIMARY KEY (id)
);

CREATE TABLE PlacedOrder (
    id int NOT NULL AUTO_INCREMENT,
    name varchar(128) NOT NULL,
    price int(128) NOT NULL,
    number text NOT NULL,
    phone int NOT NULL,
    CONSTRAINT Orders_pk PRIMARY KEY (id)
);


CREATE TABLE Cart (
    id int NOT NULL AUTO_INCREMENT,
    CONSTRAINT Cart_pk PRIMARY KEY (id)
);

CREATE TABLE Products (
    id int NOT NULL AUTO_INCREMENT,
    price int NOT NULL,
    name varchar(128) NOT NULL,
    description text NOT NULL,
    img_url text NOT NULL,
    quantity text NOT NULL,
    CONSTRAINT Products_pk PRIMARY KEY (id)
);

CREATE TABLE Customers (
    id int NOT NULL AUTO_INCREMENT,
    name text NOT NULL,
    adress text NOT NULL,
    phone int NOT NULL,
    CONSTRAINT Customers_pk PRIMARY KEY (id)
);


CREATE TABLE Order_Products (
    products_id int NOT NULL,
    orders_id int NOT NULL,
    PRIMARY KEY (orders_id, products_id),
    
    FOREIGN KEY (products_id) REFERENCES Products(id),
    FOREIGN KEY (orders_id) REFERENCES Orders(id)
);



SELECT Orders.* , Products.* FROM Order_Products
LEFT JOIN Orders ON Order_Products.orders_id = orders_id
LEFT JOIN Products ON Order_Products.products_id = products_id