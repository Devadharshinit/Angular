using System.ComponentModel.DataAnnotations;
namespace LOGINWEBAPI.models;

    public class FoodDonate{
      
      [Key]
        public int Id{get;set;}

        public string FoodName{get;set;}

        public string NameOfCustomer{get;set;}

        public string DateOfDonate{get;set;}

        public string PhoneNumber{get;set;}

        public string Address{get;set;}

    }
