using System.Collections.Generic;
using Models;

namespace BL
{
    public interface IUserBL
    {
        /// <summary>
        /// will return a list of Users
        /// </summary>
        /// <returns></returns>
        List<User> GetAllUsers();

        /// <summary>
        /// Adds passed user to the database
        /// </summary>
        /// <param name="_Users"></param>
        /// <returns>added user</returns>
        User AddUser(User _Users);

        /// <summary>
        /// add user if not in Db when loged in with auth0
        /// </summary>
        /// <param name="_email"></param>
        /// <returns></returns>
        User AddUserFromAuth0(string _email);

        /// <summary>
        /// return a list of users with names matching the passed string
        /// </summary>
        /// <param name="_name"></param>
        /// <returns></returns>
        List<User> GetUserByName(string _name);

        /// <summary>
        /// modify the current user info with the passed info (exept email)
        /// </summary>
        /// <param name="_User"></param>
        /// <returns></returns>
        User UpdateUser(User _User);

        /// <summary>
        /// return the user with an ID matching the passed Int
        /// </summary>
        /// <param name="p_Id"></param>
        /// <returns></returns>
        User GetUserById(int _Id);

        /// <summary>
        /// returns the user with an email matching the passed string
        /// </summary>
        /// <param name="_email"></param>
        /// <returns></returns>
        User GetUserByEmail(string _email);

        /// <summary>
        /// removes the passed user obj from the DB
        /// </summary>
        /// <param name="p_user"></param>
        /// <returns>removed User</returns>
        User DeleteUser(int _user_Id);
    }
}