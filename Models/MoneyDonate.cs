using System.ComponentModel.DataAnnotations;
namespace LOGINWEBAPI.models;

    public class MoneyDonate{
      
      [Key]
        public int Id{get;set;}

        public string Amount{get;set;}

        public string NameOfCustomer{get;set;}

        

    }