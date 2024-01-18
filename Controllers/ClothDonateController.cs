using LOGINWEBAPI.Context;
using LOGINWEBAPI.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Login.Controllers{

[ApiController]
[Route("[controller]")]

public class ClothDonateController:ControllerBase{

    private readonly ClothDonateDbContext ClothDonateDbContexts;

    public ClothDonateController(ClothDonateDbContext clothDonateDbContext){

        this.ClothDonateDbContexts=clothDonateDbContext;
    }

     [HttpGet]
    public async Task <IActionResult> GetDetail(){
          var Detail=await ClothDonateDbContexts.clothDonates.ToListAsync();
          return Ok(Detail);
    }

    [HttpPost]
    public async Task <IActionResult> CreateProduct([FromBody] ClothDonate pro )
    {     
        
         await ClothDonateDbContexts.clothDonates.AddAsync(pro);
         await ClothDonateDbContexts.SaveChangesAsync();
          return Ok(pro);
    }



    
}
}