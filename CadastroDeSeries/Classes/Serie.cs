namespace CadastroDeSeries
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "\n";

            if(this.Excluido)
                retorno += "Essa série foi excluida";
            else 
            {
                retorno += $"Gênero: {this.Genero}\n";
                retorno += $"Título: {this.Titulo}\n";
                retorno += $"Descricao: {this.Descricao}\n";
                retorno += $"Ano de inicio: {this.Ano}\n";
            }

            return retorno;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }
        public int RetornaId()
        {
            return this.Id;
        }
        public bool RetornaExclusao()
        {
            return this.Excluido;
        }
    }
}