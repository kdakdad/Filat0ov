using System;

public class User
{
    public string Username { get; set; } // Имя пользователя
    public string Email { get; set; } // Email
    private string Password { get; set; } // Пароль (приватный для безопасности)
    public string Address { get; set; } // Адрес
    public int Age { get; set; }

    public User(string username, string email, string password, string address, int age)
    {
        this.Username = username;
        this.Email = email;
        this.Password = password;
        this.Address = address;
        this.Age = age;
    }

    // Геттер для пароля (безопасный доступ)
    public string GetPassword()
    {
        return this.Password;
    }
}
