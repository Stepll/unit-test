using System;
using Xunit;
using IIG.BinaryFlag;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private MultipleBinaryFlag _multipleBinaryFlag;
        public UnitTest1()
        {
            _multipleBinaryFlag = new MultipleBinaryFlag(30);
        }
        [Fact]
        public void Test1()
        {
            Assert.True(_multipleBinaryFlag.GetFlag());
        }
        [Fact]
        public void Test2()
        {
            _multipleBinaryFlag.ResetFlag(7);
            Assert.False(_multipleBinaryFlag.GetFlag());
            
            
        }
        [Fact]
        public void Test3()
        {
            _multipleBinaryFlag.SetFlag(7);
            Assert.True(_multipleBinaryFlag.GetFlag());
            
            
        }
        [Fact]
        public void Test4()
        {
            _multipleBinaryFlag.Dispose();
            Assert.Null(_multipleBinaryFlag);
            
            
        }
        [Fact]
        public void Test5()
        {
            _multipleBinaryFlag = new MultipleBinaryFlag(2, false);
            Assert.False(_multipleBinaryFlag.GetFlag());
        }
        [Fact]
        public void Test6()
        {
            _multipleBinaryFlag = new MultipleBinaryFlag(2, true);
            Assert.True(_multipleBinaryFlag.GetFlag());
        }
    }
}
