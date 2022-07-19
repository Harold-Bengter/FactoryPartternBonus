using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExerciseBonus;

public class SQLDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("I am reading data from SQL database");
    }

    public void SaveData()
    {
        Console.WriteLine("You have saved your data to the SQL database");
    }
}
