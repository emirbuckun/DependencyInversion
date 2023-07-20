namespace DependencyInversion
{
  internal class RepoService
  {
    private IRepository _repository;
    public RepoService(IRepository repository)
    {
      _repository = repository;
    }

    public void Save()
    {
      _repository.Create();
      _repository.Commit();
    }
  }
}