using FactoryExerciseBonus;

Console.WriteLine("Which Database would you like to store your data in: List, SQL, Mongo");
var userInput = Console.ReadLine().ToLower();

IDataAccess databaseType = DataAccessFactrory.GetDataAccessType(userInput);
databaseType.LoadData();
databaseType.SaveData();
