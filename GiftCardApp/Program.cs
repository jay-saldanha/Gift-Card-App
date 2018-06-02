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
        public string UploadDate { get; set; }
        #endregion
    }
}
