namespace Consolidator
{
   using System;
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

         var path = Path.Combine(
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
            "../../CSV/")
               .ToCharacters()
               .UnlessNull();

         var files = new CSVFiles(new FolderPath(path));

         // Next:
         // - Count unique transactions
         // - Oldest transaction date
         // - Newest transaction date
         var transactions =
            Portfolio.TransactionsFrom(files);

         var message = $"Found {transactions.Count()} transactions in {files.Count} files";
         var seperator = new string(Enumerable.Repeat('-', message.Length).ToArray());

         Debug.WriteLine(Environment.NewLine);
         Debug.WriteLine(seperator);
         Debug.WriteLine(message);
         Debug.WriteLine(seperator);
         Debug.WriteLine(Environment.NewLine);
      }
   }
}
