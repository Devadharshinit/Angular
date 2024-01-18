using LOGINWEBAPI.Context;
using LOGINWEBAPI.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Login.Controllers{

[ApiController]
[Route("[controller]")]

public class FeedBackController:ControllerBase{

    private readonly FeedBackDbContext FeedBackDbContexts;

    public FeedBackController(FeedBackDbContext feedBackDbContext){

        this.FeedBackDbContexts=feedBackDbContext;
    }
     
     [HttpGet]
    public async Task <IActionResult> GetDetail(){
          var Detail=await FeedBackDbContexts.feedBacks.ToListAsync();
          return Ok(Detail);
    }

    [HttpPost]
    public async Task <IActionResult> CreateProduct([FromBody] FeedBack pro )
    {     
        
         await FeedBackDbContexts.feedBacks.AddAsync(pro);
         await FeedBackDbContexts.SaveChangesAsync();
          return Ok(pro);
    }



    
}
}