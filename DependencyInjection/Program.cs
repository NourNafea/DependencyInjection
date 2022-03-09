using DependencyInjection;

ApplicationDbContext applicationDbContext = new ApplicationDbContext();
user user1 = new user(applicationDbContext);
user1.show();
