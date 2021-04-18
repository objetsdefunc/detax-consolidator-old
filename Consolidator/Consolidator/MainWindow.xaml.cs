namespace Consolidator
{
   using System.Diagnostics;
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

         // Next:
         // - CSV.TransactionsFrom(Files.In(folder))...
         // - Count unique transactions.
         var transactions = CSV.TransactionsFrom(
            FilePath.ThatExists("../../../../../CSV/fills.csv".ToText()));

         Debug.WriteLine($"Found {transactions.Count} transactions");
      }
   }
}
