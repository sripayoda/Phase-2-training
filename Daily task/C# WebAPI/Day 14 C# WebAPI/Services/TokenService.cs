﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuth.Services
{
    public class TokenService : IToken
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(string username, string role)
        {
            var jwtSettings = _configuration.GetSection("JwtSetting");
            //var secretKey = Encoding.UTF8.GetBytes("Token Key");
            //var secretKey = Encoding.UTF8.GetBytes(_configuration["JwtSettings:Token Key"]);
            var secretKey = Encoding.ASCII.GetBytes("I love Tommy and..........");

            var issuer = jwtSettings["Issuer"];
            //var audience = jwtSettings["Auidence"];
            // expire details

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, username),
                //new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, role)
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                //Expires = expires,
                Issuer = issuer,
                //Audience = audiencs,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(secretKey),
                    SecurityAlgorithms.HmacSha512Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            //SecurityToken token = tokenHandler.CreateToken(tokenDescriptor); 

            return tokenHandler.WriteToken(token);
        }
    }
}
