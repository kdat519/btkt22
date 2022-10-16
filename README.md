# Kiểm thử chức năng
## Đặc tả
Hàm tính ước chung lớn nhất của hai số nguyên a, b.
```
public static int GreatestCommonDivisor(int a, int b);
```
### Tham số
`a` giá trị thứ nhất, `a` là số nguyên trong khoảng [-2147483647, 2147483647]

`b` giá trị thứ hai, `b` là số nguyên trong khoảng [-2147483647, 2147483647]
### Trả về
Trả về ước chung lớn nhất của `a` và `b`.
Nếu cả `a` và `b` đều bằng không thì trả về không.

### Ngoại lệ
`ArgumentOutOfRangeException` 

Nếu `a` hoặc `b` bằng -2147483647

## Chạy kiểm thử
```
dotnet test
```
