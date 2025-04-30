using SQLite;

namespace MauiAppMinhasCompras.Moldes
{
    public class Produto
    {
        string _descricao;
        double _qtn;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao {
            get => _descricao;
            set 
            {
                if (value == null) 
                {
                    throw new Exception("Por favor preencha a descrição");
                }
                _descricao = value;
            } 
        }
        public double Quantidade {
            get => _qtn;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Quantidade tem que ser maior que 0");
                }
                _qtn = value;
            }
             }
        public double Preco { get; set; }
        public double Total { get => Quantidade * Preco; }
    }
}
