using System;
using System.Linq;

namespace EFDemo {
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new UserContext()) {
                var user = new User {
                    Id = 1,
                    Name = "user",
                    Password = "123",
                };
                context.User.Add(user);//新增一条数据
                context.SaveChanges();//保存更改.每一次对数据库的CUD操作都应该使用此方法
                var query = from a in context.User
                            where a.Id == 1
                            select a;//Linq 语句用户快速查询
                Console.Write($"UserId:{user.Id},UserName:{user.Name   },UserPassword:{user.Password}");
                Console.ReadKey();
            }
        }
    }
}
