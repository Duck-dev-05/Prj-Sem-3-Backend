namespace JamesThew.Model
{
    public class Recipe 
    {
        public required int Id {get;set;}
        public required string Title {get;set;}
        public required string Ingredients {get;set;}
        public required string Procedure {get;set;}
        public required bool IsFree {get;set;}
    }
}