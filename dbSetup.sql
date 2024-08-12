CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) UNIQUE COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE
chores(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
name VARCHAR(255) NOT NULL,
description VARCHAR(255),
isComplete BOOL NOT NULL DEFAULT false
)default charset utf8mb4;


-- CREATE
INSERT INTO
chores(name, description, isComplete)
VALUES
('Wash the car', 'Make sure to use the big rage', false);


-- DELETE
DELETE FROM chores
WHERE id = 1


--GET
SELECT * FROM chores;


--UPDATE
UPDATE chores
SET `name` = 'Wash the car'
WHERE
`isComplete` = 1