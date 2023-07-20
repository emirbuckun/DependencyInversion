namespace DependencyInversion
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      EFRepository eFRepository = new EFRepository();
      DapperRepo dapperRepo = new DapperRepo();

      RepoService repoService = new RepoService(eFRepository);
      RepoService repoService2 = new RepoService(dapperRepo);

      repoService.Save(); // Uses EFRepository
      repoService2.Save(); // Uses DapperRepository
    }
  }
}