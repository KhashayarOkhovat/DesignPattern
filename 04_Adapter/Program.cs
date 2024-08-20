#region Object Adapter
//using _04_Adapter.ObjectAdapet;

//Target target = new Adapter();
//target.Operation();
//Console.ReadKey();
#endregion

#region Class Adapter
using _04_Adapter.ClassAdapter;

ITarget target = new Adapter();
target.Operation();
#endregion