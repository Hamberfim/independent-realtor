using IndependentRealtorApp.Controllers;
using IndependentRealtorApp.Models;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace IndependentRealtorApp.Tests
{
    public class UserTest
    {
        [Theory]
        [InlineData(1, "FirstName1", "LastName1", "ut1@fake.com")]
        [InlineData(2, "FirstName2", "LastName2", "ut2@fake.com")]
        public void GetAndSet_UserProperties(int userId, string firstName, string lastName, string userEmail)
        {
            // Arrange
            var user = new User
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                UserEmail = userEmail
            };

            // Act
            var resultUserId = user.UserId;
            var resultFirstName = user.FirstName;
            var resultLastName = user.LastName;
            var resultUserEmail = user.UserEmail;
            var resultFullName = user.FullName;

            // Assert
            Assert.Equal(userId, resultUserId);
            Assert.Equal(firstName, resultFirstName);
            Assert.Equal(lastName, resultLastName);
            Assert.Equal(userEmail, resultUserEmail);
            Assert.Equal($"{firstName} {lastName}", resultFullName);
        }
        public class TestUserFullName
        {
            [Fact]
            public void FullName_Returns_CorrectFullName()
            {
                // Arrange
                var user = new User
                {
                    FirstName = "John",
                    LastName = "Doe"
                };

                // Act
                var fullName = user.FullName;

                // Assert
                Assert.Equal("John Doe", fullName);
            }

        }




        public class PropertyTest
        {
            [Theory]
            [InlineData(1, "Title1", "Description1", "Address1", "City1", "State1", "Zip1", "Status1", 100000.00)]
            [InlineData(2, "Title2", "Description2", "Address2", "City2", "State2", "Zip2", "Status2", 200000.00)]
            public void GetAndSet_PropertyProperties(int propertyId, string title, string description, string address, string city, string state, string zip, string status, double? price)
            {
                // Arrange
                var property = new Property
                {
                    PropertyId = propertyId,
                    PropertyTitle = title,
                    PropertyDescription = description,
                    PropertyAddress = address,
                    PropertyCity = city,
                    PropertyState = state,
                    PropertyZip = zip,
                    PropertyStatus = status,
                    PropertyPrice = price
                };

                // Act
                var resultPropertyId = property.PropertyId;
                var resultTitle = property.PropertyTitle;
                var resultDescription = property.PropertyDescription;
                var resultAddress = property.PropertyAddress;
                var resultCity = property.PropertyCity;
                var resultState = property.PropertyState;
                var resultZip = property.PropertyZip;
                var resultStatus = property.PropertyStatus;
                var resultPrice = property.PropertyPrice;

                // Assert
                Assert.Equal(propertyId, resultPropertyId);
                Assert.Equal(title, resultTitle);
                Assert.Equal(description, resultDescription);
                Assert.Equal(address, resultAddress);
                Assert.Equal(city, resultCity);
                Assert.Equal(state, resultState);
                Assert.Equal(zip, resultZip);
                Assert.Equal(status, resultStatus);
                Assert.Equal(price, resultPrice);
            }
        }
        public class PropertyStatusTest
        {
            [Theory]
            [InlineData("Active")]
            [InlineData("Inactive")]
            public void IsExpensive_Returns_CorrectValue(string expectedStatus)
            {
                var property = new Property
                {
                    PropertyStatus = expectedStatus
                };

                // Act
                var status = property.PropertyStatus;

                // Assert
                Assert.Equal(expectedStatus, status);
            }
        }


    }
}
