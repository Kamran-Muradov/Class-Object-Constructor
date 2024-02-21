
namespace Class_Object_Constructor
{
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public string phone = "123132434434";

        public string GetFullName()
        {
            return name + " " + surname;
        }

        public string GetFullDatas()
        {
            string fullData = $"Name: {name}, Surname: {surname}, Age: {age}, Address: {address}, Phone: {phone}";
            return fullData;
        }

       
    }
}
