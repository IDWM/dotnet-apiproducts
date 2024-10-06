# Dotnet 8 API with Cloudinary Integration

## Setup Instructions

### 1. Install Dotnet SDK 8
Download and install the Dotnet 8 SDK from the official site: [Dotnet8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
Additionally, make sure you have Postman and a Cloudinary account set up.

### 2. Clone the Repository
```terminal
$ git clone https://github.com/GuillermoFA/ayudantia01.git
```

### 3. Navigate to the API Directory
```terminal
$ cd api
```

### 4. Restore Dependencies
```terminal
$ dotnet restore
```

### 5. Ensure the Database is Operational (Optional)
Run the following command to confirm that the database is set up:
```terminal
$ dotnet ef database update
```

### 6. Run the Application
```terminal
$ dotnet run
```

### Note
Make sure to add your Cloudinary credentials to `appsettings.json` before running the project:

Replace `your_cloud_name`, `your_api_key`, and `your_api_secret` with the credentials from your Cloudinary account.

### Postman Collection
You can find the Postman collection for this project here: [Postman Collection](#)

### Cloudinary Account
Create or manage your Cloudinary account here: [Cloudinary](https://cloudinary.com/)
