// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Tạo mới project với tên RandomStudents.

// Phát sinh ngẫu nhiên 10 sinh viên và in thông tin ra màn hình.
// Lớp sinh viên có các thuộc tính: MSSV, Họ và tên, GPA(điểm trung bình), Địa chỉ.
// - MSSV: Độ dài là 8, 2 kí tự đầu tiên là năm, 6 số tiếp theo là ngẫu nhiên.
// - Họ và tên: Chuẩn bị mảng sẵn các họ, tên lót, tên thông dụng ở VN, tổ hợp ngẫu nhiên là được.
// - Địa chỉ: chỉ cần tạo ra ngẫu nhiên nhìn giống thật gồm các yếu tố: số nhà, tên đường, phường, quận là được.
class SinhVien
{
	public string MSSV { get; set; }
	public string HoTen { get; set; }
	public string DiaChi { get; set; }
	public override string ToString()
	{
		return $"{MSSV} - {HoTen} - {DiaChi}";
	}
}

string[] HO = new string[] { "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Phan", "Vũ", "Đặng", "Bùi", "Đỗ", "Hồ", "Ngô", "Dương", "Lý" };
string[] DEM = new string[] { "Hữu", "Gia", "Đình", "Hoài", "Huy", "Khánh", "Hải", "Bảo", "An", "Phúc", "Anh" };
string[] TEN = { "Trang", "Anh", "Linh", "Phương", "Hương", "Thảo", "Hà", "Huyền", "Ngọc", "Hằng", "Giang", "Nhung", "Yến", "Nga", "Mai", "Thu", "Hạnh", "Vân", "Hoa", "Hiền" };

class RandomStudent
{
	private int _start = 1;
	private char _name = 'A';

	public SinhVien Next()
	{
		SinhVien result = new SinhVien()
		{
			MSSV = $"00{_start}",
			HoTen = $"Nguyen Van {_name}",
			DiaChi = $"Random ne",
		};
		_start++;
		_name++;
		return result;
	}
}

SinhVien result = new SinhVien()