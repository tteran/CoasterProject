-- Switch to the system (aka master) database
USE master;
GO

-- Delete the SSGeek Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='CoasterSideProject')
DROP DATABASE CoasterSideProject;
GO

-- Create a new SSGeek Database
CREATE DATABASE CoasterSideProject;
GO

-- Switch to the SSGeek Database
USE CoasterSideProject;
GO

CREATE TABLE cedar_point_coasters(

	id int identity(1,1),
	[name] varchar(30) not null,
	build_year int not null,
	speed int not null,
	height int not null,
	duration int not null,
	[description] varchar(200) not null,
	min_height int not null,
	ride_video varchar(200) not null,
	ride_image varchar(200) not null,

	constraint pk_cedar_point_coasters_id primary key (id)
);

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Blue Streak', 1964, 40, 78, 2, 'Cedar Points oldest coaster. Family favorite since it opened in 1964. Classic out and back style. Packed with hills, thrillsand history.', 48, 'https://www.youtube.com/watch?v=t5aeLbY4bE8', 'https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/Blue_streak1_CP.JPG/1200px-Blue_streak1_CP.JPG');

ALTER TABLE cedar_point_coasters
ADD [description] varchar(200);

ALTER TABLE cedar_point_coasters
ADD height int

ALTER TABLE cedar_point_coasters
ALTER COLUMN duration int

SELECT * FROM cedar_point_coasters