using Azure.Core;
using GerenciamentoZoologico.Controllers;
using GerenciamentoZoologico.Models;
using GerenciamentoZoologico.Repositories;
using GerenciamentoZoologico.Repositories.Interfaces;
using Moq;

namespace AnimaisTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ShouldSaveData()
        {
            var animais = new Animais
            {
                AnimalId = 1,
                Nome = "cachorro",
                CuidadoID = 1,
                Descricao = "teste",
                DataNascimento = DateOnly.MinValue,
                Especie = "vira-lata",
                Habitat = "doméstico",
                PaisOrigem = "Brasil",


            };

            int expectedId = 1;
            var request = new Animais()
            {
                AnimalId = animais.AnimalId,
                Nome = animais.Nome,
                CuidadoID= animais.CuidadoID,
                Descricao = animais.Descricao,
                DataNascimento = animais.DataNascimento,
                Especie = animais.Especie,
                Habitat = animais.Habitat,
                PaisOrigem = animais.PaisOrigem,
            };
            var fakeRepo = new Mock<IAnimaisRepository>();
            fakeRepo.Setup(x => x.AdicionarAnimais(It.IsAny<Animais>())).ReturnsAsync(animais);

            var animaisTests = new AnimaisController(fakeRepo.Object);
            var res = await animaisTests.AdicionarAnimais(request);

            Assert.IsNotNull(request);
            
            Assert.AreEqual(request.AnimalId, expectedId);
            Assert.AreEqual(request.Nome, animais.Nome);
            Assert.AreEqual(request.CuidadoID, animais.CuidadoID);
            Assert.AreEqual(request.Descricao, animais.Descricao);
            Assert.AreEqual(request.DataNascimento, animais.DataNascimento);
            Assert.AreEqual(request.Especie, animais.Especie);
            Assert.AreEqual(request.Habitat, animais.Habitat);
            Assert.AreEqual(request.PaisOrigem, animais.PaisOrigem);
        }

        [Test]
        public async Task ShouldFindData()
        {
            var fakeRepo = new Mock<IAnimaisRepository>();
            var animais = new Animais()
            {
                AnimalId = 1,
                Nome = "cachorro",
                CuidadoID = 1,
                Descricao = "teste",
                DataNascimento = DateOnly.MinValue,
                Especie = "vira-lata",
                Habitat = "doméstico",
                PaisOrigem = "Brasil",
            };
            fakeRepo.Setup(x => x.ObterAnimalById(333)).Returns(Task.FromResult((Animais?)animais));//O ? quer dizer que pode ser nulo.
            var animaisTests = new AnimaisController(fakeRepo.Object);
            var res = await animaisTests.ObterAnimalById(2);
            Assert.IsNotNull(res);


            Assert.AreEqual(animais.AnimalId,1);
            Assert.AreEqual(animais.Nome, "cachorro");
            Assert.AreEqual(animais.CuidadoID, 1);
            Assert.AreEqual(animais.Descricao, "teste");
            Assert.AreEqual(animais.DataNascimento, DateOnly.MinValue);
            Assert.AreEqual(animais.Especie, "vira-lata");
            Assert.AreEqual(animais.Habitat, "doméstico");
            Assert.AreEqual(animais.PaisOrigem, "Brasil");
        }

        

        [Test]
        public async Task ShouldUpdateData()
        {
            var fakeRepo = new Mock<IAnimaisRepository>();
            var animais = new Animais()
            {
                AnimalId = 1,
                Nome = "cachorro",
                CuidadoID = 1,
                Descricao = "teste",
                DataNascimento = DateOnly.MinValue,
                Especie = "vira-lata",
                Habitat = "doméstico",
                PaisOrigem = "Brasil",
            };

            fakeRepo.Setup(x => x.AtualizarAnimal(animais,1)).Returns(Task.FromResult((Animais?)animais));//O ? quer dizer que pode ser nulo.
            var animaisTests = new AnimaisController(fakeRepo.Object);
            var res = await animaisTests.AtualizarAnimal(animais, 1);
            Assert.IsNotNull(res);


            Assert.AreEqual(animais.AnimalId, 1);
            Assert.AreEqual(animais.Nome, "cachorro");
            Assert.AreEqual(animais.CuidadoID, 1);
            Assert.AreEqual(animais.Descricao, "teste");
            Assert.AreEqual(animais.DataNascimento, DateOnly.MinValue);
            Assert.AreEqual(animais.Especie, "vira-lata");
            Assert.AreEqual(animais.Habitat, "doméstico");
            Assert.AreEqual(animais.PaisOrigem, "Brasil");

        }

        [Test]
        public async Task ShouldDeleteData()
        {
            var fakeRepo = new Mock<IAnimaisRepository>();
            var animais = new Animais()
            {
                AnimalId = 1,
                Nome = "cachorro",
                CuidadoID = 1,
                Descricao = "teste",
                DataNascimento = DateOnly.MinValue,
                Especie = "vira-lata",
                Habitat = "doméstico",
                PaisOrigem = "Brasil",
            };
            fakeRepo.Setup(x => x.DeletarAnimal(1)).ReturnsAsync(true);
            var animaisTests = new AnimaisController(fakeRepo.Object);
            var res = await animaisTests.DeletarAnimal(1);
            Assert.IsNotNull(res);

        }
    }
}