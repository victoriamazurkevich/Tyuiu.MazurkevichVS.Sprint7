using Tyuiu.MazurkevichVS.Sprint7.Project.V2.Lib;
namespace Tyuiu.MazurkevichVS.Sprint7.Project.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetDataFromFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.MazurkevichVS.Sprint7\Tyuiu.MazurkevichVS.Sprint7.Project.V2.Lib\ListOfDepartments.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
