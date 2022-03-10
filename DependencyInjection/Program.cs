using DependencyInjection;

ApplicationDbContext applicationDbContext = new ApplicationDbContext();
user user = new user(applicationDbContext);
user.show();
