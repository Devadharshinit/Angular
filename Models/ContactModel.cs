using System.ComponentModel.DataAnnotations;
namespace LOGINWEBAPI.models;

    public class ContactModel{
      
      [Key]
        public int SLno{get;set;}
        public string NameOfCustomer{get;set;}

       public string EmailId{get;set;}

       public string Message{get;set;}


        

    }