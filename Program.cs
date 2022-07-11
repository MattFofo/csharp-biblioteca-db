using csharp_biblioteca;


//init
User user1 = new User("Rossi", "Marco", "marcorossi@mail.com", "password", 333888554);
User user2 = new User("Bianco", "Marta", "biancomarta@mail.com", "password", 323857454);


Dvd dvd1 = new Dvd(1522548852, 90, "Matrix", 2000, "4D", true, 3, "qualcuno chenonricordo");
Dvd dvd2 = new Dvd(2392343871, 120, "Boh", 1998, "7D", true, 2, "qualcun'altro chenonricordo");

Book book1 = new Book(345, 0004450008, "La vita è altrove", 2002, "24C", true, 12, "Milan Kundera");
Book book2 = new Book(215, 0000071108, "La grammatica di dio", 2002, "35F", true, 3, "Stefano Benni");

List<Item> items = new List<Item>();
List<User> users = new List<User>();

items.Add(book1);
items.Add(book2);
items.Add(dvd1);
items.Add(dvd2);

users.Add(user1);
users.Add(user2);
///////////////////////////////////////////////////


Library library = new Library(users, items);

library.SearchItem("Ignoranza");
