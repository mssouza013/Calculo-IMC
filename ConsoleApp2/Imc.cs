
namespace ConsoleApp2
{
    class Imc
    {
        public double peso;
        public double altura;
        public double resultado;
        public string resposta;
        public Imc(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public string imc()
        {
            resultado = (double)peso / ((double)altura * (double)altura);

            //return resultado;

            if (resultado <= 20)

            {
                return resposta = "Abaixo do peso";
            }
            else if (resultado <= 25.00)
            {
                return resposta = "Peso normal";
            }
            else if (resultado <= 30.00)
            {
                return resposta = "Sobrepreso";
            }
            else if (resultado <= 35.00)
            {
                return resposta = "Obesidade grau I";
            }
            else if (resultado <= 40.00)
            {
                return resposta = "Obesidade grau II";
            }
            else if (resultado < 40.00)
            {
                return resposta = "Obesidade grau III";
            }

            return resposta;

        }





    }
}
