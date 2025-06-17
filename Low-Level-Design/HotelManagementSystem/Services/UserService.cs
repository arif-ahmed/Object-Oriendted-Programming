using HotelManagementSystem.Contracts;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _userRepository.GetByIdAsync(id);
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        var users = await _userRepository.Filter(user => user.Email == email);
        return users.First(); 
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _userRepository.GetAllAsync();
    }
    public async Task AddUserAsync(User user)
    {
        await _userRepository.AddAsync(user);
    }
    public async Task UpdateUserAsync(User user)
    {
        await _userRepository.UpdateAsync(user);
    }
    public async Task DeleteUserAsync(int id)
    {
        await _userRepository.DeleteAsync(id);
    }
}
