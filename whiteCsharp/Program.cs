using Animal;
using System;


//namespace using, class object, atrribute, main method, constructor method, getter setter, static attribute  
#region  Part1
//Program : 包在Main方法外的模板
class Program
{
    //Main 方法 : 程式執行進入點
    static void Main()
    {
        // 物件 :只要是用模板新增的
        Person person1 = new Person(170.3, 42, "小黑");

        //物件2
        Person person2 = new Person(160, 16, "小橘");


        //getter setter
        Video video1 = new Video("132", "小白", "教育");

        //經過限制存取之後 video2.type = "其他"
        Video video2 = new Video("132", "小黑", "fqwfsadf");
    }
}
#endregion












