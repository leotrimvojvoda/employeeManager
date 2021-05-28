using System;
using Xunit;
using Emanager01.Data;
using Emanager01.Models;

namespace Testing.DatabaseTests
{
    public class GeneralTest
    {


        [Fact]
        public void testGetDate()
        {

            Contract ct = new Contract();

            ct.ContractId = "LV01CT";

            

            

            Console.WriteLine("DATE: "+DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine("DATE: " + DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine("DATE: " + DateTime.Now.ToString("MM/dd/yyyy"));

            //ct.StartDate = dateTime.;

        }


    }
}
