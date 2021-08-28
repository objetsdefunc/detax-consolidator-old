namespace Consolidator
{
   using System;
   using System.Diagnostics;
   using System.IO;
   using System.Linq;
   using System.Reflection;
   using System.Windows;
   using JPI;
   using JPI.Linq;

   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();

         var path = Path.Combine(
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
            "../../CSV/")
               .ToCharacters()
               .UnlessNull();

         var files = Portfolio.TransactionFilesFrom(new CSVFiles(new FolderPath(path)));

         // Next:
         // - Count unique transactions
         // - Oldest transaction date
         // - Newest transaction date
         var transactions =
            Portfolio.UniqueTransactionsFrom(files);

         var recordsMessage = $"Found {files.Flatten(f => f).Count()} transactions records in {files.Count} files.";
         var transactionsMessage = $"Found {transactions.Count()} unique transactions.";
         var seperator = new string(Enumerable.Repeat('-', recordsMessage.Length).ToArray());

         Debug.WriteLine(Environment.NewLine);
         Debug.WriteLine(seperator);
         Debug.WriteLine(recordsMessage);
         Debug.WriteLine(transactionsMessage);
         Debug.WriteLine(seperator);
         Debug.WriteLine(Environment.NewLine);
      }
   }
}
