
namespace desafio_mvc.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoriaRepository CategoriaRepository { get; }
        IMedidaRepository MedidaRepository { get; }
        IIngredienteRepository IngredienteRepository { get; }
        IReceitaRepository ReceitaRepository { get; }
        IReceitaIngredienteRepository ReceitaIngredienteRepository { get; }
        ILogginRepository LogginRepository { get; }
        void Commit();
    }
}