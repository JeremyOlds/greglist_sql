CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';




CREATE TABLE
    houses(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        bathrooms DECIMAL NOT NULL,
        bedrooms INT NOT NULL,
        price DECIMAL NOT NULL,
        levels INT NOT NULL,
        description VARCHAR(512),
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
    )default charset utf8 COMMENT '';


INSERT INTO
  houses(
    bathrooms,
    bedrooms,
    price,
    levels,
    description
  )
VALUES(
    3.5,
    2,
    50000,
    1,
    'Its a House'
);

SELECT * FROM houses;

SELECT * FROM houses WHERE id = 1;