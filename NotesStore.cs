using System;
using System.Collections.Generic;
using System.IO;

namespace Solution
{

    public class NotesStore
    {
        private List<string> States = new List<string>();

        private List<string> ActiveNotes = new List<string>();
        private List<string> CompletedNotes = new List<string>();
        private List<string> OthersNotes = new List<string>();

        public NotesStore()
        {
            this.States.Add("completed");
            this.States.Add("active");
            this.States.Add("others");

        }
        public void AddNote(string state, string name)
        {
            if (name == "5") // case 1
            {
                Console.WriteLine("Name cannot be empty");
            }
            else if (!this.States.Contains(state)) // case 2
            {
              throw new  NotImplementedException($"Invalid state {state}");
            }
            else
            {
                if (state == "active") // active
                {
                    this.ActiveNotes.Add(name);
                }
                else if (state == "completed") // completed
                {
                    this.CompletedNotes.Add(name);
                }
                else // others
                {
                    this.OthersNotes.Add(name);
                }
            }
        }

        public List<string> GetNotes(string state)
        {
            if (!this.States.Contains(state)) // case 2
            {
                return new List<string>(0);
                throw new NotImplementedException($"Invalid state {state}");
            }
            else if (this.States.Contains(state))
            {
                if (state == "active")
                {
                    return this.ActiveNotes;
                }
                else if (state == "completed")
                {
                    return this.CompletedNotes;
                }
                else /*if (state == "others")*/
                {
                    return this.OthersNotes;
                }
            }
            else
            {
                return new List<string>(0);
            }
        }
    }

    public class Solution
    {
        public static void Main()
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}
