using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using desafio_mvc.Areas.Admin.Controllers;
using desafio_mvc.Context;
using desafio_mvc.DTO.Mappings;
using desafio_mvc.Models;
using desafio_mvc.Repository;
using desafio_mvc.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace desafio_mvcTeste
{
    public class ReceitaUnitTestController
    {
        private IMapper mapper;
        private IUnitOfWork repository;
        public static DbContextOptions<ApplicationDbContext> dbContextOptions { get; }

        public static string connectionString = "server=localhost; port=3306; database=receitadb; user=root;password=root";

        static ReceitaUnitTestController()
        {
            dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .Options;
        }
        public ReceitaUnitTestController()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();

            var context = new ApplicationDbContext(dbContextOptions);

            repository = new UnitOfWork(context);
        }
        [Fact]
        public void GetByIdReturnViewResult()
        {
            //Arrange
            var controller = new AdminReceitasController(repository, mapper);
            Receita receita = new Receita();
            receita.ReceitaId = 1;

            //Act
            var data = controller.GetById(receita.ReceitaId);

            //Assert
            Assert.IsType<ViewResult>(data);
        }
        [Fact]
        public void GetByIdReturnNotFound()
        {
            //Arrange
            var controller = new AdminReceitasController(repository, mapper);
            Receita receita = new Receita();
            receita.ReceitaId = 1;

            //Act
            var data = controller.GetById(null);

            //Assert
            Assert.IsType<NotFoundResult>(data);
        }
        [Fact]
        public void GetIndexReturnViewResult()
        {
            //Arrange
            var controller = new AdminReceitasController(repository, mapper);

            //Act
            var data = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(data);
        }
    }
}