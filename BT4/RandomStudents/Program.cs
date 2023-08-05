
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
class RandomAddress
{
	private static string[] Streets = new string[] { "Cách Mạng Tháng Tám", "Nguyễn Thị Minh Khai" };
	private static string[] Districts = new string[] { "Quận 1", "Quận Bình Thạnh", "Quận 3", "Quận Gò Vấp", "Quận 4", "Quận Phú Nhuận", "Quận 5", "Quận Tân Bình", "Quận 6", "Quận Tân Phú", "Quận 7", "Huyện Bình Chánh", "Quận 8", "Huyện Cần Giờ", "Quận 10", "Huyện Củ Chi", "Quận 11", "Huyện Hóc Môn", "Quận 12", "Huyện Nhà Bè" };
}
class RandomName
{
	private static string[] Surnames = new string[] { "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Phan", "Vũ", "Đặng", "Bùi", "Đỗ", "Hồ", "Ngô", "Dương", "Lý" };
	private static string[] MiddleNames = new string[] { "Hữu", "Gia", "Đình", "Hoài", "Huy", "Khánh", "Hải", "Bảo", "An", "Phúc", "Anh" };
	private static string[] GivenNames = { "Trang", "Anh", "Linh", "Phương", "Hương", "Thảo", "Hà", "Huyền", "Ngọc", "Hằng", "Giang", "Nhung", "Yến", "Nga", "Mai", "Thu", "Hạnh", "Vân", "Hoa", "Hiền" };

	private Random rnd;

	public RandomName()
	{
		rnd = new Random();
	}

	public String Next()
	{
		string surname = Surnames[rnd.Next(0, Surnames.Length)];
		string middleName = MiddleNames[rnd.Next(0, MiddleNames.Length)];
		string givenName = GivenNames[rnd.Next(0, GivenNames.Length)];
		return $"{surname} {middleName} {givenName}";
	}

}

class RandomStudent
{
	private int _start = 1;
	private char _name = 'A';


	public SinhVien Next()
	{
		SinhVien result = new SinhVien
		{
			MSSV = $"00{_start}",
			HoTen = (new RandomName()).Next(),
			DiaChi = $"Random ne",
		};
		_start++;
		_name++;
		return result;
	}
}

class Program
{
	public static void Main(string[] args)
	{
		RandomStudent rds = new RandomStudent();
		Console.WriteLine(rds.Next());
	}
}