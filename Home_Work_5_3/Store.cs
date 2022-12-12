using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_5_3
{
    internal class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[size];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                {
                    return articles[index].ShowInfo();
                }
                return "out of array";
            }
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                    if (articles[i].NameItem == index)
                        return articles[i].ShowInfo();

                return string.Format($"\"{index}\" out of stock.");
            }
        }
        public void AddItem(Article value, int index)
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index] = value;
            }
            else
                Console.WriteLine("out of array");
        }
        public void Show()
        {
            for (int i = 0; i < articles.Length; i++)
                Console.WriteLine(articles[i].ShowInfo());
        }
    }
}
