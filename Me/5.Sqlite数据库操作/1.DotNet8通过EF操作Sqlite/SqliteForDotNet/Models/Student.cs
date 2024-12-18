using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteForDotNet.Models
{
    //2.创建一个数据表类Student
    [Table(nameof(Student))]//表名
    public class Student
    {
        [Key]   //主键
        public string Guid { get; set; }

        [Required]//非空
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }


        /// <summary>
        /// 重写ToString()方法，方便输出查看
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Guid：" + Guid + Environment.NewLine +
                "Name：" + Name + Environment.NewLine +
                "Age：" + Age + Environment.NewLine;
        }
    }
}
