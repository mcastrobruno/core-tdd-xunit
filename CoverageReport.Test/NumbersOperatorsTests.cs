using System;
using CoverageReport.Domain;
using Xunit;

namespace CoverageReport.Test
{
    public class NumbersOperatorsTests
    {
        private readonly CoverageReport.Domain.NumbersOperator _sut;


        public NumbersOperatorsTests()
        {
            _sut = new CoverageReport.Domain.NumbersOperator();
        }

        [Fact]
        public void Deve_Multiplicar_Quando_ambos_os_numeros_forem_menores_que_10()
        {
            //arrange
            double num1 = 4;
            double num2 = 3;

            //act
            //Executa a operação
            double result = _sut.ExecuteOperation(num1, num2);

            //assert
            //Verifica se o resultado está correto
            Assert.Equal(12, result);

        }

        [Fact]
        public void Deve_Multiplicar_Quando_ambos_os_numeros_forem_menores_que_10_com_a_5_e_b_6()
        {
            //arrange
            double num1 = 5;
            double num2 = 6;

            //act
            //Executa a operação
            double result = _sut.ExecuteOperation(num1, num2);

            //assert
            //Verifica se o resultado está correto
            Assert.Equal(30, result);

        }
    }
}
