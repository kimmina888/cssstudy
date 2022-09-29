using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSClass232
{
	internal class Program
	{
		static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
		{
			rx = x + vx;
			ry = y + vy;
		}

		class PointClass
		{
			public int x;
			public int y;
			public PointClass(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}

		struct PointStruct
		{
			public int x;
			public int y;
			public PointStruct(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}

		struct Point
		{
			public int x;
			public int y;
			public string testA;
			public string testB;

			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
				this.testA = "�ʱ�ȭ";
				this.testB = "�ʱ�ȭ";
			}
			public Point(int x, int y, string s)
			{
				this.x = x;
				this.y = y;
				this.testA = s;
				this.testB = s;
			}
		}

		static void Main(string[] args)
		{
			Wanted<string> wantedString = new Wanted<string>("String");
			Wanted<int> wantedInt = new Wanted<int>(52273);
			Wanted<double> wantedDouble = new Wanted<double>(52.273);

			Console.WriteLine(wantedString.Value);
			Console.WriteLine(wantedInt.Value);
			Console.WriteLine(wantedDouble.Value);

			Products p = new Products();
			Console.WriteLine("������ ���� �޴��� " + p[2] + "�Դϴ�.");
			p[2] = "�ܹ���";
			Console.WriteLine("������ ���� �޴��� " + p[2] + "�Դϴ�.");

			Console.WriteLine("���� �Է�: ");
			//int output;
			bool result = int.TryParse(Console.ReadLine(), out int output);
			if (result)
			{
				Console.WriteLine("�Է��� ����" + output);
			}
			else
			{
				Console.WriteLine("���ڸ� �Է����ּ���!");
			}
			int x = 0;
			int y = 0;
			int vx = 1;
			int vy = 1;
			Console.WriteLine("���� ��ǥ: (" + x + "," + y + ")");
			NextPos(x, y, vx, vy, out x, out y);
			Console.WriteLine("���� ��ǥ: (" + x + "," + y + ")");

			Point point;
			point.x = 10;
			point.y = 10;
			point = new Point(100, 200);
			point = new Point();
			Console.WriteLine(point.x + " / " + point.y);

			PointClass pcA = new PointClass(10, 20);
			PointClass pcB = pcA;
			pcB.x = 100; pcB.y = 200;
			Console.WriteLine(pcA.x + " / " + pcA.y);
			Console.WriteLine(pcB.x + " / " + pcB.y);

			PointStruct psA = new PointStruct(10, 20);
			PointStruct psB = psA;
			psB.x = 100; psB.y = 200;
			Console.WriteLine(psA.x + " / " + psA.y);
			Console.WriteLine(psB.x + " / " + psB.y);
			using (Dummy dummy = new Dummy())
			{
				List<Product> list = new List<Product>() {
					new Product(){ Name="����", Price=1500 },
					new Product(){ Name="���", Price=2400 },
					new Product(){ Name="�ٳ���", Price=1000 },
					new Product(){ Name="��", Price=3000 },
				};
				list.Sort();
				foreach (var item in list)
				{
					Console.WriteLine(item);
				}
			}

			IBasic test = new TestClass();
			test.TestProperty = 3;
			test.TestInstanceMethod();
			//test.foobar();
			(test as TestClass).foobar();

		}

		class Dummy : IDisposable
		{
			public void Dispose()
			{
				Console.WriteLine("Dispose() �޼��带 ȣ���߽��ϴ�.");
			}
		}

		class TestClass : IBasic
		{
			public int foobar()
			{
				return -1;
			}
			public int TestProperty
			{
				get => throw new NotImplementedException();
				set => throw new NotImplementedException();
			}

			public int TestInstanceMethod()
			{
				throw new NotImplementedException();
			}
		}

	}
}