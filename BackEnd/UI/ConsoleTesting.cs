using System.Collections.Generic;
using BL;
using Models;

namespace UI
{
    public class ConsoleTesting
    {
        
        IUserBL _userBL;

        public ConsoleTesting(IUserBL p_userBL)
        {
            _userBL=p_userBL;
        }

        public  User TestAdd()
        {
            return _userBL.AddUser( new User()
            {
                UserName = "name",
                UserPass = "password",
                Email = "mail@mail.com"
            });
        }

        public User AuthAddTest(string p_email)
        {
           return _userBL.AddUserFromAuth0(p_email);
        }
        public List<User> TestShowAll()
        {
            return _userBL.GetAllUsers();
        }

        public List<User> TestGetByName(string p_name)
        {
            return _userBL.GetUserByName(p_name);
        }


        public User TestGetByID(int p_ID)
        {
            return _userBL.GetUserById(p_ID);
        }


        public User TestDeleteUser(int p_user_Id)
        {
            return _userBL.DeleteUser(p_user_Id);
        }

        public User TestGetByEmail(string p_email)
        {
            return _userBL.GetUserByEmail(p_email);
        }
    }
}