using System;
using Xunit;
using Emanager01.Models;
using Emanager01.Data;
namespace Testing.DatabaseTests
{
    public class RemarksCrudTest : CRUDTest
    {
        public RemarksCrudTest()
        {
        }

        [Fact]
        public void addTest()
        {


            Remark remark = new Remark();

            remark.RemarkDate = new DateTime(2020, 01, 01);
            remark.Remark1 = "This is a good remark";
            remark.EmployeeId = 4;

            var emx = new RemarkQuerry();

            emx.add(remark);

        }

        [Fact]
        public void deleteTest()
        {
            var emx = new RemarkQuerry();

            emx.delete("3");
        }

        [Fact]
        public void getTest()
        {
            var emx = new RemarkQuerry();

            Remark remark = (Remark)emx.get("4");

            Console.WriteLine(remark.ToString());
        }

        [Fact(Skip = "Just")]
        public void updateTest()
        {
         
            Console.WriteLine("NOT SUPPORTED");
        }
    }
}
