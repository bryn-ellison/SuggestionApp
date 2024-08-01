using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SuggestionAppUI.Models;

public class CreateSuggestionModel
{
    [Required]
    [MaxLength(75)]
    public string Suggestion { get; set; }
    [MinLength(1)]
    [DisplayName("Category")]
    public string CategoryId { get; set; }
    [MaxLength(500)]
    public string Description { get; set; }

}
