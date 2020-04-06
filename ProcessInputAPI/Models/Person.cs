#region Using namespace

using System.ComponentModel.DataAnnotations;

#endregion

#region Namespace

/// <summary>
/// Process input api models
/// </summary>
namespace ProcessInputAPI.Models
{
    #region Public Person class

    /// <summary>
    /// Person model class
    /// </summary>
    public class Person
    {
        #region Public properties

        /// <summary>
        /// Public property name
        /// </summary>
        [MaxLength(50)]
        [Required(ErrorMessage = "Person name is required")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Use letters only")]
        public string Name { get; set; }

        /// <summary>
        /// Public property amount
        /// </summary>
        [MaxLength(13)]
        [Required(ErrorMessage = "Amount is required")]
        [RegularExpression(@"^(0|-?\d{0,16}(\.\d{0,2})?)$", ErrorMessage = "Enter number for example 123.45")]
        public string Amount { get; set; }

        /// <summary>
        /// Public property amount in word
        /// </summary>
        public string AmountInWord { get; set; }

        #endregion
    }

    #endregion
}

#endregion
