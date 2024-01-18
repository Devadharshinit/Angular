using LOGINWEBAPI.Context;
using LOGINWEBAPI.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Login.Controllers{

[ApiController]
[Route("[controller]")]

public class FoodDonateController:ControllerBase{

    private readonly FoodDonateDbContext FoodDonateDbContexts;

    public FoodDonateController(FoodDonateDbContext foodDonateDbContext){

        this.FoodDonateDbContexts=foodDonateDbContext;
    }

     [HttpGet]
    public async Task <IActionResult> GetDetail(){
          var Detail=await FoodDonateDbContexts.foodDonates.ToListAsync();
          return Ok(Detail);
    }

    [HttpPost]
    public async Task <IActionResult> CreateProduct([FromBody] FoodDonate pro )
    {     
        
         await FoodDonateDbContexts.foodDonates.AddAsync(pro);
         await FoodDonateDbContexts.SaveChangesAsync();
          return Ok(pro);
    }



    
}
}