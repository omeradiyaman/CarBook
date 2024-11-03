# CarBook Project

CarBook is a car rental application built with ASP.NET Core, utilizing a robust architecture and various modern technologies. This project aims to provide a seamless experience for users looking to rent vehicles, while ensuring secure and efficient management for administrators.

## Key Learnings
"First of all, I learned how to write clean code, including separating services effectively. I also gained knowledge about using areas for managing multiple MVC applications. Additionally, I learned how to manage projects more efficiently.

## Technologies Used

- ASP.NET Core: The main framework for building the API.
- MS SQL: The relational database management system used for data storage.
- CQRS (Command Query Responsibility Segregation): A pattern implemented to separate the reading and writing of data.
- Mediator Pattern: Used to simplify communication between objects in the application.
- Repository Pattern: Ensures separation of data access logic from business logic.
- JWT Bearer Authentication: Provides secure token-based authentication for users.
- Entity Framework Core: An ORM framework used for database interactions.
- Fluent Validation: For model validation.
- Onion Architecture: Applied to maintain a clean and maintainable project structure.
- API: Designed to handle all operations related to car rentals, user management, and admin functions.
- Swagger: Integrated for interactive API documentation, allowing exploration and testing of the API endpoints.
- Postman: Recommended for testing and interacting with the CarBook API.
  
## Features

- User Registration: Users can create an account to access the system.
- Admin Area: Admin users have access to exclusive features, while non-admin users receive a 403 Forbidden error when attempting to access admin pages.
- Secure Login: JWT authentication is utilized to secure user sessions.
- Clean Code Practices: The project follows best practices for maintainability and readability, making it easier to understand and extend.
  
## Frontend

- HTML: For structuring the web pages.
- CSS (Bootstrap): Used for styling the application and ensuring a responsive design. Bootstrap provides pre-built components and a grid system, allowing for a consistent and visually appealing user interface across different devices.
- JavaScript: For adding interactive features to the web pages.

## Configuration

The application’s settings are managed through `appsettings.json`, and the configuration is structured in `Program.cs` to enhance clarity and maintainability.
### Authorization

All admin area routes are protected, ensuring that unauthorized users cannot access sensitive information or features.


## Dashboard
![Ekran görüntüsü 2024-11-03 153721](https://github.com/user-attachments/assets/0b9e07ba-9ea4-4b02-ab64-dd48cab85e8b)
![Ekran görüntüsü 2024-11-03 153824](https://github.com/user-attachments/assets/87a8e8c0-8690-4141-ae9b-85dfccc3aa4d)
![Ekran görüntüsü 2024-11-03 153841](https://github.com/user-attachments/assets/9555d6a1-7017-4cff-af5d-5d06f53793f3)
![Ekran görüntüsü 2024-11-03 153918](https://github.com/user-attachments/assets/f60863b9-7ee8-4749-b3dd-8247f06d8b4f)
![Ekran görüntüsü 2024-11-03 153925](https://github.com/user-attachments/assets/d0d732f6-8e5d-4d44-86fe-4ccdfef1961d)
![Ekran görüntüsü 2024-11-03 154029](https://github.com/user-attachments/assets/e34cc75a-6df1-4005-899b-40808bfbeaa6)
![Ekran görüntüsü 2024-11-03 154052](https://github.com/user-attachments/assets/568af46c-aae0-45ae-9109-de66fe821d80)
![Ekran görüntüsü 2024-11-03 154404](https://github.com/user-attachments/assets/67fc96e5-6233-49ca-a02f-74fe6022146a)
![Ekran görüntüsü 2024-11-03 154133](https://github.com/user-attachments/assets/bbce8772-fde8-49d0-bb0b-7e66e25d3d65)
![Ekran görüntüsü 2024-11-03 154223](https://github.com/user-attachments/assets/d27cade4-a9c0-41ed-a086-4275a2b2a689)

## Login - Register
![Ekran görüntüsü 2024-11-03 154258](https://github.com/user-attachments/assets/f6b995e5-0470-41bb-bff5-103f19f50d55)
![Ekran görüntüsü 2024-11-03 154950](https://github.com/user-attachments/assets/df106590-40de-431e-9f6b-326b7d039256)
![Ekran görüntüsü 2024-11-03 154445](https://github.com/user-attachments/assets/2935bd53-357f-4b8a-83b1-9e1c27d61271)

## Admin
![Ekran görüntüsü 2024-11-03 154526](https://github.com/user-attachments/assets/1767d8ea-c64f-495e-8bd7-1a016f7548ad)
![Ekran görüntüsü 2024-11-03 154624](https://github.com/user-attachments/assets/ac5e36e4-203c-4892-9ad8-782578f6a259)
![Ekran görüntüsü 2024-11-03 154514](https://github.com/user-attachments/assets/f16924dc-3a19-4024-a37e-5d496eb2c9cd)
![Ekran görüntüsü 2024-11-03 154612](https://github.com/user-attachments/assets/3bd7609b-f383-4195-9e40-a9131135f1c2)
![Ekran görüntüsü 2024-11-03 154557](https://github.com/user-attachments/assets/13bc3591-3bae-4050-b145-18bf2f3018cb)

## Database Diagram
![Ekran görüntüsü 2024-11-03 155135](https://github.com/user-attachments/assets/e9c09a2a-4ed7-468d-b895-dd86f83243d1)








