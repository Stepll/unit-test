using System;
using System.IO;
using IIG.BinaryFlag;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestInit1_T()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(1, true);
            Assert.NotNull(Flag);

        }
        [Fact]
        public void TestInit2_T()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.NotNull(Flag);

        }
        [Fact]
        public void TestInit3_T()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(3, true);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit1_F()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(1, false);
            Assert.NotNull(Flag);

        }
        [Fact]
        public void TestInit2_F()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            Assert.NotNull(Flag);

        }
        [Fact]
        public void TestInit3_F()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(3, false);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit1_Default()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(1);
            Assert.NotNull(Flag);

        }
        [Fact]
        public void TestInit2_Default()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            Assert.NotNull(Flag);

        }
        [Fact]
        public void TestInit3_Default()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(3);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit17179868704_T()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, true);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit17179868705_T()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, true);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit17179868703_T()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868703, true);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit17179868704_F()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, false);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit17179868705_F()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, false);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit17179868703_F()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868703, false);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit17179868704_Default()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit17179868705_Default()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868705);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit17179868703_Default()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868703);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit40()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(40);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit5621_T()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(5621, true);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestInit888881_F()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(888881, false);
            Assert.NotNull(Flag);
        }

        [Fact]
        public void TestInit9183113()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(9183113);
            Assert.NotNull(Flag);

        }

        [Fact]
        public void TestGetFlagTrue()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);
            Assert.Equal(true, Flag.GetFlag());

        }


        [Fact]
        public void TestGetFlagFalse()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            Assert.Equal(false, Flag.GetFlag());

        }



        [Fact]
        public void TestSetFlag()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            Flag.SetFlag(0);
            Flag.SetFlag(1);
            Assert.Equal(true, Flag.GetFlag());

        }

        [Fact]
        public void TestSetFlag17179868704()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.SetFlag(17179868704);
            });

        }

        [Fact]
        public void TestSetFlag17179868705()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.SetFlag(17179868705);
            });

        }

        [Fact]
        public void TestSetFlag17179868703()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.SetFlag(17179868703);
            });

        }

        [Fact]
        public void TestSetFlag1()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.SetFlag(1);
            });

        }

        [Fact]
        public void TestSetFlag2()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.SetFlag(2);
            });

        }

        [Fact]
        public void TestSetFlag3()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.SetFlag(3);
            });

        }


        [Fact]
        public void TestResetFlag()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Flag.ResetFlag(1);
            Assert.Equal(false, Flag.GetFlag());


        }

        [Fact]
        public void TestResetFlag1()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.ResetFlag(1);
            });

        }

        [Fact]
        public void TestResetFlag2()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.ResetFlag(2);
            });

        }

        [Fact]
        public void TestResetFlag3()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.ResetFlag(3);
            });

        }

        [Fact]
        public void TestResetFlag17179868704()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.ResetFlag(17179868704);
            });

        }

        [Fact]
        public void TestResetFlag17179868705()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.ResetFlag(17179868705);
            });

        }

        [Fact]
        public void TestResetFlag17179868703()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(17179868704, true);
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => {
                Flag.ResetFlag(17179868703);
            });

        }

        [Fact]
        public void TestDispose()
        {
            IIG.BinaryFlag.MultipleBinaryFlag Flag = new IIG.BinaryFlag.MultipleBinaryFlag(2);

            Assert.Null(Flag);
        }

    }

}
