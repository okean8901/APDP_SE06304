using Xunit;
using CalculatorApp;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Fact] //đánh dấu hàm test
        public void Add_ReturnsSumOfTwoNumbers() //test hàm tính năng tổng trong calculator
        {
            // khởi tạo đối tượng calculator
            Calculator calculator = new Calculator();

            //gọi hàm add với tham số 1 và 2
            var result = calculator.Add(1, 2); // khai báo là var để c# tự nhận biết kiểu dữ liệu

            Assert.Equal(3, result); //kết quả mong đợi là 3
            
        }

        [Fact] 
        public void Subtract_ReturnsDifferenceOfTwoNumbers() //test hàm tính năng trừ trong calculator
        {
            Calculator calculator = new Calculator();

            var result = calculator.Subtract(5, 2);

            Assert.Equal(3, result);
        }
        
        [Fact]
        public void Multiply_ReturnsProductOfTwoNumbers() //test hàm tính năng nhân trong calculator
        {
            Calculator calculator = new Calculator();

            var result = calculator.Multiply(5, 2);

            Assert.Equal(10, result);
        }
        [Fact]
        public void Divide_ReturnsQuotientOfTwoNumbers() //test hàm tính năng chia trong calculator
        {
            Calculator calculator = new Calculator();

            var result = calculator.Divide(10, 2); // truyền vào b = 0 để test exception
            //kiểm tra xem có ngoại lệ được ném ra không 
            Assert.Equal(5, result);
        }
        [Fact]
        public void Modulus_ReturnsRemainderOfTwoNumbers() //test hàm tính năng chia lấy dư trong calculator
        {
            Calculator calculator = new Calculator();

            var result = calculator.Modulus(10, 3);

            Assert.Equal(1, result);
        }
        

        //TEST VỚI NHIỀU DỮ LIỆU ĐẦU VÀO KHÁC NHAU 
        [Theory] //đánh dấu hàm test với nhiều dữ liệu đầu vào khác nhau 
        [InlineData(1, 2, 3)] //dữ liệu đầu vào, kết quả mong đợi là 3 (a = 1, b = 2, expected = 3)
        [InlineData(2, 3, 5)] //dữ liệu đầu vào, kết quả mong đợi là 5 (a = 2, b = 3, expected = 5)
        [InlineData(3, 4, 7)] //dữ liệu đầu vào, kết quả mong đợi là 7 (a = 3, b = 4, expected = 7)
        [InlineData(4, 5, 9)] //dữ liệu đầu vào, kết quả mong đợi là 9 (a = 4, b = 5, expected = 9)
        public void Add_ReturnsSumOfTwoNumbers_WithTheory(int a, int b, int expected) //test hàm tính năng tổng trong calculator
        {
            // khởi tạo đối tượng calculator
            Calculator calculator = new Calculator();

            //gọi hàm add với tham số 1 và 2
            var result = calculator.Add(1, 2); // khai báo là var để c# tự nhận biết kiểu dữ liệu

            Assert.Equal(3, result); //kết quả mong đợi là 3

        }
    }
}