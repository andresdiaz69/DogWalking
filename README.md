# ECI Dog Walking App

### What do you need?

- .NET 8
- SQL Server

### Initial Configuration

1. Clone the repo:

``` console
git clone https://github.com/andresdiaz69/DogWalking.git
```

2. Update connection string:

	- Locate the file "1. ECI.Presentation/ECI.DogWalking/Program.cs"
	- Locate Main method and update the connection string

``` c#
services.AddDbContext<AppDbContext>(options =>
		options.UseSqlServer("Server=MIPCHP;Database=ECI_DogWalks;Trusted_Connection=True;TrustServerCertificate=True;"));
```

3. Apply migrations and create the database

	Run the next command in the root project folder, in order to create the "ECI_DogWalks" Data Base in your local machine.

``` console
dotnet ef database update --project "3. ECI.Data/ECI.Data/ECI.DataRepository.csproj"
```

> [!caution]
> By default will be created a record in the User Table:
> 
> Username (Email): admin@eci.com
> Password: admin
> 
> 
> Also a couple of records in the Breed Table

4. Exec the app

	Open "ECI.DogWalking.sln" file in visual studio and press "F5"

5. Explore the app:

	In the app you will be able to:
	- Client Form: Create, update clients and create their "Dogs".
	- Walk Form: Create, update and delete "Walks".
