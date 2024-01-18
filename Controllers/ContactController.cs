using LOGINWEBAPI.Context;
using LOGINWEBAPI.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contact.Controllers{

[ApiController]
[Route("[controller]")]

public class ContactController:ControllerBase{

    private readonly ContactDbContext ContactDbContexts;

    public ContactController(ContactDbContext contactDbContext){

        this.ContactDbContexts=contactDbContext;
    }
     
     [HttpGet]
    public async Task <IActionResult> GetDetail(){
          var Detail=await ContactDbContexts.contactModels.ToListAsync();
          return Ok(Detail);
    }

    [HttpPost]
    public async Task <IActionResult> CreateProduct([FromBody] ContactModel pro )
    {     
        
         await ContactDbContexts.contactModels.AddAsync(pro);
         await ContactDbContexts.SaveChangesAsync();
          return Ok(pro);
    }



    
}
}