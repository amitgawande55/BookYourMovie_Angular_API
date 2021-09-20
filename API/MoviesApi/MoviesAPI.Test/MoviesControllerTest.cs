using Microsoft.AspNetCore.Mvc;
using MoviesApi.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MoviesAPI.Test
{
    public class MoviesControllerTest
    {
        private readonly MoviesController controller;
        public MoviesControllerTest()
        {
            controller = new MoviesController();
        }

        [Fact]
        public void Get_NotNull()
        {
            var result = controller.Get();
            var okResult = Assert.IsType<JsonResult>(result);
            Assert.NotNull(okResult);
        }
    }
}
