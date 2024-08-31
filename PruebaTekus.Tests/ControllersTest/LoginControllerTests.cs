using Microsoft.AspNetCore.Mvc;
using Moq;
using PruebaTekus.Application.Dtos;
using PruebaTekus.Application.Interfaces;
using PruebaTekus.WebApi.Controllers;
using Xunit;

namespace PruebaTekus.Tests.ControllersTest
{
    public class LoginControllerTests
    {
        private readonly Mock<ILoginService> _mockLoginService;
        private readonly LoginController _controller;
        private const string ValidUsername = "PruebaTekus";
        private const string ValidPassword = "1234";
        private const string ValidToken = "12345ASDFJ123456";
        private const string InvalidPassword = "ErrorPass";
        public LoginControllerTests()
        {
            _mockLoginService = new Mock<ILoginService>();
            _controller = new LoginController(_mockLoginService.Object);
        }
        [Fact]
        public async Task Login_ReturnsOkResult_WithToken()
        {
            var userDto = new UserDto { user = ValidUsername, password = ValidPassword };
            _mockLoginService.Setup(servicio => servicio.Login(It.IsAny<UserDto>()))
            .ReturnsAsync(ValidToken);
            var result = await _controller.Login(userDto);
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, (okResult as OkObjectResult).StatusCode);
            var returnValue = okResult.Value;
            var tokenProperty = returnValue.GetType().GetProperty("Token");
            Assert.NotNull(tokenProperty);
            var tokenValue = tokenProperty.GetValue(returnValue, null);
            Assert.NotNull(tokenValue);
            Assert.Equal(ValidToken, tokenValue);
        }
        [Fact]
        public async Task Login_ReturnsUnauthorized_WhenInvalidCredentials()
        {
            var userDto = new UserDto { user = ValidUsername, password = InvalidPassword };
            _mockLoginService.Setup(service => service.Login(userDto))
            .ReturnsAsync((string)null);
            var result = await _controller.Login(userDto);
            var unauthorizedResult = Assert.IsType<UnauthorizedResult>(result);
            Assert.Equal(401, (unauthorizedResult as UnauthorizedResult).StatusCode);
        }
    }
}