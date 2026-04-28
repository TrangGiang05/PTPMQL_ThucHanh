## 1. Tìm hiểu cấu trúc thư mục của dự án .Net MVC
- **Controllers:** Chứa các class C# đóng vai trò điều hướng, xử lý yêu cầu (request) từ người dùng.
- **Models:** Chứa các class C# đại diện cho cấu trúc dữ liệu và tương tác với Database.
- **Views:** Chứa các file giao diện `.cshtml` (kết hợp giữa HTML và C#) để hiển thị trang web.
- **wwwroot:** Chứa các tài nguyên tĩnh không cần biên dịch như file CSS, JavaScript, Hình ảnh.
- **Program.cs:** File "cửa ngõ" cấu hình chính, nơi khởi động ứng dụng và đăng ký các dịch vụ (Services).

## 2. Tìm hiểu về định tuyến (Route)
- Route là cơ chế phân tích đường dẫn URL trên trình duyệt để quyết định xem yêu cầu đó sẽ được giao cho Controller nào và hàm (Action) nào xử lý.
- Cấu trúc mặc định của .NET MVC là: `{controller}/{action}/{id?}`. 
- *Ví dụ:* Khi người dùng gõ URL `/Student/Create`, hệ thống sẽ tự động gọi hàm `Create` nằm bên trong `StudentController`.

## 3. Tìm hiểu về Namespace trong C#
- Namespace hoạt động giống như một "thư mục ảo" để gom nhóm các đoạn code/class có liên quan lại với nhau.
- Nó giúp tránh xung đột tên gọi. *Ví dụ:* Bạn có thể tạo 2 class cùng tên là `Student`, miễn là chúng được đặt ở 2 Namespace khác nhau (ví dụ: `App.Models.Student` và `App.ViewModels.Student`).

## 4. Tìm hiểu về Controller và View
- **Controller (Bộ não):** Là nơi tiếp nhận yêu cầu từ người dùng, thực hiện tính toán logic, gọi Model lấy dữ liệu, sau đó quyết định sẽ hiển thị kết quả ra sao.
- **View (Khuôn mặt):** Nhận dữ liệu đã xử lý từ Controller và "trang điểm" nó thành mã HTML để trình duyệt web có thể đọc và hiển thị cho người dùng xem.