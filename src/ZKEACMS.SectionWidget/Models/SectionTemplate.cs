/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.MetaData;
using Easy.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZKEACMS.SectionWidget.Models
{
    [Table("SectionTemplate")]
    public class SectionTemplate : EditorEntity
    {
        [Key]
        public string TemplateName { get; set; }
        public string Thumbnail { get; set; }
        public string ExampleData { get; set; }
    }


}