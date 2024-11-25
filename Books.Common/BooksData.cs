namespace Books.Common;

public static class BooksData
{
    public static List<Book> GetAllBooks()
    {
        List<Book> books = [];
        books.Add(new() { Id = "BU1032", Title = "The Busy Executive's Database Guide", Type = "business", Description = "An overview of available database systems with emphasis on common business applications. Illustrated.", Price = 19.99m, Author = "Green, Marjorie" });
        books.Add(new() { Id = "BU1111", Title = "Cooking with Computers: Surreptitious Balance Sheets", Type = "business", Description = "Helpful hints on how to use your electronic resources to the best advantage.", Price = 11.95m, Author = "O'Leary, Michael" });
        books.Add(new() { Id = "BU2075", Title = "You Can Combat Computer Stress!", Type = "business", Description = "The latest medical and psychological techniques for living with the electronic office. Easy-to-understand explanations.", Price = 2.99m, Author = "Green, Marjorie" });
        books.Add(new() { Id = "BU7832", Title = "Straight Talk About Computers", Type = "business", Description = "Annotated analysis of what computers can do for you: a no-hype guide for the critical user.", Price = 19.99m, Author = "Straight, Dean" });
        books.Add(new() { Id = "MC2222", Title = "Silicon Valley Gastronomic Treats", Type = "mod_cook", Description = "Favorite recipes for quick, easy, and elegant meals.", Price = 19.99m, Author = "del Castillo, Innes" });
        books.Add(new() { Id = "MC3021", Title = "The Gourmet Microwave", Type = "mod_cook", Description = "Traditional French gourmet recipes adapted for modern microwave cooking.", Price = 2.99m, Author = "DeFrance, Michel" });
        books.Add(new() { Id = "PC1035", Title = "But Is It User Friendly?", Type = "popular_comp", Description = "A survey of software for the naive user, focusing on the 'friendliness' of each.", Price = 22.95m, Author = "Carson, Cheryl" });
        books.Add(new() { Id = "PC8888", Title = "Secrets of Silicon Valley", Type = "popular_comp", Description = "Muckraking reporting on the world's largest computer hardware and software manufacturers.", Price = 20.00m, Author = "Dull, Ann" });
        books.Add(new() { Id = "PS1372", Title = "Computer Phobic AND Non-Phobic Individuals: Behavior Variations", Type = "psychology", Description = "A must for the specialist, this book examines the difference between those who hate and fear computers and those who don't.", Price = 21.59m, Author = "MacFeather, Stearns" });
        books.Add(new() { Id = "PS2091", Title = "Is Anger the Enemy?", Type = "psychology", Description = "Carefully researched study of the effects of strong emotions on the body. Metabolic charts included.", Price = 10.95m, Author = "Ringer, Anne" });
        books.Add(new() { Id = "PS2106", Title = "Life Without Fear", Type = "psychology", Description = "New exercise, meditation, and nutritional techniques that can reduce the shock of daily interactions. Popular audience. Sample menus included, exercise video available separately.", Price = 7.00m, Author = "Ringer, Albert" });
        books.Add(new() { Id = "PS3333", Title = "Prolonged Data Deprivation: Four Case Studies", Type = "psychology", Description = "What happens when the data runs dry?  Searching evaluations of information-shortage effects.", Price = 19.99m, Author = "White, Johnson" });
        books.Add(new() { Id = "PS7777", Title = "Emotional Security: A New Algorithm", Type = "psychology", Description = "Protecting yourself and your loved ones from undue emotional stress in the modern world. Use of computer and nutritional aids emphasized.", Price = 7.99m, Author = "Locksley, Charlene" });
        books.Add(new() { Id = "TC3218", Title = "Onions, Leeks, and Garlic: Cooking Secrets of the Mediterranean", Type = "trad_cook", Description = "Profusely illustrated in color, this makes a wonderful gift book for a cuisine-oriented friend.", Price = 20.95m, Author = "Panteley, Sylvia" });
        books.Add(new() { Id = "TC4203", Title = "Fifty Years in Buckingham Palace Kitchens", Type = "trad_cook", Description = "More anecdotes from the Queen's favorite cook describing life among English royalty. Recipes, techniques, tender vignettes.", Price = 11.95m, Author = "Blotchet-Halls, Reginald" });
        books.Add(new() { Id = "TC7777", Title = "Sushi, Anyone?", Type = "trad_cook", Description = "Detailed instructions on how to make authentic Japanese sushi in your spare time.", Price = 14.99m, Author = "O'Leary, Michael" });

        return books; 
    }
}
