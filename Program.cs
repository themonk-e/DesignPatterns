// See https://aka.ms/new-console-template for more information
//using designPattern.Builder;
using designPattern.Factory;
using designPatterns;
using designPatterns.problem;
using designPattern.AbstractFactory;
using designPattern.Prototype;
using designPattern.Structural.Adapter;
using designPattern.Structural.Bridge;
using designPattern.Structural.Decorator;
using designPattern.Structural.Facade;
using designPattern.Structural.Composite;
using designPattern.Structural.Proxy;
using designPattern.Structural.Flyweight;
using designPattern.Behavioural.Iterator;
using designPattern.Behavioural.Observer;
using designPattern.Behavioural.Strategy;

Console.WriteLine("Hello, World!");

//EagerLoading
// Singleton obj1 = Singleton.getInstance();
// Singleton obj2 = Singleton.getInstance();


// //lazy loading

// SingletonLazy lzSingleton = SingletonLazy.INSTANCE;
// SingletonLazy lzSingleton2 = SingletonLazy.INSTANCE;

// Console.WriteLine(lzSingleton.incrementCount());
// Console.WriteLine(lzSingleton2.incrementCount());

// Logger service1 = Logger.getInstance();
// Logger service2 = Logger.getInstance();

// service1.AddToLog("Instance created for the firstTime");
// var listOfLogs=service2.AddToLog("Already created instance has been returned");

// foreach (string log in listOfLogs)
// {
//     Console.WriteLine(log);
// }


// //Factory

// var factory = new NotificationFactory();

// INotificationService email = factory.CreateNotification(Channel.email);
// email.SendNotification("Welcome to the system!");

// INotificationService sms = factory.CreateNotification(Channel.sms);
// sms.SendNotification("Your OTP is 123456");



//Builder

// User userObj = new User.UserBuilder("John", "Doe")
// .WithEmail("johndoe@gmail.com")
// .WithPhone("9199199991").Build();

// Console.WriteLine(userObj.FirstName);
// Console.WriteLine(userObj.LastName);
// Console.WriteLine(userObj.Email);
// Console.WriteLine(userObj.Phone);

//Abstract Factory

// IGUIFactory windowsFactory= new WindowsFactory();
// IButton  windowsButton = windowsFactory.CreateButton();
// ICheckBox windowsCheckBox= windowsFactory.CreateCheckBox();

// windowsButton.Render();
// windowsCheckBox.Render();


//Prototype
// IDocument legalDocument = DocTemplateRegistry.GetDocumentTemplate("LegalDocument");
// legalDocument.printDocument();
// Console.WriteLine();

// IDocument invoice = DocTemplateRegistry.GetDocumentTemplate("Invoice");
// invoice.printDocument();
// Console.WriteLine();

// IDocument CivillegalDocument = DocTemplateRegistry.GetDocumentTemplate("LegalDocument");
// CivillegalDocument.createDocument(Title: "Land Problem Notice",
//  Content: "This notice is to condemn about the encroachment of footpath",
//  Author: "Suresh LLB",
//  DocFormatting: new Formatting() { Color = "Black", Font = "Segou", FontSize = 2 }
//  );

// CivillegalDocument.printDocument();
// Console.WriteLine();
// legalDocument.printDocument();


//Structural

//Adapter
// DocumentViwerApp documentViwerOld = new DocumentViwerApp(new PDFViewer());
// documentViwerOld.DisplayDoc("desginPatterns.pdf");

// DocumentViwerApp documentViwerNew = new DocumentViwerApp(new WordReaderAdapter());
// documentViwerNew.DisplayDoc("designPatterns.docx");



//Bridge
// Notification alertNotificationEmail = new AlertNotification(new EmailChannel());
// alertNotificationEmail.SendMessage("Plan Expired");

// Notification alertNotificationSMS = new AlertNotification(new SMSChannel());
// alertNotificationSMS.SendMessage("Plan Expired");

// Notification ReminderNotificationEmail = new ReminderNotification(new EmailChannel());
// ReminderNotificationEmail.SendMessage("Plan will expire in 2 days");

// Notification ReminderNotificationSMS = new ReminderNotification(new SMSChannel());
// ReminderNotificationSMS.SendMessage("Plan will expire in 2 days");

// //New requirement to send whatsapp notification

// Notification alertNotificationWhatsapp = new AlertNotification(new WhatsappChannel());
// alertNotificationWhatsapp.SendMessage("Plan Expired");

// Notification ReminderNotificationWhatsapp = new ReminderNotification(new WhatsappChannel());
// ReminderNotificationWhatsapp.SendMessage("Plan will expire in 2 days");

//Decorator
// IStorage storage = new Storage("data.txt");
// storage = new CompressionStorageDecorator(storage);
// storage = new EncryptionStorageDecorator(storage);

// storage.Store("Design Patterns are powerful!");

// storage.Retrieve();


//Facade

// VideoStreamingFacade videoStreamingFacade = new VideoStreamingFacade(new LoselessVideoCompressor(),
// new AudioProcessor320KBPS(),
// new MP4320KBPSVideoStreamer(),
// new MP4VideoReader());

// videoStreamingFacade.StreamVideo("designPatternsMastery.MV");

//Composite

// // Create files
// FileItem report = new FileItem("Report.docx");
// FileItem data = new FileItem("Data.csv");

// // Create folder and add files
// Folder projectFolder = new Folder("Project");
// projectFolder.Add(report);
// projectFolder.Add(data);

// Folder root = new Folder("Root");
// root.Add(projectFolder);
// root.Add(new FileItem("Readme.txt"));

// // Apply permissions
// root.AddPermission("Read");
// projectFolder.AddPermission("Write");
// root.DisplayProperties();

// User admin = new User("Alice", "admin");
// User guest = new User("Bob", "guest");
// User manager = new User("Mahe", "manager");

// IDocumentReader report = new ProxyDocumentReader("Report.docx", "John", "Editor");

// // Guest tries to open
// report.Open(guest);


// // Admin tries to open
// report.Open(admin);

// report.Open(manager);

//Flyweight

// Player warriorPlayer1 = new Player("Mahesh",
//                                  FlyweightCharacterFactory.GetCharacter("Warrior3DMesh-SmoothTexture-SwirlAnimation"),
//                                  100,
//                                  100,
//                                  900
//                                  );


// Player warriorPlayer2 = new Player("Trevor",
//                                  FlyweightCharacterFactory.GetCharacter("Warrior3DMesh-SmoothTexture-SwirlAnimation"),
//                                  90,
//                                  20,
//                                  500
//                                  );

// warriorPlayer1.CreatePlayer();
// warriorPlayer2.CreatePlayer();

//Behavioural
//Iterator

// Playlist playlist = new Playlist();

// playlist.AddSong(new Song("Lose Yourself", "Eminem",320));
// playlist.AddSong(new Song("Blinding Lights", "The Weeknd", 200));
// playlist.AddSong(new Song("Shape of You", "Ed Sheeran", 250));

// IIterator normalIterator = playlist.CreateNormalIterator();
// Console.WriteLine("Normal Order:");
// while (normalIterator.HasNext())
// {
//     var song = normalIterator.Next();
//     Console.WriteLine($"{song.Title} - {song.Artist}");
// }


// IIterator shuffleIterator = playlist.CreateShuffleIterator();
// Console.WriteLine("\nShuffle Order:");
// while (shuffleIterator.HasNext())
// {
//     var song = shuffleIterator.Next();
//     Console.WriteLine($"{song.Title} - {song.Artist}");
// }

//observer

// IStock Tesla = new Stock("Tesla", 100);

// IInvestor Bob = new Investor("Bob");
// IInvestor Alice = new Investor("Alice");
// IInvestor Charlie = new Investor("Charlie");

// Bob.Buy(Tesla);
// Alice.Buy(Tesla);
// Charlie.Buy(Tesla);

// Tesla.ChangePrice(105);

// Bob.Sell(Tesla);

// Tesla.ChangePrice(110);

//Strategy

Editor editor = new Editor();
editor.SetLanguage("English");
editor.CheckSpelling("Hello");

editor.SetLanguage("French");
editor.CheckSpelling("Bonjour");

