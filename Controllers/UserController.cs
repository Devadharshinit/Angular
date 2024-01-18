using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LOGINWEBAPI.Context;
using LOGINWEBAPI.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Login.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController:ControllerBase{

    private readonly AppDbContext _authContext;
    public UserController(AppDbContext appDbContext)
    {
        _authContext=appDbContext;
    }
    [HttpPost("authenticate")]

public async Task<IActionResult>Authenticate([FromBody] user userObj){
    if(userObj ==null){
        return BadRequest();}

        var user=await _authContext.users.FirstOrDefaultAsync(x=>x.Username==userObj.Username && x.Password==userObj.Password);

    if(user==null) {
        return NotFound(new{Message="User not found"});
    }  
    
     user.Token= CreateJwtToken(user);
    
    return Ok(new{
        Token=user.Token,
        Message="login Successful!"

    });
}

    [HttpPost("register")]
    
    public async Task<IActionResult>RegisterUser([FromBody] user userObjt){

        if(userObjt==null)
             return BadRequest();

        await _authContext.users.AddAsync(userObjt);
        await _authContext.SaveChangesAsync();
        return Ok(new {

            Message="User Registered"


        });
    }

    private string CreateJwtToken(user users){

        var jwtTokenHandler=new JwtSecurityTokenHandler();

        var key=Encoding.ASCII.GetBytes("VeryVerysecret.....");

        var identity=new ClaimsIdentity(new Claim[]{

          new Claim(ClaimTypes.Role,users.Role),
          new Claim(ClaimTypes.Name,$"{users.Firstname} {users.Lastname}")
        });

        var credentials=new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

       var TokenDescriptor= new SecurityTokenDescriptor{

            Subject=identity,
            Expires=DateTime.Now.AddMinutes(10),

            SigningCredentials=credentials
            
        };
        var token=jwtTokenHandler.CreateToken(TokenDescriptor);

        return jwtTokenHandler.WriteToken(token);

    
    }

    [HttpGet]
    
    [Authorize]
    public async Task<ActionResult<user>> GetAllUser(){

        return Ok(await _authContext.users.ToListAsync());
    }
}
         


