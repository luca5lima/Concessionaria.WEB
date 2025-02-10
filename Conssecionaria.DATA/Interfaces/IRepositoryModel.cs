namespace Conssecionaria.DATA.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        List<T> SelectAll();

        T SelectPk(params object[] variavel);

        T Creat(T objeto);

        T Edit(T objeto);

        void Delete(T objeto);

        void Delete(params object[] variavel);

        void SaveChages();
    }
}