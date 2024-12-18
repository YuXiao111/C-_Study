using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteForDotNet.Models
{
    [Table(nameof(Class))]//表名
    public class Class
    {
        [Key]   //主键
        public string Id { get; set; }

        [Required]//非空
        public string ClassName { get; set; }

        [Required]
        public int ClassId { get; set; }


        /// <summary>
        /// 重写ToString()方法，方便输出查看
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Id：" + Id + Environment.NewLine +
                "ClassName：" + ClassName + Environment.NewLine +
                "ClassId：" + ClassId + Environment.NewLine;
        }
    }
}
