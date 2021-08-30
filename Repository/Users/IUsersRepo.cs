using System;
using System.Collections.Generic;
using UsersViewer.Repository.DTO;

namespace UsersViewer.Repository.Users
{
    public interface IUsersRepo
    {
        IEnumerable<UserReadDto> GetUsers();
        UserReadDto GetUserById(Int64 userID);
        IEnumerable<UserReadDto> DeleteUser(Int64 userID);
        IEnumerable<UserReadDto> CreateUser(UserWriteDto newUser);
        Boolean EditUser(UserReadDto editedUser);
    }
}
