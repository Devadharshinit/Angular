using System.ComponentModel.DataAnnotations;
namespace LOGINWEBAPI.models;

    public class ClothDonate{
      
      [Key]
        public int Id{get;set;}

        public string ClothName{get;set;}

        public string NameOfCustomer{get;set;}

        public string DateOfDonate{get;set;}

        public string PhoneNumber{get;set;}

        public string Address{get;set;}

    }