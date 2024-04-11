﻿using System.ComponentModel.DataAnnotations;
using static BlagoevgradArt.Core.Constants.ErrorMessages;
using static BlagoevgradArt.Infrastructure.Constants.DataConstants;

namespace BlagoevgradArt.Core.Models.Painting
{
    /// <summary>
    /// ViewModel DTO for the Image form data.
    /// </summary>
    public class PaintingFormModel
    {
        /// <summary>
        /// Title of the painting.
        /// </summary>
        [Required]
        [StringLength(TitleMaxLength,
            MinimumLength = TitleMinLength,
            ErrorMessage = InvalidLength)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the painting's author.
        /// </summary>
        [Required]
        public int AuthorId { get; set; }

        /// <summary>
        /// Year of finishing the painting.
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        /// Unique identifier of the painting's genre.
        /// </summary>
        [Required]
        public int GenreId { get; set; }

        public IEnumerable<GenreViewModel> Genres = new List<GenreViewModel>();

        /// <summary>
        /// Unique identifier of the painting's art type.
        /// </summary>
        [Required]
        public int ArtTypeId { get; set; }

        public IEnumerable<BaseTypeViewModel> ArtTypes = new List<BaseTypeViewModel>();

        /// <summary>
        /// Unique identifier of the painting's base type.
        /// </summary>
        [Required]
        public int BaseTypeId { get; set; }

        /// <summary>
        /// List of all available base types.
        /// </summary>
        public IEnumerable<BaseTypeViewModel> BaseTypes = new List<BaseTypeViewModel>();

        /// <summary>
        /// List of the selected material IDs.
        /// </summary>
        public IEnumerable<int> SelectedMaterialIds = new List<int>();

        /// <summary>
        /// List of all available materials.
        /// </summary>
        public IEnumerable<MaterialViewModel> Materials { get; set; } = new List<MaterialViewModel>();

        /// <summary>
        /// Description of the painting.
        /// </summary>
        [StringLength(ImageDescriptionMaxLength,
            MinimumLength = ImageDescriptionMinLength,
            ErrorMessage = InvalidLength)]
        public string? Description { get; set; }

        /// <summary>
        /// Height of the painting in centimeters.
        /// </summary>
        [Required]
        [Range(HeightCmMinValue,
            HeightCmMaxValue,
            ErrorMessage = DimensionsInvalidValue)]
        public int HeightCm { get; set; }

        /// <summary>
        /// Width of the painting in centimeters;
        /// </summary>
        [Required]
        [Range(WidthCmMinValue,
            WidthCmMaxValue,
            ErrorMessage = DimensionsInvalidValue)]
        public int WidthCm { get; set; }

        /// <summary>
        /// Physical availability of the painting.
        /// </summary>
        [Required]
        public bool IsAvailable { get; set; }
    }
}
