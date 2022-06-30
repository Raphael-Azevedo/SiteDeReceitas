using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using desafio_mvc.Areas.Admin.Controllers;
using desafio_mvc.Context;
using desafio_mvc.DTO.Mappings;
using desafio_mvc.Repository;
using desafio_mvc.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace desafio_mvcTeste
{
    public class AdminUnitTestController
    {
        private IUnitOfWork repository;
        public static DbContextOptions<ApplicationDbContext> dbContextOptions { get; }

        public static string connectionString = "server=localhost; port=3306; database=receitadb; user=root;password=root";

        static AdminUnitTestController()
        {
            dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .Options;
        }
        public AdminUnitTestController()
        {
            var context = new ApplicationDbContext(dbContextOptions);

            repository = new UnitOfWork(context);
        }
        [Fact]
        public void IndexReturnViewResult()
        {
            //Arrange
            var controller = new AdminController(repository);

            //Act
            var data = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(data);
        }

    }
}