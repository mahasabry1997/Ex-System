//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Exam_App
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ques_Choices
    {
        public int QuesId { get; set; }
        public string choices { get; set; }
        public string body { get; set; }
    
        public virtual Question Question { get; set; }
    }
}