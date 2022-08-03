using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUserAccount
{
    /// <summary>
    /// Represents a individual user's account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Creates an account with the specific user, and has hours and books of 0
        /// </summary>
        /// <param name="userName">The user's name who owns the account</param>
        public Account(string userName)
        {
            UserName = userName;
        }
        /// <summary>
        /// The user's name of the account.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The amount of books that the user has read.
        /// </summary>
        public int Books { get; private set; }

        /// <summary>
        /// The amount of hours that the user spent reading.
        /// </summary>
        public int Hours { get; private set; }

        /// <summary>
        /// Add a specified amount of books to the user's account
        /// </summary>
        /// <param name="amtbooks">The positive amount to 
        /// number of books read</param>
        /// <returns>The new amount of books read after deposit</returns>
        public int DepositBooks(int amtbooks)
        {
            if (amtbooks <= 0)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(amtbooks)} must be more than 0");
            }
            Books += amtbooks;
            return Books;
        }

        /// <summary>
        /// Add a specified amount of hours spent reading to the user's account
        /// </summary>
        /// <param name="amthours">The positive amount to 
        /// number of hours spent reading</param>
        /// <returns>The new amount of hours spent reading</returns>
        public int DepositHours(int amthours)
        {
            if (amthours <= 0)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(amthours)} must be more than 0");
            }
            Hours += amthours;
            return Hours;
        }
    }
}
