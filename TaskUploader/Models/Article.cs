//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskUploader.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Article
    {
        internal object fileDumps;

        public int FileId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string FileName { get; set; }

        [Required(ErrorMessage = "Please select your file.")]
        public byte[] FileContent { get; set; }
    }
}
