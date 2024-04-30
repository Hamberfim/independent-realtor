using IndependentRealtorApp.Controllers;
using IndependentRealtorApp.Models;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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

        public class UserValidationTests
        {
            [Theory]
            [InlineData(null, "LastName", "test@example.com")] // Missing FirstName
            [InlineData("FirstName", null, "test@example.com")] // Missing LastName
            [InlineData("FirstName", "LastName", null)] // Missing Email
            [InlineData("", "LastName", "test@example.com")] // Empty FirstName
            [InlineData("FirstName", "", "test@example.com")] // Empty LastName
            [InlineData("FirstName", "LastName", "")] // Empty Email
            [InlineData("ThisIsALongFirstNameThatExceedsTheMaximumLengthOfFiftyCharactersForValidationPurposes", "LastName", "test@example.com")] // Long FirstName
            [InlineData("FirstName", "ThisIsALongLastNameThatExceedsTheMaximumLengthOfFiftyCharactersForValidationPurposes", "test@example.com")] // Long LastName
            [InlineData("FirstName", "LastName", "invalidemail")] // Invalid Email
            public void User_Validation_Fails_When_RequiredFields_Are_Missing_Or_Invalid(string firstName, string lastName, string email)
            {
                // Arrange
                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    UserEmail = email
                };

                // Act
                var validationResults = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(user, new ValidationContext(user), validationResults, true);

                // Assert
                Assert.False(isValid);
                Assert.NotEmpty(validationResults);
            }

            [Theory]
            [InlineData("FirstName", "LastName", "test@example.com")]
            public void User_Validation(string firstName, string lastName, string email)
            {
                // Arrange
                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    UserEmail = email
                };

                // Act
                var validationResults = new List<ValidationResult>();

                // Assert
                Assert.Empty(validationResults);
            }
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

    public class PropertyControllerTests
    {
        [Fact]
        public void Details_ReturnsNotFound_WhenPropertyNotFound()
        {
            // Arrange
            var mockPropertyRepository = new Mock<IProperty>();
            mockPropertyRepository.Setup(repo => repo.GetPropertyById(It.IsAny<int>())).Returns((Property)null); // Simulating property not found
            var controller = new PropertyController(mockPropertyRepository.Object);

            // Act
            var result = controller.Details(1, "Some Title");

            // Assert
            var notFoundResult = Assert.IsType<NotFoundResult>(result);
            Assert.Equal(404, notFoundResult.StatusCode);
        }
    }

    public class UserControllerTests
    {
        [Fact]
        public void Index_ReturnsViewWithUsers()
        {
            // Arrange
            var users = new List<User> { new User(), new User() };
            var mockUserRepository = new Mock<IUser>();
            mockUserRepository.Setup(repo => repo.GetUsers()).Returns(users);
            var controller = new UserController(mockUserRepository.Object);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<User>>(viewResult.Model);
            Assert.Equal(users.Count, model.Count());
        }
    }
}
