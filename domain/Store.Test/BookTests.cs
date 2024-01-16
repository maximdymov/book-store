namespace Store.Test
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithBlankString_ReturnFalse()
        {
            bool actual = Book.IsIsbn("     ");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 1234");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 12345-12345");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn13_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 12345-12345 123");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_ReturnTrue()
        {
            bool actual = Book.IsIsbn("xxx IsBn 12345-12345 bgfgbf");

            Assert.False(actual);
        }
    }
}
