# Buổi 03 – Stack và Queue

Chương trình C# dạng console, gom các bài tập thực hành về **ngăn xếp (Stack)**, **hàng đợi (Queue)** và **biểu thức trung tố / hậu tố** (Chương 5) vào một menu duy nhất, chia hai phần: **Bài tập áp dụng (1–6)** và **Bài tập tự thực hành (4–11)**, đánh số đúng như trong sách.

## Yêu cầu môi trường

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) trở lên (dự án dùng `net10.0`)
- Hệ điều hành: Windows / Linux / macOS

## Cấu trúc thư mục

```
Buoi03_Stack_Queue/
├── Buoi03_Stack_Queue.csproj
├── Program.cs            # Menu chính, gọi Run() của từng bài
├── AD1C5.cs ... AD6C5.cs # Bài tập áp dụng 1–6
└── TH4C5.cs ... TH11C5.cs# Bài tập tự thực hành 4–11
```

Quy ước tên file: `AD<số bài>C5.cs` = Bài tập **áp dụng** số đó của Chương 5; `TH<số bài>C5.cs` = Bài tập **tự thực hành** số đó của Chương 5.

## Lệnh chạy

```bash
cd Buoi03_Stack_Queue

# Biên dịch + chạy
dotnet run

# Hoặc build bản Release rồi chạy
dotnet build -c Release
dotnet bin/Release/net10.0/Buoi03_Stack_Queue.dll
```

Chương trình hiện menu, nhập số thứ tự (`1`–`14`) để chạy, `0` để thoát. Sau mỗi bài, nhấn Enter để quay lại menu. Các bài nhập lặp (áp dụng 1; tự thực hành 5, 9, 10, 11) bỏ trống rồi Enter để quay lại; các bài dạng menu con (áp dụng 2, 3, 4, 5, 6; tự thực hành 4, 6, 7, 8) nhập `0` để quay lại menu chính.

## Danh sách bài

| Menu | File | Loại | Nội dung |
| :--: | ---- | ---- | -------- |
|  1 | `AD1C5.cs` | Áp dụng 1 | Kiểm tra biểu thức toán học: ngoặc `()`, `[]`, `{}` mở/đóng đúng cách, báo vị trí lỗi (`Stack<char>`) |
|  2 | `AD2C5.cs` | Áp dụng 2 | Lịch sử duyệt web: Visit / Back / Forward bằng hai Stack |
|  3 | `AD3C5.cs` | Áp dụng 3 | Function Call Stack: khung hàm, địa chỉ trả về, đệ quy n! |
|  4 | `AD4C5.cs` | Áp dụng 4 | Hệ thống in ấn (Queue, FIFO): tên tài liệu, số trang, tổng số trang chờ |
|  5 | `AD5C5.cs` | Áp dụng 5 | Đường truyền dữ liệu (Queue): gói tin có độ trễ, có thể bị lỗi, thống kê |
|  6 | `AD6C5.cs` | Áp dụng 6 | Quản lý hàng đợi trung tâm dịch vụ khách hàng: giờ đến, loại dịch vụ, trạng thái nhân viên |
|  7 | `TH4C5.cs` | Tự thực hành 4 | Mô phỏng lịch sử trình duyệt web (`backStack`, `forwardStack`, `currentPage`) |
|  8 | `TH5C5.cs` | Tự thực hành 5 | Kiểm tra chuỗi ngoặc `( )` đúng |
|  9 | `TH6C5.cs` | Tự thực hành 6 | Mô phỏng hệ thống in ấn (Queue, FIFO) |
| 10 | `TH7C5.cs` | Tự thực hành 7 | Mô phỏng đường truyền dữ liệu (Queue) |
| 11 | `TH8C5.cs` | Tự thực hành 8 | Mô phỏng dịch vụ khách hàng, tính thời gian chờ (Queue) |
| 12 | `TH9C5.cs` | Tự thực hành 9 | Tính giá trị biểu thức hậu tố (`Stack<float>`) |
| 13 | `TH10C5.cs` | Tự thực hành 10 | Kiểm tra tính hợp lệ của biểu thức trung tố |
| 14 | `TH11C5.cs` | Tự thực hành 11 | Trung tố → hậu tố (Ba Lan) → tính giá trị |

## Kết quả chạy

> Kết quả dưới đây được chạy thật trên Linux. Các bài tính thời gian thực (áp dụng 6, tự thực hành 8) có giờ và số giây chờ **khác nhau giữa các lần chạy**.

### Menu 1 – Bài tập áp dụng 1 – Kiểm tra biểu thức (ngoặc)

Nhập lần lượt `3 + 5 * (2 - 4)`, `{[1+2)*3}`, `(3 + 4`:

```
Biểu thức có cấu trúc ngoặc đúng
Biểu thức sai (dấu ) ở vị trí 5 không khớp với dấu [ ở vị trí 1)
Biểu thức sai (dấu ( ở vị trí 0 chưa được đóng)
```


### Menu 2 – Bài tập áp dụng 2 – Lịch sử duyệt web (2 Stack)

Truy cập `google.com`, `youtube.com`, Back ba lần, Forward một lần, truy cập `facebook.com`, Forward, rồi chọn `4`:

```
Đã truy cập: google.com
Đã truy cập: youtube.com
Quay lại: google.com
Quay lại: trang-chu
Không thể quay lại
Tiến lên: google.com
Đã truy cập: facebook.com
Không thể tiến lên
Trang hiện tại: facebook.com
Stack Back (đỉnh -> đáy): google.com  trang-chu
Stack Forward (đỉnh -> đáy): (rỗng)
```

> Khi truy cập trang mới, Stack Forward bị xóa sạch; trang bắt đầu là `trang-chu`.


### Menu 3 – Bài tập áp dụng 3 – Function Call Stack

Chọn `4`, nhập `n = 3`:

```
Gọi GiaiThua(3)
Call Stack (đỉnh -> đáy):
  GiaiThua(n=3) -> trả về: Main (lệnh gọi thứ 1)
  Main() -> trả về: hệ điều hành
Gọi GiaiThua(2)
Call Stack (đỉnh -> đáy):
  GiaiThua(n=2) -> trả về: GiaiThua (lệnh gọi thứ 2)
  GiaiThua(n=3) -> trả về: Main (lệnh gọi thứ 1)
  Main() -> trả về: hệ điều hành
Gọi GiaiThua(1)
Call Stack (đỉnh -> đáy):
  GiaiThua(n=1) -> trả về: GiaiThua (lệnh gọi thứ 3)
  GiaiThua(n=2) -> trả về: GiaiThua (lệnh gọi thứ 2)
  GiaiThua(n=3) -> trả về: Main (lệnh gọi thứ 1)
  Main() -> trả về: hệ điều hành
GiaiThua(1) trả về 1
Call Stack (đỉnh -> đáy):
  GiaiThua(n=2) -> trả về: GiaiThua (lệnh gọi thứ 2)
  GiaiThua(n=3) -> trả về: Main (lệnh gọi thứ 1)
  Main() -> trả về: hệ điều hành
GiaiThua(2) trả về 2
Call Stack (đỉnh -> đáy):
  GiaiThua(n=3) -> trả về: Main (lệnh gọi thứ 1)
  Main() -> trả về: hệ điều hành
GiaiThua(3) trả về 6
Call Stack (đỉnh -> đáy):
  Main() -> trả về: hệ điều hành
3! = 6
```


### Menu 4 – Bài tập áp dụng 4 – Hệ thống in ấn

Thêm `baocao.docx` (10 trang), `hopdong.pdf` (3 trang), `anh.png` (1 trang); hiển thị; xử lý hai lần; hiển thị; xử lý lần nữa; xử lý khi rỗng; hiển thị:

```
Đã thêm yêu cầu in #1: baocao.docx (10 trang)
Đã thêm yêu cầu in #2: hopdong.pdf (3 trang)
Đã thêm yêu cầu in #3: anh.png (1 trang)
Danh sách yêu cầu in đang chờ (theo thứ tự FIFO):
#1. baocao.docx - 10 trang
#2. hopdong.pdf - 3 trang
#3. anh.png - 1 trang
Tổng cộng: 3 yêu cầu, 14 trang
Đang in yêu cầu #1: baocao.docx (10 trang)
Còn lại 2 yêu cầu trong hàng đợi
Đang in yêu cầu #2: hopdong.pdf (3 trang)
Còn lại 1 yêu cầu trong hàng đợi
Danh sách yêu cầu in đang chờ (theo thứ tự FIFO):
#3. anh.png - 1 trang
Tổng cộng: 1 yêu cầu, 1 trang
Đang in yêu cầu #3: anh.png (1 trang)
Còn lại 0 yêu cầu trong hàng đợi
Không có yêu cầu in nào!
Hàng đợi rỗng
```

### Menu 5 – Bài tập áp dụng 5 – Đường truyền dữ liệu

Gửi `Hello` (trễ 20 ms), `World` (trễ 35 ms, có lỗi), `Data3` (trễ 50 ms); hiển thị; xử lý bốn lần; thống kê:

```
Đã gửi gói tin #1: Hello
Đã gửi gói tin #2: World
Đã gửi gói tin #3: Data3
Các gói tin đang chờ trên đường truyền:
Gói #1: Hello - trễ 20 ms
Gói #2: World - trễ 35 ms - có lỗi
Gói #3: Data3 - trễ 50 ms
Đã nhận gói tin #1: Hello (độ trễ 20 ms)
Gói tin #2 (World) bị lỗi đường truyền, bị loại bỏ
Đã nhận gói tin #3: Data3 (độ trễ 50 ms)
Không có gói tin nào để xử lý!
Đã gửi: 3 gói, đã nhận: 2 gói, bị mất: 1 gói, đang chờ: 0 gói
Độ trễ trung bình của các gói đã nhận: 35 ms
```

### Menu 6 – Bài tập áp dụng 6 – Quản lý hàng đợi dịch vụ khách hàng

Khách `An` (dịch vụ 1) và `Binh` (dịch vụ 3) đến; hiển thị; nhân viên rảnh phục vụ; hiển thị; phục vụ tiếp hai lần; phục vụ khi hàng đợi rỗng (giờ đến và số giây chờ **khác nhau giữa các lần chạy**):

```
Khách hàng An (số 1) đến lúc 08:08:10, được thêm vào cuối hàng đợi (phía trước còn 0 người)
Khách hàng Binh (số 2) đến lúc 08:08:10, được thêm vào cuối hàng đợi (phía trước còn 1 người)
Nhân viên đang rảnh
Khách hàng đang chờ (2 người):
1. An (số 1) - Gửi/Rút tiền - đến lúc 08:08:10 - chờ 0 giây
2. Binh (số 2) - Tư vấn - đến lúc 08:08:10 - chờ 0 giây
Nhân viên bắt đầu phục vụ: An (số 1) - Gửi/Rút tiền - đã chờ 0 giây
Đang phục vụ: An (số 1) - Gửi/Rút tiền
Khách hàng đang chờ (1 người):
1. Binh (số 2) - Tư vấn - đến lúc 08:08:10 - chờ 0 giây
Đã phục vụ xong khách hàng An (số 1)
Nhân viên bắt đầu phục vụ: Binh (số 2) - Tư vấn - đã chờ 0 giây
Đã phục vụ xong khách hàng Binh (số 2)
Nhân viên rảnh rỗi, không có khách hàng nào trong hàng đợi!
```

### Menu 7 – Bài tự thực hành 4 – Lịch sử trình duyệt web

Truy cập `google.com`, `youtube.com`, Back hai lần, Forward, rồi chọn `4`:

```
Đang truy cập: google.com
Đang truy cập: youtube.com
Quay lại: google.com
Không thể quay lại
Tiến lên: youtube.com
Trang hiện tại: youtube.com
```


### Menu 8 – Bài tự thực hành 5 – Kiểm tra chuỗi ngoặc

Nhập lần lượt `(())`, `(()))`, `)(`, `()()`:

```
Xâu đúng
Xâu sai
Xâu sai
Xâu đúng
```


### Menu 9 – Bài tự thực hành 6 – Hệ thống in ấn

Thêm `baocao.docx`, `hopdong.pdf`, `anh.png`; hiển thị; xử lý hai lần; hiển thị; xử lý hai lần nữa; hiển thị:

```
Đã thêm vào hàng đợi: baocao.docx
Đã thêm vào hàng đợi: hopdong.pdf
Đã thêm vào hàng đợi: anh.png
Danh sách hàng đợi:
1. baocao.docx
2. hopdong.pdf
3. anh.png
Đang in: baocao.docx
Đang in: hopdong.pdf
Danh sách hàng đợi:
1. anh.png
Đang in: anh.png
Không có yêu cầu in nào!
Hàng đợi rỗng
```


### Menu 10 – Bài tự thực hành 7 – Đường truyền dữ liệu

Gửi `Hello`, `World`, `Data3`; hiển thị; nhận hai lần; hiển thị; nhận hai lần nữa:

```
Đã gửi gói #1: Hello
Đã gửi gói #2: World
Đã gửi gói #3: Data3
Các gói dữ liệu trong hàng đợi:
Gói #1: Hello
Gói #2: World
Gói #3: Data3
Đã nhận gói #1: Hello
Đã nhận gói #2: World
Các gói dữ liệu trong hàng đợi:
Gói #3: Data3
Đã nhận gói #3: Data3
Không có dữ liệu để nhận!
```


### Menu 11 – Bài tự thực hành 8 – Dịch vụ khách hàng

Thêm `An` (dịch vụ 1), `Binh` (dịch vụ 3), `Cuong` (dịch vụ 2); hiển thị; phục vụ ba lần rồi phục vụ lần nữa (nhập liên tục nên thời gian chờ ≈ 0 giây):

```
Đã thêm khách hàng An (số 1), phía trước còn 0 người
Đã thêm khách hàng Binh (số 2), phía trước còn 1 người
Đã thêm khách hàng Cuong (số 3), phía trước còn 2 người
Khách hàng đang chờ (3 người):
1. An (số 1) - Gửi/Rút tiền - chờ 0 giây
2. Binh (số 2) - Tư vấn - chờ 0 giây
3. Cuong (số 3) - Mở tài khoản - chờ 0 giây
Đang phục vụ khách hàng: An (số 1) - Gửi/Rút tiền - đã chờ 0 giây
Đang phục vụ khách hàng: Binh (số 2) - Tư vấn - đã chờ 0 giây
Đang phục vụ khách hàng: Cuong (số 3) - Mở tài khoản - đã chờ 0 giây
Không có khách hàng nào trong hàng đợi!
```


### Menu 12 – Bài tự thực hành 9 – Tính giá trị biểu thức hậu tố

Nhập lần lượt `3 4 2 * +`, `5 1 2 + 4 * + 3 -`, `10 4 /`, `5 0 /`, `3 +`, `3 4`:

```
Giá trị biểu thức: 11
Giá trị biểu thức: 14
Giá trị biểu thức: 2.5
Chia cho 0
Thiếu toán hạng cho toán tử +
Biểu thức hậu tố không hợp lệ
```


### Menu 13 – Bài tự thực hành 10 – Kiểm tra tính hợp lệ biểu thức trung tố

Nhập lần lượt `3 + 5 * (2 - 4)`, `{[1+2]*3}/4`, `3 + * 5`, `[1+2)`, `5 + 6 -`, `+ 3 - 1`, `(3 + 4`:

```
Dấu ngoặc: mở và đóng đúng cách
Biểu thức hợp lệ
Dấu ngoặc: mở và đóng đúng cách
Biểu thức hợp lệ
Dấu ngoặc: mở và đóng đúng cách
Biểu thức không hợp lệ (hai toán tử liên tiếp)
Dấu ngoặc: sai
Biểu thức không hợp lệ (dấu ) không khớp với dấu mở)
Dấu ngoặc: mở và đóng đúng cách
Biểu thức không hợp lệ (biểu thức kết thúc bằng toán tử)
Dấu ngoặc: mở và đóng đúng cách
Biểu thức không hợp lệ (biểu thức bắt đầu bằng toán tử +)
Dấu ngoặc: sai
Biểu thức không hợp lệ (còn dấu ngoặc mở chưa được đóng)
```


### Menu 14 – Bài tự thực hành 11 – Tính giá trị biểu thức trung tố

Nhập lần lượt `3 + 5 * (2 - 4)`, `(1 + 2) * 3 - 4 / 2`, `10 / 4`, `8 / (4 - 4)`, `3 + [4]`, `3 + * 4`:

```
Biểu thức hậu tố: 3 5 2 4 - * +
Giá trị biểu thức: -7
Biểu thức hậu tố: 1 2 + 3 * 4 2 / -
Giá trị biểu thức: 7
Biểu thức hậu tố: 10 4 /
Giá trị biểu thức: 2.5
Biểu thức hậu tố: 8 4 4 - /
Chia cho 0
Biểu thức không hợp lệ (chỉ cho phép ngoặc tròn, gặp [)
Biểu thức không hợp lệ (hai toán tử liên tiếp)
```

> Bài 11 chỉ nhận số, `+ - * /` và ngoặc tròn `( )`; hậu tố được tính bằng `B9C5.Tinh`, kiểm tra hợp lệ bằng `B10C5.KiemTra`.


## Ghi chú

- Dữ liệu nhập không phải số bị `Program.cs` bắt (`FormatException`), in `Dữ liệu nhập không đúng định dạng` rồi quay lại menu chính (ví dụ nhập số trang ở áp dụng 4, chọn dịch vụ ở áp dụng 6, nhập `n` ở áp dụng 3).
- Áp dụng 3 chỉ nhận `n` trong khoảng 0..12 (tránh tràn kiểu `long`).
- Áp dụng 2 và tự thực hành 4 cùng mô hình hai Stack (Back/Forward); áp dụng 2 có thêm mục xem nội dung hai Stack.
- Áp dụng 4, 5, 6 là phiên bản mở rộng của tự thực hành 6, 7, 8: thêm số trang, độ trễ/lỗi đường truyền và trạng thái nhân viên phục vụ.
- Tự thực hành 11 dùng lại `TH9C5.LaToanHang`, `TH9C5.Tinh`, `TH9C5.InSo` và `TH10C5.KiemTra`, nên không xóa tự thực hành 9, 10.
- Tất cả bài nằm chung namespace `Buoi03_Stack_Queue`, mỗi bài là một lớp có phương thức `Run()` để `Program.cs` gọi.
