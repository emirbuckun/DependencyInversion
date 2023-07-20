namespace DependencyInversion
{
  internal interface IRepository
  {
    void Create();
    void Update();
    void Delete();
    void Query();
    void Commit();
  }
}