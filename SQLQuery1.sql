USE test;

CREATE TABLE test_db(
	id INT IDENTITY(1,1) NOT NULL,
	type_of VARCHAR(50) NOT NULL,
	count_of INT NOT NULL,
	postavka VARCHAR(50) NOT NULL,
	price INT NOT NULL,
	PRIMARY KEY (id)
);

INSERT INTO test_db (type_of, count_of, postavka, price) VALUES
('Молоко', 150, 'Поставщик №1', 3500);

CREATE TABLE register(
	id_user INT IDENTITY(1,1) NOT NULL,
	login_user VARCHAR(50) NOT NULL,
	password_user VARCHAR(50) NOT NULL,
	is_admin bit
);

INSERT INTO register (login_user, password_user, is_admin) VALUES
('admin', 'admin', 1);