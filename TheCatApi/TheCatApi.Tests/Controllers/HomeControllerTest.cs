﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using TheCatApi;
using TheCatApi.Controllers;
using TheCatApi.ViewModels;

namespace TheCatApi.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = (ViewResult)controller.Index();

            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            var expectedVersion = mvcName.Version.Major + "." + mvcName.Version.Minor;
            var expectedRuntime = isMono ? "Mono" : ".NET";

            // Assert
            Assert.AreEqual(expectedVersion, result.ViewData["Version"]);
            Assert.AreEqual(expectedRuntime, result.ViewData["Runtime"]);
        }

        [Test]
        public void GetCategories()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = (ViewResult)controller.GetCategories();
            var viewModel = result.Model as CategoriesViewModel;

            // Assert
            Assert.IsNotEmpty(viewModel.Categories);
        }
    }
}
