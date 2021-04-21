namespace Consolidator
{
   using System.Diagnostics;
   using System.IO;
   using System.Linq;
   using System.Reflection;
   using System.Windows;
   using JPI;

   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();

         var folder = Path.Combine(
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
            "../../CSV/")
               .ToCharacters()
               .UnlessNull();

         // Next:
         // - Count unique transactions.
         var transactions =
            CSV.TransactionsFrom(
               Files.In(
                  FolderPath.ThatExists(folder)));

         Debug.WriteLine($"Found {transactions.Count()} transactions");
      }
   }
}
