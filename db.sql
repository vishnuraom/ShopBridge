
Drop database ShopBridgeDb;

Create database ShopBridgeDb;

Create table Inventory(
    item_id INT PRIMARY KEY IDENTITY,
    name VARCHAR (255) NOT NULL,
	description VARCHAR (255) NOT NULL,
	category VARCHAR (255) NOT NULL,
	price DECIMAL(10,2) NOT NULL,
    date_added DATE NOT NULL,
	date_updated DATE 
);

insert into Inventory(category,name, description,price,date_added) values ('Electronics','Phone 1', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mattis et lectus quis maximus. Curabitur at gravida metus. Mauris placerat semper nisl, a fermentum leo egestas eu.',10999.50, CURRENT_TIMESTAMP),
('Electronics','Phone 2', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mattis et lectus quis maximus. Curabitur at gravida metus. Mauris placerat semper nisl, a fermentum leo egestas eu.',10999, CURRENT_TIMESTAMP),
('Clothing','Shirt', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mattis et lectus quis maximus. Curabitur at gravida metus. Mauris placerat semper nisl, a fermentum leo egestas eu.',1210, CURRENT_TIMESTAMP),
('Food','Icecream', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mattis et lectus quis maximus. Curabitur at gravida metus. Mauris placerat semper nisl, a fermentum leo egestas eu.',145.00, CURRENT_TIMESTAMP),
('Food','Biscuits', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mattis et lectus quis maximus. Curabitur at gravida metus. Mauris placerat semper nisl, a fermentum leo egestas eu.',100, CURRENT_TIMESTAMP),
('Clothing','Jeans', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mattis et lectus quis maximus. Curabitur at gravida metus. Mauris placerat semper nisl, a fermentum leo egestas eu.',2999, CURRENT_TIMESTAMP),
('Electronics','Phone 7', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mattis et lectus quis maximus. Curabitur at gravida metus. Mauris placerat semper nisl, a fermentum leo egestas eu.',20999, CURRENT_TIMESTAMP);

select * from Inventory;