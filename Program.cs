using System.Data;
using Newtonsoft.Json;

class Table
{

   static void Main(string[] args)
    {
        DataTable studentInfo = new DataTable();

        studentInfo.Columns.Add("Name");
        studentInfo.Columns.Add("Age");
        studentInfo.Columns.Add("Course");
        studentInfo.Columns.Add("ID");

        Console.Out.WriteLine("Enter your information!");

        for(int i = 0; i < 5; i++)
        {
            DataRow row = studentInfo.NewRow();
            string data = Console.ReadLine();
            string[] value = data.Split(",");
            row["Name"] = value[0];
            row["Age"] = Convert.ToInt32(value[1]);
            row["Course"] = value[2];
            row["ID"] = Convert.ToInt32(value[3]);
            studentInfo.Rows.Add(row);
        }

        Console.WriteLine("\n\n DATA TABLE");
        foreach (DataRow row in studentInfo.Rows )
        {
            
            Console.Out.WriteLine(  row["Name"] + " " + row["Age"] + " " + row["Course"] + " " + row["ID"]);
        }

        var json = JsonConvert.SerializeObject(studentInfo, Formatting.Indented);
        Console.Out.WriteLine(json);
    }

}
