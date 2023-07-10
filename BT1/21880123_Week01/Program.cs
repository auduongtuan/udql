// 1. Phát sinh ngẫu nhiên số nguyên dương n (10 <= n <= 30). (Ví dụ phát sinh ra n = 7)
Random rng = new Random();
int n = rng.Next(10, 30);
Console.WriteLine($"n = {n}");

// 2. Từ câu 1, phát sinh ngẫu nhiên tiếp n số nguyên trong đoạn từ [10, 1000] và in ra màn hình mảng gốc.
// (Ví dụ câu 1 sinh ra n = 7 thì sinh ra tiếp 7 số nguyên, mỗi số nguyên trong đoạn từ [10,1000] như sau: [11, 77, 999, 127, 921, 134, 662]
var r = new List<int>();

void printList(List<int> l, string prefix = "")
{
  if (prefix != "")
  {
    Console.Write(prefix);
  }
  if (l.Count == 0)
  {
    Console.Write('-');
    Console.WriteLine();
  }
  for (int i = 0; i < l.Count; i++)
  {
    Console.Write($"{l[i]}");
    if (i != l.Count - 1)
    {
      Console.Write(", ");
    }
    else
    {
      Console.WriteLine();
    }
  }
}
for (int i = 0; i < n; i++)
{
  r.Add(rng.Next(10, 1000));
}
printList(r, $"{n} cac so ngau nhien: ");

// 3. Tìm các số nguyên tố trong mảng và in ra màn hình.
bool isPrime(int num)
{
  if (num < 2) return false;
  if (num == 2) return true;
  for (int i = 2; i <= Math.Sqrt(num); i++)
  {
    if (num % i == 0)
    {
      return false;
    }
  }
  return true;
}

List<int> prime = new List<int>();
foreach (int num in r)
{
  if (isPrime(num))
  {
    prime.Add(num);
  }
}
printList(prime, "Cac so nguyen to: ");

// 4. Cho biết số lớn nhất, số nhỏ nhất, tổng các số, giá trị trung bình.
int max = r[0];
int min = r[0];
int sum = 0;
foreach (int num in r)
{
  if (max < num)
  {
    max = num;
  }
  if (min > num)
  {
    min = num;
  }
  sum += num;
}
double avg = sum / n;
Console.WriteLine($"So lon nhat: {max}");
Console.WriteLine($"So nho nhat: {min}");
Console.WriteLine($"Tong cac so: {sum}");
Console.WriteLine($"Gia tri trung binh: {avg}");

// 5. Cho biết các số chỉ toàn chữ số lẻ
bool hasAllOddDigits(int num)
{
  int m = num;
  do
  {
    int d = m % 10;
    if (d % 2 == 0)
    {
      return false;
    }
    m = m / 10;
  }
  while (m > 0);
  return true;
}

var hasOddDigits = new List<int>();
foreach (int num in r)
{
  if (hasAllOddDigits(num) == true)
  {
    hasOddDigits.Add(num);
  }
}
printList(hasOddDigits, "Cac so chi toan chu so le: ");