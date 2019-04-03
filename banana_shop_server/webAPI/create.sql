-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Apr 03, 2019 at 10:38 AM
-- Server version: 5.7.23
-- PHP Version: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Database: `webshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `Cart`
--

CREATE TABLE `Cart` (
  `id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `guid` text NOT NULL,
  `orderd` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Cart`
--

INSERT INTO `Cart` (`id`, `product_id`, `guid`, `orderd`) VALUES
(1, 2, '23123', 0),
(2, 2, '23123', 0),
(3, 6, '23', 1),
(4, 6, '23', 1),
(5, 6, '29', 0),
(6, 9, 'a29', 0),
(31, 4, 'a50bea19-e45f-4ba0-9862-010b23cc8f78', 1),
(32, 4, 'a50bea19-e45f-4ba0-9862-010b23cc8f78', 1),
(33, 3, 'a50bea19-e45f-4ba0-9862-010b23cc8f78', 1),
(34, 2, 'a50bea19-e45f-4ba0-9862-010b23cc8f78', 1),
(55, 1, '829c3cae-1b6d-448b-94c1-aa0c0a2946c3', 0),
(56, 1, '829c3cae-1b6d-448b-94c1-aa0c0a2946c3', 0),
(57, 1, '829c3cae-1b6d-448b-94c1-aa0c0a2946c3', 0),
(58, 1, '829c3cae-1b6d-448b-94c1-aa0c0a2946c3', 0),
(65, 5, 'new231235', 0);

-- --------------------------------------------------------

--
-- Table structure for table `Customers`
--

CREATE TABLE `Customers` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `adress` text NOT NULL,
  `phone` text NOT NULL,
  `guid` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Customers`
--

INSERT INTO `Customers` (`id`, `name`, `adress`, `phone`, `guid`) VALUES
(19, 'TEDST', 'TEDST', '070778797', '123'),
(20, 'TEDST2', 'TEDST3', '074778797', '23'),
(21, 'allan', 'testvagen 24', '07454545', '23'),
(22, 'allan', 'testvagen 24', '07454545', '23'),
(23, 'allan', 'testvagen 24', '07454545', '23'),
(24, 'allan', 'testvagen 24', '07454545', '23'),
(25, 'allan', 'testvagen 24', '07454545', 'a50bea19-e45f-4ba0-9862-010b23cc8f78'),
(26, 'Erik', 'Arvidsson', '074778727', 'a50bea19-e45f-4ba0-9862-010b23cc8f78'),
(27, 'allan', 'testvagen 24', '07454545', 'a50bea19-e45f-4ba0-9862-010b23cc8f78');

-- --------------------------------------------------------

--
-- Table structure for table `Items`
--

CREATE TABLE `Items` (
  `id` int(11) NOT NULL,
  `price` text NOT NULL,
  `name` varchar(128) NOT NULL,
  `description` text NOT NULL,
  `img_url` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Items`
--

INSERT INTO `Items` (`id`, `price`, `name`, `description`, `img_url`) VALUES
(1, '999', 'TEST PRODUCT', 'SADA', 'http://clipart-library.com/images/gieG7Leid.png'),
(2, '99', 'Brown banana', 'A brown dotted banana', 'http://clipart-library.com/images/gieG7Leid.png'),
(3, '10000', 'Yellow banana', 'A no brown dotts banana', 'http://clipart-library.com/images/gieG7Leid.png'),
(4, '400', 'bananshell', 'ett bananskal', 'http://clipart-library.com/images/gieG7Leid.png'),
(5, '500', 'Bananananana', 'Detta är en bannan från ett banan träd någon stans i världen', 'http://clipart-library.com/images/gieG7Leid.png');

-- --------------------------------------------------------

--
-- Table structure for table `Order_Products`
--

CREATE TABLE `Order_Products` (
  `products_id` int(11) NOT NULL,
  `orders_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Order_Products`
--

INSERT INTO `Order_Products` (`products_id`, `orders_id`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `PlacedOrder`
--

CREATE TABLE `PlacedOrder` (
  `guid` text NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `PlacedOrder`
--

INSERT INTO `PlacedOrder` (`guid`, `id`) VALUES
('23', 23),
('23', 24),
('a50bea19-e45f-4ba0-9862-010b23cc8f78', 25),
('a50bea19-e45f-4ba0-9862-010b23cc8f78', 26),
('a50bea19-e45f-4ba0-9862-010b23cc8f78', 27);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Cart`
--
ALTER TABLE `Cart`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Customers`
--
ALTER TABLE `Customers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Items`
--
ALTER TABLE `Items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Order_Products`
--
ALTER TABLE `Order_Products`
  ADD PRIMARY KEY (`orders_id`,`products_id`),
  ADD KEY `products_id` (`products_id`);

--
-- Indexes for table `PlacedOrder`
--
ALTER TABLE `PlacedOrder`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Cart`
--
ALTER TABLE `Cart`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT for table `Customers`
--
ALTER TABLE `Customers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `Items`
--
ALTER TABLE `Items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `PlacedOrder`
--
ALTER TABLE `PlacedOrder`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Order_Products`
--
ALTER TABLE `Order_Products`
  ADD CONSTRAINT `order_products_ibfk_1` FOREIGN KEY (`products_id`) REFERENCES `Products` (`id`),
  ADD CONSTRAINT `order_products_ibfk_2` FOREIGN KEY (`orders_id`) REFERENCES `Orders` (`id`);
