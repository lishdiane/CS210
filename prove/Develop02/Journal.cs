
using System.Xml.Linq;
using System.IO;


public class Journal
{   
    public List<Entry> _entries = new List<Entry>();
    

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        
    }

    public void SaveToFile(string file)
    {
        string fileName = file;
        
        using (StreamWriter writeText = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
               writeText.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            } 
        }
    }

    public void LoadFromFile(string file)
    {   _entries = [];
        string fileName = file;
        string [] lines = System.IO.File.ReadAllLines(fileName);


        foreach (string line in lines)
        {
            string [] parts = line.Split("|");

            Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2],
                };
        
            AddEntry(entry);
        }    
    }
}