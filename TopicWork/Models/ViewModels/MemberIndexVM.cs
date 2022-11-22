using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicWork.Models.ViewModels
{
    public class MemberIndexVM
    {
        public int mId { get; set; }
		[StringLength(50)]
		public string Name { get; set; }
		[StringLength(10)]
		public string IdentityNumber { get; set; }
		[StringLength(10)]
		public string PhoneNumber { get; set; }
        public DateTime ContractExpired { get; set; }
        public string ContractName { get; set; }
        public int Contract { get; set; }
        public string PhoneBrand { get; set; }
        public string PhoneModel { get; set; }


    }
    public class MemberVM:IValidatableObject
    {
        public int mId { get; set; }
		//[Required(ErrorMessage = "姓名必填")]
		//[StringLength(50)]

		public string Name { get; set; }
		//[Required(ErrorMessage = "身分證號碼必填")]
		//[StringLength(10)]

		public string IdentityNumber { get; set; }
		//[Required(ErrorMessage = "電話號碼必填")]
		//[StringLength(10)]
		public string PhoneNumber { get; set; }
		//[Required(ErrorMessage = "合約到期日必填")]

		public DateTime ContractExpired { get; set; }
        public string ContractName { get; set; }
        public int Contract { get; set; }
        public string PhoneBrand { get; set; }
        public string PhoneModel { get; set; }
        public int Contract_id { get; set; }
        public int Phone_id { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(Name)) yield return new ValidationResult("姓名必填", new string[] { "Name" });
            if (string.IsNullOrEmpty(IdentityNumber)) yield return new ValidationResult("身分證號碼必填", new string[] { "IdentityNumber" });
            if (string.IsNullOrEmpty(PhoneNumber)) yield return new ValidationResult("姓名必填", new string[] { "PhoneNumber" });
            //if (ContractExpired == new DateTime(1, 1, 1)) yield return new ValidationResult("合約到期日必填", new string[] { "ContractExpired" });
        }
    }
}
