// See https://aka.ms/new-console-template for more information
namespace Program
{
    public class SimpleDataBase<T>
    {
        public List<T> storedData
        {
            get;
            set;
        }
        public List<DateTime> inputDates
        {
            get;
            set;
        }

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void TambahData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }
        public void PrintData()
        {
            for (int i = 0; i < storedData.Count; i++) 
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu {inputDates[i]}");
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            SimpleDataBase<int> sdb = new SimpleDataBase<int>();

            Console.WriteLine("NIM : 103082400044");
            sdb.TambahData(10);
            sdb.TambahData(30);
            sdb.TambahData(82);

            sdb.PrintData();

        }
    }
}

