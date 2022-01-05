using System.ComponentModel;

namespace Http_Verbs.Controllers

    public class Person
    {
                /// <summary>
                /// Id defines unique identity number for each person
                /// </summary>
       
        public int Id { get; set; } = 0;

                /// <summary>
                /// FirstName defines Name of each person
                /// </summary>
        
        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string FirstName { get; set; } = "";

                /// <summary>
                /// LastName defines LastName of each person
                /// </summary>
       
        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string LastName { get; set; } = "";
    }
}