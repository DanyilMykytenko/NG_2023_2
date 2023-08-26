using AutoMapper;
using BLL.Models;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;

namespace WebAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("newUser")]
        public async Task<IActionResult> newUser(UserDto user)
        {
            var mappedUser = _mapper.Map<UserModel>(user);
            await _userService.AddUserAsync(mappedUser);
            return Ok();
        }

        [HttpPut("updateUser")]
        public async Task<IActionResult> updateUser(int id, UserDto user)
        {
            var mappedUser = _mapper.Map<UserModel>(user);
            //_mapper.Map(mappedUser, user);
            await _userService.UpdateUserAsync(mappedUser, id);
            return Ok();
        }

        [HttpDelete("deleteUser")]
        public async Task<IActionResult> deleteUser(int id)
        {
            await _userService.DeleteUserAsync(id);
            return Ok();
        }

        [HttpGet("getAllUsers")]
        public async Task<IActionResult> AllUsers()
        {
            var allUsers = _userService.GetAllUsers();
            var users = _mapper.Map<IEnumerable<UserDto>>(allUsers);
            return Ok(users);
        }

        [HttpGet("getUserById")]
        public async Task<IActionResult> getUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            var mappedUser = _mapper.Map<UserDto>(user);
            return Ok(mappedUser);
        }
    }
}
