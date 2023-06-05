

class Journal
{
  List<string> entries;


  public Journal()
  {

  }
    
  public void DisplayJournalEntries()
  {
    
  }

  public void CreateJournalEntry()
  {

  }

  public void SaveToCSV()
  {
    List<string> records = new List<string>();
    foreach (Entry entry in entries)
    {
       records.Add(entry.getEntryAsCSV());
    }
    Console.WriteLine("Name of file to save?");
    string _fileName = Console.ReadLine();

    File.WriteAllLines(_fileName, records);
  }

  public void LoadFromCSV()
  {

  }
  
}