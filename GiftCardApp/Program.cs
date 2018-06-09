using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCardApp
/// <summary>
/// Gift card application
/// </summary>
{
    class GiftCardDetails
    {
        #region Properties
        /// <summary>
        /// The unique identification numberr of a gift card
        /// </summary>
        public int GiftCardNumber { get; set; }
        /// <summary>
        /// The PIN number corresponding to that gift card
        /// </summary>
        public int PIN { get; set; }
        /// <summary>
        /// The balance amount in the gift card
        /// </summary>
        public Decimal Balance { get; set; }
        /// <summary>
        /// The name of the store or provider of the gift card
        /// </summary>
        public String ProviderName { get; set; }
        /// <summary>
        /// the date when the gift card was uploaded in the app
        /// </summary>
        public DateTime UploadDate { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add amount to gift card to find new value
        /// </summary>
        /// <param name="amount">new amount in gift card</param>
        /// <returns>the balance amount</returns>
        public decimal NewValue(decimal amount)
        {
            Balance += amount;
            return Balance;
        }
        /// <summary>
        /// Use the amount in the gift card and find the balance
        /// </summary>
        /// <param name="amount">new amount in gift card</param>
        /// <returns>the new balance after the gift card is swiped </returns>
        public decimal NewBalance(decimal amount)
        {
            Balance -= amount;

        }
        #endregion
    }

} 