using System;
using System.Collections;

class HashTablesFirstRecurringCharacter {
  public void Run () {
     int[] array = new int[] {7, 2, 5, 1, 9, 3, 5, 1, 2, 4 };
    Console.WriteLine(FindFirstRecurringCharacter(array));    
  }

  static int FindFirstRecurringCharacter(int[] array)
  {
      int i = 0;
      Hashtable arrayTable = new Hashtable();
      while (i < array.Length)
      {
          if (!arrayTable.ContainsKey(array[i]))
          {
              arrayTable.Add(array[i], false);
              i++;
          }
          else
          {
              return array[i];
          }
      }
      return 0;
  }
}