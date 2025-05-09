using GerenciamentoZoologico.Controllers;
using GerenciamentoZoologico.Models;
using GerenciamentoZoologico.Repositories.Interfaces;
using Moq;

namespace CuidadosTests
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
            var cuidados = new Cuidados
            {
                CuidadoId = 1,
                NomeCuidado = "teste",
                Descricao = "descricao",
                Frequencia = "semanal",
            };

            int expectedId = 1;
            var request = new Cuidados()
            {
                CuidadoId = cuidados.CuidadoId,
                NomeCuidado = cuidados.NomeCuidado,
                Descricao = cuidados.Descricao,
                Frequencia = cuidados.Frequencia,
            };
            var fakeRepo = new Mock<ICuidadosRepository>();
            fakeRepo.Setup(x => x.AdicionarCuidados(It.IsAny<Cuidados>())).ReturnsAsync(cuidados);

            var cuidadosTests = new CuidadosController(fakeRepo.Object);
            var res = await cuidadosTests.AdicionarCuidados(request);

            Assert.IsNotNull(request);
            
            Assert.AreEqual(request.CuidadoId, expectedId);
            Assert.AreEqual(request.NomeCuidado, cuidados.NomeCuidado);
            Assert.AreEqual(request.Descricao, cuidados.Descricao);
            Assert.AreEqual(request.Frequencia, cuidados.Frequencia);

        }

        [Test]
        public async Task ShouldFindData()
        {
            var fakeRepo = new Mock<ICuidadosRepository>();
            var cuidados = new Cuidados()
            {
                CuidadoId = 1,
                NomeCuidado = "teste",
                Descricao = "descricao",
                Frequencia = "semanal"
            };
            fakeRepo.Setup(x => x.ObterCuidadolById(333)).Returns(Task.FromResult((Cuidados?)cuidados));//O ? quer dizer que pode ser nulo.
            var cuidadosTests = new CuidadosController(fakeRepo.Object);
            var res = await cuidadosTests.ObterCuidadoById(2);
            Assert.IsNotNull(res);


            Assert.AreEqual(cuidados.CuidadoId, 1);
            Assert.AreEqual(cuidados.NomeCuidado, "teste");
            Assert.AreEqual(cuidados.Descricao, "descricao");
            Assert.AreEqual(cuidados.Frequencia, "semanal");
        }

        [Test]
        public async Task ShouldUpdateData()
        {
            var fakeRepo = new Mock<ICuidadosRepository>();
            var cuidados = new Cuidados()
            {
                CuidadoId = 1,
                NomeCuidado = "teste",
                Descricao = "descricao",
                Frequencia = "semanal",
            };

            fakeRepo.Setup(x => x.AtualizarCuidado(cuidados, 1)).Returns(Task.FromResult((Cuidados?)cuidados));//O ? quer dizer que pode ser nulo.
            var cuidadosTests = new CuidadosController(fakeRepo.Object);
            var res = await cuidadosTests.AtualizarCuidado(cuidados, 1);
            Assert.IsNotNull(res);


            Assert.AreEqual(cuidados.CuidadoId, 1);
            Assert.AreEqual(cuidados.NomeCuidado, "teste");
            Assert.AreEqual(cuidados.Descricao, "descricao");
            Assert.AreEqual(cuidados.Frequencia, "semanal");
        }

        [Test]
        public async Task ShouldDeleteData()
        {
            var fakeRepo = new Mock<ICuidadosRepository>();
            var cuidados = new Cuidados()
            {
                CuidadoId = 1,
                NomeCuidado = "teste",
                Descricao = "descricao",
                Frequencia = "semanal",
            };
            fakeRepo.Setup(x => x.DeletarCuidado(1)).ReturnsAsync(true);
            var cuidadosTests = new CuidadosController(fakeRepo.Object);
            var res = await cuidadosTests.DeletarCuidado(1);
            Assert.IsNotNull(res);

        }


    }
}