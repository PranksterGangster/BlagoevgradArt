﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BlagoevgradArt.Infrastructure.Constants.DataConstants;

namespace BlagoevgradArt.Infrastructure.Data.Models
{
    /// <summary>
    /// The gallery entity class.
    /// </summary>
    [Index(nameof(PhoneNumber), IsUnique = true)]
    public class Gallery
    {
        /// <summary>
        /// Gallery unique identifier.
        /// </summary>
        [Key]
        [Comment("Gallery unique identifier. | Уникален идентификатор на галерията.")]
        public int Id { get; set; }

        /// <summary>
        /// User unique identifier.
        /// </summary>
        [Required]
        [Comment("User unique identifier. | Уникален идентификатор на потребителя.")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Navigation property to the helper IdentityUser class.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public GalleryHelperUser User { get; set; } = null!;

        /// <summary>
        /// Name of the gallery.
        /// </summary>
        [Required]
        [MaxLength(GalleryNameMaxLength)]
        [Comment("Name of the gallery. | Име на галерията.")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Address of the gallery.
        /// </summary>
        [Required]
        [MaxLength(GalleryAddressMaxLength)]
        [Comment("Address of the gallery. | Адрес на галерията.")]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Working time of the gallery.
        /// </summary>
        [Required]
        [MaxLength(GalleryWorkingTimeMaxLength)]
        [Comment("Working time of the gallery. | Работно време на галерията.")]
        public string WorkingTime { get; set; } = string.Empty;

        /// <summary>
        /// Gallery's phone number.
        /// </summary>
        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        [Comment("Gallery's phone number. | Телефонен номер на галерията.")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Path to the gallery's main image.
        /// </summary>
        [MaxLength(ImagePathMaxLength)]
        [Comment("File path to the gallery's main image. | Файлов път до главната снимка на галерията.")]
        public string? MainImage { get; set; }

        /// <summary>
        /// Description of the gallery.
        /// </summary>
        [Required]
        [MaxLength(GalleryDescriptionMaxLength)]
        [Comment("Description of the gallery. | Описание на галерията.")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// List of exhibitions in the gallery.
        /// </summary>
        public List<Exhibition> Exhibitions { get; set; } = new List<Exhibition>();
    }
}
