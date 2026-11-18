# Buổi 02 – Danh sách

Chương trình C# dạng console, gom các bài tập thực hành về **mảng, ma trận, danh sách liên kết** và **xử lý dữ liệu bằng cấu trúc dữ liệu** (Chương 4) vào một menu duy nhất.

## Yêu cầu môi trường

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) trở lên (dự án dùng `net10.0`)
- Hệ điều hành: Windows / Linux / macOS

## Cấu trúc thư mục

```
Buoi02_DanhSach/
└── BTTH2/
    ├── Buoi02_DanhSach.csproj
    ├── Program.cs            # Menu chính, gọi Run() của từng bài
    ├── B1C4.cs ... B5C4.cs   # Bài tập áp dụng
    └── B7C4.cs ... B18C4.cs  # Bài tập tự thực hành
```

Quy ước tên file: `B<số bài>C<số chương>.cs`, ví dụ `B2C4.cs` = Bài 2 Chương 4.

## Lệnh chạy

```bash
cd Buoi02_DanhSach/BTTH2

# Biên dịch + chạy
dotnet run

# Hoặc build bản Release rồi chạy
dotnet build -c Release
dotnet bin/Release/net10.0/Buoi02_DanhSach.dll
```

Chương trình hiện menu, nhập số thứ tự bài (`1`–`17`) để chạy, `0` để thoát. Sau mỗi bài, nhấn Enter để quay lại menu. Các bài dạng menu con (Bài 2, 16, 17, 18) nhập `0` để quay lại menu chính.

## Danh sách bài đã làm

| Menu | File | Bài | Nội dung |
|:---:|---|---|---|
| 1 | `B1C4.cs` | Bài 1 – Chương 4 | Mảng số nguyên, chèn phần tử x vào vị trí k |
| 2 | `B2C4.cs` | Bài 2 – Chương 4 | Quản lý nhân viên (`struct`): tổng thực lĩnh, lương thấp nhất, đếm thưởng, sắp xếp (phòng ban tăng dần, mã NV giảm dần), tăng lương 5% |
| 3 | `B3C4.cs` | Bài 3 – Chương 4 | Ma trận vuông: tổng, dương nhỏ nhất, tổng đường chéo phụ, đường chéo chính tăng dần |
| 4 | `B4C4.cs` | Bài 4 – Chương 4 | DSLK đơn: đếm x, min dương, xóa x |
| 5 | `B5C4.cs` | Bài 5 – Chương 4 | DSLK đơn: max, tổng, đếm nguyên tố, đếm âm/dương/0... |
| 6 | `B7C4.cs` | Bài 7 – Chương 4 | Quản lý nhiệt độ: ngày nóng nhất, lạnh nhất, trung bình |
| 7 | `B8C4.cs` | Bài 8 – Chương 4 | Thống kê tần suất từ trong chuỗi (`Dictionary`) |
| 8 | `B9C4.cs` | Bài 9 – Chương 4 | Xử lý số nguyên: lọc số nguyên tố, số chẵn, số hoàn hảo (`List<int>`) |
| 9 | `B10C4.cs` | Bài 10 – Chương 4 | Duyệt ma trận theo thứ tự xoắn ốc |
| 10 | `B11C4.cs` | Bài 11 – Chương 4 | Ma trận đặc biệt: ma trận đơn vị, ma trận đối xứng |
| 11 | `B12C4.cs` | Bài 12 – Chương 4 | Game Minesweeper: đặt mìn ngẫu nhiên, đếm mìn xung quanh |
| 12 | `B13C4.cs` | Bài 13 – Chương 4 | Đảo ngược DSLK đơn |
| 13 | `B14C4.cs` | Bài 14 – Chương 4 | Gộp hai DSLK đã sắp xếp tăng dần |
| 14 | `B15C4.cs` | Bài 15 – Chương 4 | Phát hiện chu trình trong DSLK (rùa và thỏ) |
| 15 | `B16C4.cs` | Bài 16 – Chương 4 | Lịch sử duyệt web: Back / Forward (DSLK đôi) |
| 16 | `B17C4.cs` | Bài 17 – Chương 4 | Playlist nhạc: thêm, xóa, Next / Previous (DSLK đôi) |
| 17 | `B18C4.cs` | Bài 18 – Chương 4 | Hệ thống đặt hàng: chuyển trạng thái đơn hàng tới / lui |

## Kết quả chạy

Kết quả dưới đây được chạy thật trên Linux. Bài dùng số ngẫu nhiên (menu 11 – Minesweeper) sẽ **khác nhau giữa các lần chạy**.

### 1. Bài 1 – Chương 4: Chèn phần tử vào mảng

Nhập `n = 5`, dãy `1 2 3 4 5`, `x = 99`, `k = 2`:

```
Dãy vừa nhập:
1 2 3 4 5 
Dãy sau khi chèn:
1 2 99 3 4 5 
```

### 2. Bài 2 – Chương 4: Quản lý nhân viên

Nhập 3 nhân viên:

| Mã NV | Họ tên | Năm sinh | Phòng ban | Lương CB | Thưởng |
|---|---|:---:|---|---:|---:|
| NV01 | Nguyen Van An | 1995 | KeToan | 8000000 | 1500000 |
| NV02 | Tran Thi Binh | 1998 | KinhDoanh | 7000000 | 1200000 |
| NV03 | Le Van Cuong | 1990 | KeToan | 9000000 | 800000 |

Chọn `1`:

```
Tổng thực lĩnh: 27500000
```

Chọn `2` (lương cơ bản thấp nhất):

```
NV02    Tran Thi Binh         1998      KinhDoanh     7000000     1200000   8200000     
```

Chọn `3` (thưởng ≥ 1200000):

```
Số nhân viên: 2
```

Chọn `4` (phòng ban tăng dần, nếu trùng thì mã NV giảm dần):

```
Mã NV   Họ tên                Năm sinh  Phòng ban     Lương CB    Thưởng    Thực lĩnh   
NV03    Le Van Cuong          1990      KeToan        9000000     800000    9800000     
NV01    Nguyen Van An         1995      KeToan        8000000     1500000   9500000     
NV02    Tran Thi Binh         1998      KinhDoanh     7000000     1200000   8200000     
```

Chọn `5` (tăng lương cơ bản 5%):

```
Mã NV   Họ tên                Năm sinh  Phòng ban     Lương CB    Thưởng    Thực lĩnh   
NV01    Nguyen Van An         1995      KeToan        8400000     1500000   9900000     
NV02    Tran Thi Binh         1998      KinhDoanh     7350000     1200000   8550000     
NV03    Le Van Cuong          1990      KeToan        9450000     800000    10250000    
```

### 3. Bài 3 – Chương 4: Ma trận vuông

Nhập `n = 3`, các phần tử `1` đến `9`:

```
Ma trận:
1	2	3	
4	5	6	
7	8	9	
a. Tổng tất cả phần tử: 45
b. Giá trị dương nhỏ nhất: 1
c. Tổng đường chéo phụ: 15
d. Đường chéo chính tăng dần
```

### 4. Bài 4 – Chương 4: DSLK đơn (đếm, min dương, xóa x)

Nhập danh sách `3 -2 5 3 8 3`, đếm `x = 3`, xóa `x = 3`:

```
3 -2 5 3 8 3 
a. Số phần tử bằng 3: 3
b. Phần tử dương nhỏ nhất: 3
c. Danh sách sau khi xóa:
-2 5 3 8 3 
```

> `XoaX` chỉ xóa phần tử đầu tiên bằng x tìm thấy.

### 5. Bài 5 – Chương 4: DSLK đơn (max, tổng, nguyên tố...)

Nhập danh sách `4 -3 7 0 11 4`, `x = 4`:

```
a. Phần tử lớn nhất: 11
b. Tổng các phần tử: 23
c. Số lượng số nguyên tố: 2
d. Số âm: 1, số dương: 4, số 0: 1
e. Số phần tử bằng 4: 2
f. Phần tử dương nhỏ nhất: 4
```

### 6. Bài 7 – Chương 4: Quản lý nhiệt độ

Nhập `n = 5`, nhiệt độ `30.5`, `28`, `33,2`, `25`, `31` (chấp nhận cả dấu `,` và `.`):

```
Ngày nóng nhất: ngày 3 (33.2)
Ngày lạnh nhất: ngày 4 (25)
Nhiệt độ trung bình: 29.54
```

### 7. Bài 8 – Chương 4: Thống kê từ

Nhập `Xin chao, xin chao the gioi! The gioi dep` (không phân biệt hoa thường, bỏ dấu câu; sắp xếp theo tần suất giảm dần, bằng nhau thì theo thứ tự chữ cái):

```
chao: 2
gioi: 2
the: 2
xin: 2
dep: 1
```

### 8. Bài 9 – Chương 4: Xử lý số nguyên

Nhập `7` số: `6 28 7 12 496 9 2`:

```
Số nguyên tố (2): 7 2 
Số chẵn (5): 6 28 12 496 2 
Số hoàn hảo (3): 6 28 496 
```

### 9. Bài 10 – Chương 4: Ma trận xoắn ốc

Nhập ma trận 3 × 4 với các phần tử `1` đến `12`:

```
Ma trận:
1	2	3	4	
5	6	7	8	
9	10	11	12	
Thứ tự xoắn ốc: 1 2 3 4 8 12 11 10 9 5 6 7 
```

### 10. Bài 11 – Chương 4: Ma trận đặc biệt

Nhập ma trận đơn vị cấp 3 (`1 0 0 / 0 1 0 / 0 0 1`):

```
Là ma trận đơn vị
Là ma trận đối xứng
```

### 11. Bài 12 – Chương 4: Minesweeper

Nhập `m = 5`, `n = 5`, số mìn `5` (vị trí mìn ngẫu nhiên, `*` là mìn, số là mìn xung quanh):

```
0 0 0 1 * 
0 1 1 3 2 
0 2 * 3 * 
0 2 * 4 2 
0 1 1 2 * 
```

### 12. Bài 13 – Chương 4: Đảo ngược danh sách

Nhập danh sách `1 3 5 7 9`:

```
Danh sách ban đầu:
1 3 5 7 9 
Danh sách sau khi đảo ngược:
9 7 5 3 1 
```

### 13. Bài 14 – Chương 4: Gộp danh sách

Nhập danh sách 1: `1 4 7 10`, danh sách 2: `2 6 9`:

```
Danh sách sau khi gộp:
1 2 4 6 7 9 10 
```

### 14. Bài 15 – Chương 4: Phát hiện chu trình

Nhập danh sách `1 2 3 4`, nút cuối nối về nút có chỉ số `1`:

```
Danh sách có chu trình
```

Nhập `-1` thì không tạo chu trình và chương trình in `Danh sách không có chu trình`.

### 15. Bài 16 – Chương 4: Lịch sử duyệt web

Truy cập `vnexpress.net`, `youtube.com`, rồi Back ba lần, sau đó Forward một lần (mỗi dòng là trang hiện tại sau mỗi thao tác):

```
Trang hiện tại: trang-chu
Trang hiện tại: vnexpress.net
Trang hiện tại: youtube.com
Trang hiện tại: vnexpress.net
Trang hiện tại: trang-chu
Không thể quay lại
Trang hiện tại: trang-chu
Trang hiện tại: vnexpress.net
```

### 16. Bài 17 – Chương 4: Playlist nhạc

Thêm `Bai A`, `Bai B`, `Bai C`; Next hai lần, Next lần nữa (đã ở cuối), Previous, rồi xóa `Bai B` (`>` đánh dấu bài đang phát):

```
--- Playlist ---
> 1. Bai A
  2. Bai B
  3. Bai C

  1. Bai A
  2. Bai B
> 3. Bai C

Không có bài tiếp theo

  1. Bai A
> 2. Bai B
  3. Bai C

  1. Bai A
> 2. Bai C
```

> Khi xóa bài đang phát, con trỏ tự chuyển sang bài kế tiếp (hoặc bài trước nếu đó là bài cuối).

### 17. Bài 18 – Chương 4: Hệ thống đặt hàng

Thêm đơn `101 – An`, `102 – Binh`; chuyển tiếp đơn 101 ba lần, quay lại đơn 102:

```
Đơn 101 - An - Chờ xử lý
Đơn 102 - Binh - Chờ xử lý

Đơn 101 - An - Đang giao
Đơn 102 - Binh - Chờ xử lý

Đơn 101 - An - Hoàn thành
Đơn 102 - Binh - Chờ xử lý

Đơn hàng đã hoàn thành
Đơn hàng đang ở trạng thái đầu
```

> Trạng thái đơn hàng là DSLK đôi: `Chờ xử lý ⇄ Đang giao ⇄ Hoàn thành`.

## Ghi chú

- Dữ liệu nhập không phải số sẽ bị `Program.cs` bắt (`FormatException`), in `Dữ liệu nhập không đúng định dạng` rồi quay lại menu chính.
- Các bài có kiểm tra điều kiện đầu vào và báo lỗi nếu nhập sai: vị trí `k` hợp lệ (Bài 1), `0 <= n < 100` (Bài 3), số mìn từ 0 đến `m × n` (Bài 12); Bài 5 báo `Danh sách rỗng` nếu không nhập phần tử nào.
- Bài 4, 5 dùng lớp `Nut` (`info`, `link`); Bài 13, 14, 15 dùng lớp `Node` (`data`, `next`); mỗi bài tự khai báo lớp nút riêng bên trong file của mình.
- Tất cả bài nằm chung namespace `Buoi02_DanhSach`, mỗi bài là một lớp `static` có phương thức `Run()` để `Program.cs` gọi.
