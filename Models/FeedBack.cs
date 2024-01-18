using System.ComponentModel.DataAnnotations;
namespace LOGINWEBAPI.models;

    public class FeedBack{
      
      [Key]
        public int SLno{get;set;}
        public string NameOfCustomer{get;set;}

       public string EmailId{get;set;}

       public string FeedBackDetails{get;set;}


        

    }