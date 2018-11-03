using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo {
    public class User {
        [Key,Index]//设置Id为主键,并添加索引
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
