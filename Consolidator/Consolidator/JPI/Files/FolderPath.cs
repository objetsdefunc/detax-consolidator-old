namespace JPI
{
   public sealed class FolderPath
   {
      private readonly Characters path;

      public FolderPath(a<Characters> path) => this.path = path.NotNull;

      public string Primitive => path.Primitive;
   }
}
