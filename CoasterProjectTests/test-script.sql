BEGIN TRANSACTION;

DELETE FROM cedar_point_coasters;
DELETE FROM ride_forum;

INSERT INTO cedar_point_coasters VALUES ('TestCoaster', 1, 2, 3, 4, 'TestDescription', 5, 'TestRide', 'TestImage');
DECLARE @newCedarPointCoastersId int = (SELECT @@IDENTITY);

INSERT INTO ride_forum VALUES ('DoesNotMatter', 1, GETDATE(), 'DoNotMatter', 'DoNotMatter');
DECLARE @newRideForumId int = (SELECT @@IDENTITY)

SELECT @newCedarPointCoastersId as newCedarPointCoastersId, @newRideForumId as newRideForumId;

ROLLBACK;