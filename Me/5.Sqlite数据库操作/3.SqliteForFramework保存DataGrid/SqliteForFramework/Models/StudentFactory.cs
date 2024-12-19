using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteForFramework.Models
{
    //该实体类和表“StudentFactory”存在联系
    [Table("StudentFactory")]
    public class StudentFactory
    {
        //学号
        [Key]//主键
        public int Id { get; set; }
        //年龄
        public int Age { get; set; }
        //成绩
        public int Grade { get; set; }
    }
}
