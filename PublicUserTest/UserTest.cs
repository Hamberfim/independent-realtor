namespace PublicUserTest
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
    }
}