using CalculadoraAPI.Controllers;
using Xunit;

namespace CalculadoraAPITests
{
    public class CalculadoraControllersTests
    {
        #region Fact/AAA

        [Fact(DisplayName = "[Fact] Deve retornar Valor Válido Para Operação de Soma, Método: ExecutaCalculo")]
        public void Fact_Deve_Retornar_Valor_Valido_Para_Operacao_Soma_Metodo_Executa_Calculo()
        {
            // Arrange
            float valorUm = 1;
            string operador = "+";
            float valorDois = 1;
            float resultadoEsperado = 2;

            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact(DisplayName = "[Fact] Deve retornar Valor Inválido Para Operação de Soma, Método: ExecutaCalculo")]
        public void Fact_Deve_Retornar_Valor_Invalido_Para_Operacao_Soma_Metodo_Executa_Calculo()
        {
            // Arrange
            float valorUm = 1;
            string operador = "+";
            float valorDois = 1;
            float resultadoEsperado = 5;

            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.NotEqual(resultado, resultadoEsperado);
        }

        #endregion

        #region Theory

        [Theory(DisplayName = "Deve retornar Valor Válido Para Operação de Soma, Método: ExecutaCalculo")]
        [InlineData(5, "+", 3, 8)]
        [InlineData(7.5, "+", 2.5, 10)]
        [InlineData(0, "+", 0, 0)]
        [InlineData(1, "+", 2, 3)]
        [InlineData(4.5, "+", 5.5, 10)]
        [InlineData(10, "+", 15, 25)]
        [InlineData(-3, "+", 7, 4)]
        [InlineData(20, "+", 30, 50)]
        public void Deve_Retornar_Valor_Valido_Para_Operacao_Soma_Metodo_Executa_Calculo(float valorUm, string operador, float valorDois, float resultadoEsperado)
        {
            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory(DisplayName = "Deve retornar Valor inválido Para Operação de Soma, Método: ExecutaCalculo")]
        [InlineData(1, "+", 2, 5)]
        [InlineData(4.5, "+", 5.5, 12)]
        [InlineData(10, "+", 15, 20)]
        [InlineData(-3, "+", 7, -4)]
        [InlineData(20, "+", 30, 40)]
        [InlineData(8, "+", 2, 15)]
        [InlineData(100, "+", 50, 120)]
        [InlineData(0, "+", 0, 1)]
        [InlineData(5.5, "+", 4.5, 15)]
        [InlineData(9, "+", 1, 11)]
        public void Deve_Retornar_Valor_Invalido_Para_Operacao_Soma_Metodo_Executa_Calculo(float valorUm, string operador, float valorDois, float resultadoEsperado)
        {
            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.NotEqual(resultado, resultadoEsperado);
        }

        [Theory(DisplayName = "Deve retornar Valor válido Para Operação de Subtracao, Método: ExecutaCalculo")]
        [InlineData(10, "-", 5, 5)]
        [InlineData(20, "-", 8, 12)]
        [InlineData(15.5, "-", 4.5, 11)]
        [InlineData(30, "-", 10, 20)]
        [InlineData(50, "-", 25, 25)]
        [InlineData(100, "-", 99, 1)]
        [InlineData(7, "-", 3, 4)]
        [InlineData(12.5, "-", 2.5, 10)]
        [InlineData(0, "-", 5, -5)]
        [InlineData(-10, "-", 5, -15)]
        public void Deve_Retornar_Valor_valido_Para_Operacao_Subtracao_Metodo_Executa_Calculo(float valorUm, string operador, float valorDois, float resultadoEsperado)
        {
            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory(DisplayName = "Deve retornar Valor inválido Para Operação de Subtracao, Método: ExecutaCalculo")]
        [InlineData(10, "-", 5, 3)]
        [InlineData(20, "-", 8, 5)]
        [InlineData(15.5, "-", 4.5, 5)]
        [InlineData(30, "-", 10, 25)]
        [InlineData(50, "-", 25, 40)]
        [InlineData(100, "-", 99, 5)]
        [InlineData(7, "-", 3, 10)]
        [InlineData(12.5, "-", 2.5, 15)]
        [InlineData(0, "-", 5, 0)]
        [InlineData(-10, "-", 5, -5)]
        public void Deve_Retornar_Valor_Invalido_Para_Operacao_Subtracao_Metodo_Executa_Calculo(float valorUm, string operador, float valorDois, float resultadoEsperado)
        {
            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.NotEqual(resultado, resultadoEsperado);
        }

        [Theory(DisplayName = "Deve retornar Valor Válido Para Operação de Multiplicacao, Método: ExecutaCalculo")]
        [InlineData(2, "*", 3, 6)]
        [InlineData(4, "*", 5, 20)]
        [InlineData(6.5, "*", 2, 13)]
        [InlineData(10, "*", 3, 30)]
        [InlineData(7, "*", 8, 56)]
        [InlineData(9, "*", 9, 81)]
        [InlineData(12, "*", 4, 48)]
        [InlineData(0, "*", 10, 0)]
        [InlineData(-3, "*", 6, -18)]
        [InlineData(5.5, "*", 2, 11)]

        public void Deve_Retornar_Valor_Valido_Para_Operacao_Multiplicacao_Metodo_Executa_Calculo(float valorUm, string operador, float valorDois, float resultadoEsperado)
        {
            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory(DisplayName = "Deve retornar Valor inválido Para Operação de Multiplicacao, Método: ExecutaCalculo")]
        [InlineData(2, "*", 3, 5)]
        [InlineData(4, "*", 5, 30)]
        [InlineData(6.5, "*", 2, 20)]
        [InlineData(10, "*", 3, 25)]
        [InlineData(7, "*", 8, 60)]
        [InlineData(9, "*", 9, 90)]
        [InlineData(12, "*", 4, 50)]
        [InlineData(0, "*", 10, 10)]
        [InlineData(-3, "*", 6, -10)]
        [InlineData(5.5, "*", 2, 12)]
        public void Deve_Retornar_Valor_Invalido_Para_Operacao_Multiplicacao_Metodo_Executa_Calculo(float valorUm, string operador, float valorDois, float resultadoEsperado)
        {
            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.NotEqual(resultado, resultadoEsperado);
        }

        [Theory(DisplayName = "Deve retornar Valor válido Para Operação de Divisao, Método: ExecutaCalculo")]
        [InlineData(10, "/", 2, 5)]
        [InlineData(20, "/", 5, 4)]
        [InlineData(15, "/", 3, 5)]
        [InlineData(30, "/", 6, 5)]
        [InlineData(50, "/", 10, 5)]
        [InlineData(100, "/", 25, 4)]
        [InlineData(9, "/", 3, 3)]
        [InlineData(12, "/", 4, 3)]
        [InlineData(8, "/", 2, 4)]
        [InlineData(-10, "/", 2, -5)]
        public void Deve_Retornar_Valor_valido_Para_Operacao_Divisao_Metodo_Executa_Calculo(float valorUm, string operador, float valorDois, float resultadoEsperado)
        {
            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory(DisplayName = "Deve retornar Valor inválido Para Operação de Divisao, Método: ExecutaCalculo")]
        [InlineData(10, "/", 2, 3)]
        [InlineData(20, "/", 5, 2)]
        [InlineData(15, "/", 3, 10)]
        [InlineData(30, "/", 6, 4)]
        [InlineData(50, "/", 10, 2)]
        [InlineData(100, "/", 25, 1)]
        [InlineData(9, "/", 3, 5)]
        [InlineData(12, "/", 4, 1)]
        [InlineData(8, "/", 2, 6)]
        [InlineData(-10, "/", 2, -3)]
        public void Deve_Retornar_Valor_Invalido_Para_Operacao_Divisao_Metodo_Executa_Calculo(float valorUm, string operador, float valorDois, float resultadoEsperado)
        {
            // Act
            var resultado = CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois);

            // Assert
            Assert.NotEqual(resultado, resultadoEsperado);
        }

        #endregion

        #region Exception

        [Fact(DisplayName = "Deve retornar Exception 'Operador inválido', Método: ExecutaCalculo")]
        public void Deve_Retornar_New_Exception_Operador_Invalido()
        {
            // Arrange
            float valorUm = 100;
            string operador = "!";
            float valorDois = 20;

            // Act
            var exception = Assert.Throws<System.Exception>(() => CalculadoraController.ExecutaCalculo(valorUm, operador, valorDois));

            // Assert
            Assert.Equal("Operador inválido", exception.Message);
        }

        #endregion
    }
}
