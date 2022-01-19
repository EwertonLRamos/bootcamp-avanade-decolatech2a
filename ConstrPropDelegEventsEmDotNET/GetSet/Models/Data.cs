namespace GetSet.Models
{
    public class Data
    {
        private bool mesValido;
        private int mes
        {
            get
            {
                return this.mes;
            }
            set
            {
                if(value > 0 && value < 13)
                {
                    mes = value;
                    mesValido = true;
                }
            }
        }

        public void ApresentarMes()
        {
            if(mesValido)
                Console.WriteLine(mes);
            else
                Console.WriteLine("Mês invalido");
        }

    }
}