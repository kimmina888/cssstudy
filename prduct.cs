using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass232
{
    class Products
    {
        private List<string> items = new List<string>() { "¥���", "«��", "������" };
        public string this[int i]
        {
            get { return items[i]; }
            set
            {
                items[i] = value;
                Console.WriteLine(i + "��° ��ǰ�� " + value + "�� ����");
            }
        }
    }
}