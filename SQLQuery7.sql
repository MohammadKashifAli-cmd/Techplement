CREATE TABLE Quotes (
    QuoteID INT PRIMARY KEY IDENTITY,
    QuoteText NVARCHAR(500),
    AuthorName NVARCHAR(100)
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE,
    PasswordHash NVARCHAR(200)
);
INSERT INTO Quotes (QuoteText, AuthorName) VALUES 
('The only way to do great work is to love what you do.', 'Steve Jobs'),
('I have not failed. I’ve just found 10,000 ways that won’t work.', 'Thomas Edison'),
('If you want to live a happy life, tie it to a goal, not to people or things.', 'Albert Einstein'),
('Don’t count the days, make the days count.', 'Muhammad Ali'),
('You must be the change you wish to see in the world.', 'Mahatma Gandhi'),
('Arise, awake, and stop not until the goal is reached.', 'Swami Vivekananda'),
('The greatest prayer is patience.', 'Buddha'),
('As soon as the fear approaches near, attack and destroy it.', 'Chanakya'),
('Live as if you were to die tomorrow. Learn as if you were to live forever.', 'Mahatma Gandhi')


INSERT INTO Users (Username, Email, PasswordHash) VALUES 
('rahul_raj', 'rahul@gmail.com', 'hashed_password_1'),
('sameer', 'sameer@gmail.com', 'hashed_password_2'),
('tony_stark', 'tony@gmail.com', 'hashed_password_3'),
('abdullah', 'abdullah@gmail.com', 'hashed_password_4'),
('riya', 'riya@gmail.com', 'hashed_password_5');


select * from Quotes
select * from Users
