//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeWork.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chapter
    {
        public Chapter()
        {
            this.Homework = new HashSet<Homework>();
        }
    
        public int ChapterId { get; set; }
        public string ChapterName { get; set; }
        public int SubjectId { get; set; }
    
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Homework> Homework { get; set; }
    }
}
