-- Switch to the system (aka master) database
USE master;
GO

-- Delete the CoasterSideProject Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='CoasterSideProject')
DROP DATABASE CoasterSideProject;
GO

-- Create a new CoasterSideProject Database
CREATE DATABASE CoasterSideProject;
GO

-- Switch to the CoasterSideProject Database
USE CoasterSideProject;
GO

CREATE TABLE cedar_point_coasters (

	id int identity(1,1),
	[name] varchar(30) not null,
	build_year int not null,
	speed int not null,
	duration int not null,
	min_height int not null,
	ride_video varchar(200) not null,
	ride_image varchar(200) not null,
	[description] varchar(300) not null,
	height int not null,

	constraint pk_cedar_point_coasters_id primary key (id)
);

CREATE TABLE ride_forum (

	id int identity(1,1),
	username varchar(30) not null,
	rating int not null,
	post_date datetime default getdate(),
	forum_title varchar(100) not null,
	forum_text varchar(1000) not null,

	constraint pk_ride_forum_id primary key (id)
);

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Blue Streak', 1964, 40, 78, 2, 'Cedar Points oldest coaster. Family favorite since it opened in 1964. Classic out and back style. Packed with hills, thrills and history.', 48, 'https://www.youtube.com/embed/t5aeLbY4bE8', 'https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/Blue_streak1_CP.JPG/1200px-Blue_streak1_CP.JPG');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Cedar Creek Mine Ride', 1969, 40, 48, 3, 'Located in Frontier Town this coaster is a great choice for families. With two lift hills, helixes and sharp turns anyone can love this ride.', 48, 'https://www.youtube.com/embed/IpJ9l2w4haw', 'https://coasterpedia.net/w/images/thumb/9/95/Cedar_Creek_Mine_Ride_train.jpg/500px-Cedar_Creek_Mine_Ride_train.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Corkscrew', 1976, 48, 85, 2, 'When it opened Corkscrew was the first coaster in the world with 3 inversions. A beautiful blue track and a red train this coaster is a beautiful sight to see and you can walk right by it on the midway.', 48, 'https://www.youtube.com/embed/a1iGwMl-SDc', 'https://i.pinimg.com/originals/00/0c/91/000c91eb6553b9e5019240a6241405c2.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Gatekeeper', 2013, 67, 170, 2, 'This winged coaster guards the entrance of the park. This ride has it all: big loops, inversions through keyholes and airtime!', 52, 'https://www.youtube.com/embed/pkOqi7Du3Og', 'https://i.ytimg.com/vi/fRw7peAZi0o/maxresdefault.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Gemini', 1978, 60, 125, 3, 'This steel-track, wooden-structured, racing coaster packs a punch! Get ready for drops, twists and turns!', 48, 'https://www.youtube.com/embed/O5anQIKQgAo', 'http://www.coastergallery.com/cp/Gemini-3.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Iron Dragon', 1987, 40, 76, 2, 'As this coaster swings and says over the lagoon you will be sure to have a good time. It will leave you second-guessing as you fly over the trees and water.', 48, 'https://www.youtube.com/embed/2cwUMqSWSmU', 'https://www.themeparkreview.com/parks/pimages/Cedar_Point/Iron_Dragon/15%20IDg.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Magnum XL-200', 1989, 72, 205, 3, 'When it opened in 1989 it was the first coaster to go over 200 feet. As you go over hills and tunnels you will be sure to be wanting more.', 48, 'https://www.youtube.com/embed/3nPG4l9-LkM', 'https://i.imgur.com/eHssJxm.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Maverick', 2007, 70, 105, 3, 'This coatser is pakced with launches, twists and tunnels. You will get plenty of airtime like being on a bucking bronco.', 52, 'https://www.youtube.com/embed/BIJBz1w3uYw', 'https://www.tripsavvy.com/thmb/gFkm9YEKPh1VkDfM2mgimPyJceU=/3201x2091/filters:no_upscale():max_bytes(150000):strip_icc()/MaverickcoasterCedarPoint-5c23bef546e0fb00013512bf.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Millenium Force', 2000, 93, 310, 2, 'The creation of this coaster spawned a new type called giga coaster. When it opened it was the tallest and first to go over 300 feet. This ride shoots over lagoons, through tunnels at staggering speeds!', 48, 'https://www.youtube.com/embed/MybcORGVkEU', 'http://i.imgur.com/faP6aYa.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Pipe Scream', 2014, 43, 43, 2, 'This family coaster has something for everyone. As it goes up and down over a wave like track your car spins around and you will be sure to be saying Cowabunga!', 48, 'https://www.youtube.com/embed/FvNy7fTpZkg', 'https://farm3.staticflickr.com/2925/14279076745_a9fc52fdc9_b.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Raptor', 1994, 57, 137, 2, 'With 6 inversions including the worlds first cobra roll you will want to get right back in line after riding this. This ride is as unforgiving as it is ehxilirating.', 54, 'https://www.youtube.com/embed/Tb2H-8CQuyY', 'https://upload.wikimedia.org/wikipedia/commons/6/64/Cedar_Point_aerial_view_of_Raptor_%283529%29.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Rougarou', 2015, 60, 145, 3, 'First floorless coaster at Cedar Point. You will experience a 119 foot tall vertical loop plus more dips and turns over the lagoon!', 54, 'https://www.youtube.com/embed/RuweAtyeUuU', 'http://media.cleveland.com/travel_impact/photo/-771c9733d6ba4eb2.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Steel Vengeance', 2018, 74, 205, 3, 'Tallest, fastest and longest hybrid coaster with over 30 seconds combined total airtime! With twists, turns and close calls this will be sure to be your new favorite at the park', 52, 'https://www.youtube.com/embed/JVKK4QxWSNo', 'https://mediad.publicbroadcasting.net/p/wksu/files/styles/x_large/public/201805/steel_vengeance_05_preview.jpeg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Top Thrill Dragster', 2003, 120, 420, 1, 'This ride only takes 3.8 seconds to get up to its max speed and then it is straight up and straight down. This is a true race to the sky.', 52, 'https://www.youtube.com/embed/lBgNx8nts70', 'https://www.tripsavvy.com/thmb/cKyH30TC4PkOh2a1_IQ3kztrQ_k=/960x0/filters:no_upscale():max_bytes(150000):strip_icc()/4069293031_922d2921bf_o-5c30c28146e0fb00018db593.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Valravn', 2016, 75, 223, 3, 'This ride has it all: drop coaster, 270-degree roll, and airtime. This is the tallest, fastest and longest dive coaster in the country.', 52, 'https://www.youtube.com/embed/6EjSl_FKDBY', 'https://farm1.staticflickr.com/507/31129559514_245aaab925_b.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Wicked Twister', 2002, 72, 215, 1, 'This coatser catapults you so fast you will not know what hit you. As you go up and down the momentum builds and you wind through the twists. You will want seconds after riding this!', 52, 'https://www.youtube.com/embed/T9p8x-D64vk', 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Wicked_twister1_CP.JPG/1200px-Wicked_twister1_CP.JPG');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Wilderness Run', 1979, 6, 19, 1, 'This a great first coaster for the kiddos. Just one ride on this and they will be screaming for more!', 36, 'https://www.youtube.com/embed/gkVt5uryylQ', 'http://www.coastergallery.com/CP/Wilderness_Run-5.jpg');

INSERT INTO cedar_point_coasters ([name], build_year, speed, height, duration, [description], min_height, ride_video, ride_image)
VALUES ('Woodstock Express', 1999, 25, 38, 1, 'This is a fun wild ride that will take you up and down and all around. Offer fantatic thrills for first time riders!', 36, 'https://www.youtube.com/embed/fDBydpPplzQ', 'https://www.themeparkreview.com/forum/files/img_6635_942.jpg');
