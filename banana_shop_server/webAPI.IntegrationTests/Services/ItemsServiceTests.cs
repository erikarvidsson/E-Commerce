﻿using System;
using NUnit.Framework;
using webAPI.Services;

namespace webAPI.IntegrationTests.Services
{
    public class ItemsServiceTests
    {
        private ItemsService itemsService;
        private object itemsRepository;

        [SetUp]
        public void SetUp()
        {
            this.itemsService = new ItemsService(new ItemsRepository(
                "Server=localhost;Port=8889;Database=webshop;Uid=root;Pwd=root;"));
        }


        [Test]
        public void Get_ReturnsResultsFromDatabase()
        {
            // Act
            var results = this.itemsService.Get();
            // Assert
            Assert.That(results.Count, Is.AtLeast(4));
            Assert.That(results[0].name, Is.EqualTo("TEST PRODUCT"));
            Assert.That(results[0].price, Is.EqualTo("999"));
            Assert.That(results[0].id, Is.EqualTo(1));
        }

        [Test]
        public void Get_Id_ReturnsResultsFromDatabase()
        {
            //Arrange
            const int id = 1;

            // Act
            var results = this.itemsService.Get(id);
            // Assert
            Assert.That(results.name, Is.EqualTo("TEST PRODUCT"));
            Assert.That(results.price, Is.EqualTo("999"));
        }

        //[Test]
        //public void Add_GivenValidItemsItem_SavesIt()
        //{
        //    // Arrange
        //    const string ExpectedName = "test";
        //    const string ExpectedPrice = "test";
        //    const string ExpectedDescription = "test";
        //    IAsyncResult result;

        //    var Items = new 
        //    {
        //        name = ExpectedName,
        //        price = ExpectedPrice,
        //        description = ExpectedDescription
        //    };
        //    // Act
        //    using (new TransactionScope())
        //    {
        //        this.itemsService.Add(Items);

        //        result = this.itemsService.Get().Last();
        //    }

        //    // Assert
        //    Assert.That(this.result.name, Is.EqualTo());
        //}
    }
}
