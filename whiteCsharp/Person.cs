using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace using, class object, atrribute, main method, constructor method, getter setter, static attribute  
#region Part1
namespace Animal
{
    //模板
    class Person
    {
        //屬性
        //public/private info_type name
        public double height;
        public int age;
        public string name;

        //建構方法 : 每次創建物件的時候皆會執行
        // public/private name()
        public Person(double height, int a, string n)
        {
            //this. : 使其變為屬性參數，而不是輸入參數
            this.height = height;
            age = a;
            name = n;
            Console.WriteLine("創建成功");
        }

        //方法
        //public/pivate void/info_type name( ){ }
        public void Sayhi()
        {
            Console.WriteLine("你好啊我叫" + name);
        }

        public Boolean IsAdult()
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Add(int num1, int num2, string qq)
        {
            return num1 + num2;
        }
    }

    //範例 : video
    class Video
    {

        #region 1. Video 物件的屬性
        public string title;
        public string author;
        //影片類型 : 教育、娛樂、音樂、其他
        //將public改為private : 使其屬性只能在該所屬class內(Video)中被存取
        private string type;
        #endregion

        #region 2. class 類別的屬性;
        public static int video_count = 0;
        #endregion

        #region 建構方法
        public Video(string title, string author, string type)
        {
            this.title = title;
            this.author = author;
            //這裡要取得值必須先經由下方 public string Type 賦值
            Type = type;

            //使類別屬性的值每次創建++
            video_count++;
        }
        #endregion

        #region get, set : 限制存取
        public string Type
        {
            //get : 當取得該變數時執行
            get { return type; }
            //set : 當賦值時執行
            set
            {
                if (value == "教育" || value == "娛樂" || value == "音樂" || value == "其他")
                {
                    type = value;
                }
                else
                {
                    type = "其他";
                }
            }
        }
        #endregion

    }
}
#endregion

#region Part2

#endregion