using System;
using Xunit;
namespace Testing.DatabaseTests
{
    public interface CRUDTest
    {

        [Fact]
        void addTest();

        [Fact]
        void getTest();

        [Fact]
        void updateTest();

        [Fact]
        void deleteTest();



    }
}
