using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalcularMedia0001
{
    public class ClasseTesteMedia0001
    {
        [Fact]
        public void CalcularMedia_QuatroNotas_DeveRetornarMediaCorreta()
        {
            int nota1 = 8;
            int nota2 = 7;
            int nota3 = 9;
            int nota4 = 10;
            double mediaEsperada = 8.5;

            double mediaCalculada = CalcularMedia0001.CalcularMedia(nota1, nota2, nota3, nota4);

            Assert.Equal(mediaEsperada, mediaCalculada, 0.01);
        }

        [Fact]
        public void CalcularMedia_QuatroNotas_DeveIndicarAprovacaoSeMediaMaiorOuIgual7()
        {
            int nota1 = 8;
            int nota2 = 7;
            int nota3 = 9;
            int nota4 = 10;

            string resultado = CalcularMedia0001.CalcularMediaComSituacao(nota1, nota2, nota3, nota4);

            Assert.Contains("Aluno aprovado!", resultado);
        }

        [Fact]
        public void CalcularMedia_QuatroNotas_DeveIndicarRecuperacaoSeMediaMenorQue7()
        {
            int nota1 = 6;
            int nota2 = 5;
            int nota3 = 9;
            int nota4 = 10;

            string resultado = CalcularMedia0001.CalcularMediaComSituacao(nota1, nota2, nota3, nota4);

            Assert.Contains("O aluno está em recuperação.", resultado);
        }

        [Fact]
        public async Task CalcularMedia_UmaNotaInvalida_DeveRetornarExcecao()
        {
            int nota1 = 8;
            int nota2 = 7;
            int nota3 = 9;
            string notaInvalidaTexto = "texto invalido";

            _ = await Assert.ThrowsAsync<ArgumentException>(() => CalcularMedia0001.CalcularMedia(nota1, nota2, nota3, notaInvalidaTexto));
        }
    }
}
