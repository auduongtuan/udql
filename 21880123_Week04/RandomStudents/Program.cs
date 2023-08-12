
// Tạo mới project với tên RandomStudents.

// Phát sinh ngẫu nhiên 10 sinh viên và in thông tin ra màn hình.
// Lớp sinh viên có các thuộc tính: MSSV, Họ và tên, GPA(điểm trung bình), Địa chỉ.
// - MSSV: Độ dài là 8, 2 kí tự đầu tiên là năm, 6 số tiếp theo là ngẫu nhiên.
// - Họ và tên: Chuẩn bị mảng sẵn các họ, tên lót, tên thông dụng ở VN, tổ hợp ngẫu nhiên là được.
// - Địa chỉ: chỉ cần tạo ra ngẫu nhiên nhìn giống thật gồm các yếu tố: số nhà, tên đường, phường, quận là được.

class Student
{
	public string Id { get; set; }
	public string Name { get; set; }
	public string Address { get; set; }
	public double GPA { get; set; }
	public override string ToString()
	{
		return $"{Id} - {Name} - {Address} - {GPA}";
	}
}
class RandomBase
{
	private Random rnd;

	public RandomBase()
	{
		rnd = new Random();
	}
	public string GetRandomValue(string[] Values)
	{
		return Values[rnd.Next(0, Values.Length)];
	}

	public int GetRandomInt(int min, int max)
	{
		return rnd.Next(min, max);
	}
	public string GetRandomNumberString(int length, int min = 0, int max = -1)
	{
		int maxValue = max == -1 ? (int)Math.Pow(10, length) : max;
		int randNum = rnd.Next(min, maxValue);
		string randomLength = randNum.ToString("D" + length);
		return randomLength;
	}
}

class RandomAddress : RandomBase
{
	private static string[] Streets = new string[] { "Alexandre de Rhodes", "An Dương Vương", "Âu Cơ", "Bà Lê Chân", "Ba Vì", "Bạch Đằng", "Bạch Mã", "Bàn Cờ", "Bùi Hửu Nghĩa", "Bùi Thị Xuân", "Bùi Viện", "Bửu Long", "Cách Mạng Tháng Tám", "Calmette", "Cao Thắng", "Châu Thới", "Chơ Ông Địa", "Chu Mạnh Trinh", "Cô Bắc", "Cô Giang", "Cộng Hòa", "Cống Quỳnh", "Công Trường Mê Linh", "Công xã Paris", "Cửu Long", "Đặng Dung", "Đặng Tất", "Đặng Thị Nhu", "Đặng Trần Côn", "Đặng Văn Ngữ", "Đào Duy Từ", "Đề Thám", "Điện Biên Phủ", "Đinh Công Tráng", "Đinh Tiên Hoàng", "Đồ Sơn", "Đống Đa", "Đông Du", "Đồng Khởi", "Đồng Nai", "Dương Vân Nga", "Duy Tân", "Giải Phóng", "Hai Bà Trưng", "Hải Triều", "Hàm Nghi", "Hàn Thuyên", "Hát Giang", "Hậu Giang", "Hồ Bá Kiện", "Hồ Biểu Chánh", "Hồ Con Rùa", "Hồ Hảo Hớn", "Hồ Huân Nghiệp", "Hồ Thị Kỷ", "Hồ Tùng Mậu", "Hồ Xuân Hương", "Hòa Hảo", "Hoàng Diệu", "Hoàng Văn Thụ", "Hoàng Việt", "Hồng Hà", "Hồng Lĩnh", "Hùng Vương", "Hương Giang", "Huyền Quang", "Huyền Trân Công Chúa", "Huỳnh Khương Ninh", "Huỳnh Mẫn Đạt", "Huỳnh Thúc Kháng", "Huỳnh Tịnh Của", "Huỳnh Văn Bánh", "Ký Con", "Kỳ Đồng", "Lạc Long Quản", "Lam Sơn", "Lê Anh Xuân", "Lê Bình", "Lê Công Kiều", "Lê Đại Hành", "Lê Duẩn", "Lê Hồng Phong", "Lê Lai", "Lê Lợi", "Lê Quý Đôn", "Lê Thánh Tôn", "Lê Thị Bạch Cát", "Lê Thị Hồng Gấm", "Lê Thị Riêng", "Lê Văn Hưu", "Lê Văn Sỹ", "Lưu Văn Lang", "Lý Thái Tổ", "Lý Thường Kiệt", "Lý Tự Trọng", "Lý Văn Phức", "Mạc Đĩnh Chi", "Mạc Thị Bưởi", "Nam Kỳ Khởi Nghĩa", "Ngô Đức Kế", "Ngô Gia Tự", "Ngô Quyền", "Ngô Thời Nhiệm", "Nguyễn An Ninh", "Nguyễn Bặc", "Nguyễn Biểu", "Nguyễn Bỉnh Khiêm", "Nguyễn Cảnh Chân", "Nguyễn Cảnh Dị", "Nguyễn Chí Thanh", "Nguyễn Công Trứ", "Nguyễn Cư Trinh", "Nguyễn Đình Chiểu", "Nguyễn Đình Chính", "Nguyễn Du", "Nguyễn Gia Thiều", "Nguyễn Giản Thanh", "Nguyễn Hiền", "Nguyễn Huệ", "Nguyễn Hữu Cảnh", "Nguyễn Hữu Cầu", "Nguyễn Huy Tự", "Nguyễn Khắc Nhua", "Nguyễn Phi Khanh", "Nguyễn Phúc Nguyên", "Nguyễn Sơn Hà", "Nguyễn Thái Bình", "Nguyễn Thái Học", "Nguyễn Thị Diệu", "Nguyễn Thị Minh Khai", "Nguyễn Thị Nghĩa", "Nguyễn Thiện Thuật", "Nguyễn Thiếp", "Nguyễn Thông", "Nguyễn Thượng Hiền", "Nguyễn Tiểu La", "Nguyễn Trãi", "Nguyễn Tri Phương", "Nguyễn Trung Ngạn", "Nguyễn Trung Trực", "Nguyễn Văn Cừ", "Nguyễn Văn Giai", "Nguyễn Văn Nguyễn", "Nguyễn Văn Trỗi", "Nguyễn Văn Vĩnh", "Pasteur", "Phạm Hồng Thái", "Phạm Ngọc Thạch", "Phạm Ngũ Lão", "Phạm Văn Hai", "Phạm Viết Chánh", "Phan Bội Châu", "Phan Chu Trinh", "Phan Đăng Lưu", "Phan Đình Giót", "Phan Đình Phùng", "Phan Kế Bính", "Phan Liêm", "Phan Ngữ", "Phan Thúc Duyện", "Phan Tôn", "Phan Văn Ðạt", "Phan Văn Trị", "Phan Văn Trường", "Phó Đức Chính", "Phùng Khắc Khoan", "Rạch Bùng Binh", "Sầm Sơn", "Sông Đáy", "Sông Thương", "Sư Thiện Chiếu", "Sư Vạn Hạnh", "Sương Nguyệt Anh", "Tam Đảo", "Tân Cảnh", "Thái Văn Lung", "Thăng Long", "Thành Thái", "Thất Sơn", "Thi Sách", "Thoại Ngọc Hầu", "Thủ Khoa Huân", "Tiền Giang", "Tô Hiến Thành", "Tôn Đức Thắng", "Tôn Thất Đàm", "Tôn Thất Thiệp", "Tôn Thất Tùng", "Trà Khúc", "Trần Bình Trọng", "Trần Cao Vân", "Trần Đình Xu", "Trần Hưng Đạo", "Trần Hữu Trang", "Trần Huy Liệu", "Trần Khắc Chân", "Trần Khánh Dư", "Trần Nhân Tôn", "Trần Nhật Duật", "Trần Phú", "Trần Quang Diệu", "Trần Quang Khải", "Trần Quốc Hoàn", "Trần Quốc Thảo", "Trần Quốc Toản", "Trần Quý Khoách", "Trần Thiện Chánh", "Trần Tuấn Khải", "Trần Văn Đang", "Trịnh Văn Cấn", "Trương Định", "Trương Hán Siêu", "Trương Hoàng Thanh", "Trương Quốc Dụng", "Trương Quyền", "Trường Sơn", "Tú Xương", "Út Tịch", "Vĩnh Viễn", "Võ Thị Sáu", "Võ Văn Kiệt", "Võ Văn Tần", "Vườn Chuối", "Yên Thế", "Yersin", "Yết Kiêu" };
	private static string[] Districts = new string[] { "Quận 1", "Quận Bình Thạnh", "Quận 3", "Quận Gò Vấp", "Quận 4", "Quận Phú Nhuận", "Quận 5", "Quận Tân Bình", "Quận 6", "Quận Tân Phú", "Quận 7", "Huyện Bình Chánh", "Quận 8", "Huyện Cần Giờ", "Quận 10", "Huyện Củ Chi", "Quận 11", "Huyện Hóc Môn", "Quận 12", "Huyện Nhà Bè" };

	public String Next()
	{
		string street = GetRandomValue(Streets);
		string district = GetRandomValue(Districts);
		int addressNo = GetRandomInt(1, 200);
		int ward = GetRandomInt(1, 20);
		return $"{addressNo} {street}, Phường {ward}, {district}";
	}
}

class RandomName : RandomBase
{
	private static string[] Surnames = new string[] { "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Phan", "Vũ", "Đặng", "Bùi", "Đỗ", "Hồ", "Ngô", "Dương", "Lý" };
	private static string[] MiddleNames = new string[] { "Hữu", "Gia", "Đình", "Hoài", "Huy", "Khánh", "Hải", "Bảo", "An", "Phúc", "Anh" };
	private static string[] GivenNames = { "Trang", "Anh", "Linh", "Phương", "Hương", "Thảo", "Hà", "Huyền", "Ngọc", "Hằng", "Giang", "Nhung", "Yến", "Nga", "Mai", "Thu", "Hạnh", "Vân", "Hoa", "Hiền" };

	public String Next()
	{
		string surname = GetRandomValue(Surnames);
		string middleName = GetRandomValue(MiddleNames);
		string givenName = GetRandomValue(GivenNames);
		return $"{surname} {middleName} {givenName}";
	}

}

class RandomId : RandomBase
{
	public String Next()
	{
		string year = GetRandomNumberString(2, 10, 23);
		string others = GetRandomNumberString(6);
		return $"{year}{others}";
	}
}

class RandomGPA : RandomBase
{
	public double Next()
	{
		double gpax10 = GetRandomInt(0, 101);
		double gpa = gpax10 / 10;
		return gpa;
	}
}

class RandomStudent
{
	public Student Next()
	{
		Student result = new Student
		{
			Id = (new RandomId()).Next(),
			Name = (new RandomName()).Next(),
			Address = (new RandomAddress()).Next(),
			GPA = (new RandomGPA()).Next()
		};
		return result;
	}
}

class Program
{
	public static void Main(string[] args)
	{
		RandomStudent rds = new RandomStudent();
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine(rds.Next());
		}
	}
}