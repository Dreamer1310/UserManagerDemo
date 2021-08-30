using System;
using System.Collections.Generic;
using System.Linq;
using UsersViewer.Models.DB;
using UsersViewer.Repository.DTO;

namespace UsersViewer.Repository.Users
{
    public class MyUsersRepo : IUsersRepo
    {
        private readonly UsersDBDataContext _context;

        public MyUsersRepo()
        {
            _context = new UsersDBDataContext();
        }

        public IEnumerable<UserReadDto> CreateUser(UserWriteDto newUser)
        {
            var userToCreate = new User
            {
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Email = newUser.Email,
                Description = newUser.Description,
                Picture = newUser.Image,
                PositionID = newUser.PositionID
            };
            _context.Users.InsertOnSubmit(userToCreate);
            _context.SubmitChanges();

            return GetUsers();
        }

        public IEnumerable<UserReadDto> DeleteUser(Int64 userID)
        {
            var users = _context.Users;
            var userToDelete = users.FirstOrDefault(x => x.ID == userID);

            if (userToDelete == null) throw new Exception("Tried delete invalid user. --MyUserRepo.DeleteUser");
            users.DeleteOnSubmit(userToDelete);
            _context.SubmitChanges();

            return users.Select(x => new UserReadDto
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Description = x.Description,
                PositionID = x.PositionID,
                Image = x.Picture.ToArray()
            });
        }

        public Boolean EditUser(UserReadDto editedUser)
        {
            var user = _context.Users.FirstOrDefault(x => x.ID == editedUser.ID);

            if (user == null) throw new Exception("Invalid User Edited. --MyUserRepo.EditUser");

            user.FirstName = editedUser.FirstName;
            user.LastName = editedUser.LastName;
            user.Email = editedUser.Email;
            user.Description = editedUser.Description;
            user.Picture = editedUser.Image;
            user.PositionID = editedUser.PositionID;

            _context.SubmitChanges();
            return true;
        }

        public UserReadDto GetUserById(Int64 userID)
        {
            var user = _context.Users.FirstOrDefault(x => x.ID == userID);
            UserReadDto userDto = null;

            if (user != null)
            {
                userDto = new UserReadDto
                {
                    ID = user.ID,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Description = user.Description,
                    PositionID = user.PositionID,
                    Image = user.Picture.ToArray()
                };
                
            } else
            {
                throw new Exception("Tried get invalid ID. --MyUserRepo.GetUserByID");
            }

            return userDto;
        }

        public IEnumerable<UserReadDto> GetUsers()
        {
            return _context.Users.Select(x => new UserReadDto
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Description = x.Description,
                PositionID = x.PositionID,
                Image = x.Picture.ToArray()
            });
        }

        public void Dispose()
        {
            Dispose();
            _context.Dispose();
        }
    }
}