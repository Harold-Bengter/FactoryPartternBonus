using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExerciseBonus;

public class MongoDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("I am reading from Mongo Database");
    }

    public void SaveData()
    {
        Console.WriteLine("You have saved your data to the Mongo Database");
    }
}
