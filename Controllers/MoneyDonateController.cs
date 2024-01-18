using LOGINWEBAPI.Context;
using LOGINWEBAPI.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Login.Controllers{

[ApiController]
[Route("[controller]")]

public class MoneyDonateController:ControllerBase{

    private readonly MoneyDonateDbContext MoneyDonateDbContexts;

    public MoneyDonateController(MoneyDonateDbContext MoneyDonateDbContext){

        this.MoneyDonateDbContexts=MoneyDonateDbContext;
    }

     [HttpGet]
    public async Task <IActionResult> GetDetail(){
          var Detail=await MoneyDonateDbContexts.MoneyDonates.ToListAsync();
          return Ok(Detail);
    }

    [HttpPost]
    public async Task <IActionResult> CreateProduct([FromBody] MoneyDonate pro )
    {     
        
         await MoneyDonateDbContexts.MoneyDonates.AddAsync(pro);
         await MoneyDonateDbContexts.SaveChangesAsync();
          return Ok(pro);
    }



    
}
}