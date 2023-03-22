--1--
CREATE DATABASE DogKennels;

USE DogKennels

CREATE TABLE Countries
(
CountryID INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
CountryName NVARCHAR(30) NOT NULL
)

INSERT INTO Countries
VALUES ('Bulgaria'),
	('USA'),
	('UK'),
	('Japan'),
	('Italy'),
	('Spain'),
	('Germany'),
	('Netherlands'),
	('Russia'),
	('France');

CREATE TABLE Towns
(
TownID INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
TownName NVARCHAR(30) NOT NULL,
CountryID INT NOT NULL,
CONSTRAINT FK_CountriesTowns FOREIGN KEY (CountryID)
    REFERENCES Countries(CountryID)
)

INSERT INTO Towns
VALUES ('Sofia', 1),
	('Varna', 1),
	('Plovdiv', 1),
	('New York', 2),
	('Los Angeles', 2),
	('London', 3),
	('Cambridge', 3),
	('Tokyo', 4),
	('Rome', 5),
	('Madrid', 6),
	('Berlin', 7),
	('Amsterdam', 8),
	('Moscow', 9),
	('Paris', 10);

CREATE TABLE Kennels
(
KennelID INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
KennelName NVARCHAR(60) NOT NULL,
TownID INT NOT NULL,
PhoneNumber NVARCHAR(20) NOT NULL,
CONSTRAINT FK_TownsKennels FOREIGN KEY (TownID)
    REFERENCES Towns(TownID)
)

INSERT INTO Kennels
VALUES ('Dog Kennel "Happy dog"', 1, '+359 896 789 456'),
	('Dog Kennel "Healthy dog"', 1, '+359 896 099 456'),
	('Dog Kennel "Sunny dog"', 2, '+359 896 709 656'),
	('Dog Kennel "Sapphire Spark"', 3, '+359 896 789 430'),
	('Dog Kennel "Dogtopia"', 4, '+1 896 780 456'),
	('Dog Kennel "Puppies"', 4, '+1 846 789 406'),
	('Dog Kennel "Puppyland"', 5, '+1 880 589 456'),
	('Dog Kennel "Baby dogs"', 6, '+44 555 789 406'),
	('Dog Kennel "Happy dog"', 7, '+44 806 666 456'),
	('Dog Kennel "Antonios dogs"', 8, '+81 888 709 456'),
	('Dog Kennel "The Happiest dogs"', 9, '+39 896 789 999'),
	('Dog Kennel "Sunny dog"', 10, '+34 896 100 456'),
	('Dog Kennel "Big dogs"', 11, '+49 444 709 456'),
	('Dog Kennel "The Strongest dogs"', 12, '+31 896 111 406'),
	('Dog Kennel "Russian dog"', 13, '+7 222 789 456'),
	('Dog Kennel "Dogtopia"', 14, '+33 806 448 454');

CREATE TABLE DogBreeds 
(
BreedID INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
BreedName NVARCHAR(30) NOT NULL,
[Description] TEXT,
[Average height] NVARCHAR(30),
[Average wieght] NVARCHAR(30),
[Average lifespan] NVARCHAR(30),
[Minimum exercise per day] NVARCHAR(30),
[Coat length] NVARCHAR(30),
[Common health problems] TEXT
)

INSERT INTO DogBreeds
VALUES ('German shepherd',
	'The German shepherd dog is a herding breed known 
	for its courage, loyalty and guarding instincts. This breed makes an 
	excellent guard dog, police dog, military dog, guide dog for the blind 
	and search and rescue dog. For many families, the German shepherd is also a 
	treasured family pet.', 
	'58-63 cm',
	'35-43 kg',
	'Over 10 years',
	'2 hours',
	'Medium',
	'Hip dysplasia, Elbow dysplasia, Gastric dilatation and volvulus (bloating), 
	Degenerative myelopathy, Eye Problems'),
	('Central Asian Shepherd', 
	'The Central Asian Shepherd Dog is self-assured, balanced, quiet, proud and 
	independent. They are very courageous and have a high working capacity, 
	endurance and a natural instinct of territory. This breed is known for its 
	fearlessness towards large predators.',
	'M: 65-78 cm, F: 60-69 cm',
	'M: 50-120 kg, F: 40-80 kg',
	'Over 10 years',
	'2 hours',
	'Medium',
	'Like most large breeds, they are prone to hip and elbow dysplasia.'),
	('Husky', 
	'The Husky is a friendly and gentle breed of dog if taken care of properly. 
	They are also very playful to whoever handles them. They do not show 
	suspicions on other people or even get aggressive with other dogs unless the 
	other dog shows hostility. Siberian huskies are friendly to people and to 
	other dogs.',
	'51-60 cm',
	'16-27 kg',
	'Over 10 years',
	'2 hours',
	'Short',
	'Hip dysplasia, Epilepsy, Certain cancers, Eye problems (Cataracts, Glaucoma)'),
	('Akita Inu', 
	'Originating from Japan, Akitas are known for being incredibly loyal family pets. They are 
	large dogs and very strong. Although they were originally bred as guard dogs due to their 
	fearless and loyal personalities, Akitas were often used for hunting in the past and so have 
	a high prey drive.',
	'61-71 cm',
	'31-59 kg',
	'Under 10 years',
	'2 hours',
	'Short',
	'Hip dysplasia, Gastric Dilatation Volvulus (GDV), Skin problems, Eye problems, Auto-immune diseases'),
	('Golden retriever', 
	'Golden retrievers have a loving and affectionate demeanor. They are gentle with 
	kids and other animals and iare very loyal to their family. Golden retrievers are 
	eager to please their owners, making them easier to train. However, they are very 
	active, which means they loves to play for long periods of time.',
	'51-61 cm',
	'25-34 kg',
	'Over 10 years',
	'2 hours',
	'Medium',
	'Hip dysplasia, Elbow dysplasia, Eye problems (Cataracts, Multifocal retinal 
	dysplasia, Glaucoma), Ichthyosis (a skin disease)'),
	('Labrador', 
	'They make excellent companions, as well as assistance dogs due to their sensitive 
	and affectionate nature. Labradors do well with both sole owners or as a part of a 
	family, and get on well with children and other pets. They are energetic, mostly 
	placid, and cope well with the hustle and bustle of modern life.',
	'55-57 cm',
	'25-35 kg',
	'Over 10 years',
	'2 hours',
	'Short',
	'Hip dysplasia, Elbow dysplasia, Eye problems (Progressive retinal atrophy), 
	Prone to obesity'),
	('Collie', 
	' The Collie is a highly social animal, devoted to his family. Speaking of family, 
	Collies seem to have a natural affinity for children. They’re playful, protective, 
	and affectionate with the kids in the family. Collies are really smart and easily trained. 
	They learn quickly and respond well to gentle training. They’re also among the easiest 
	breeds to housebreak.',
	'55-66 cm',
	'20-34 kg',
	'Over 12 years',
	'2 hours',
	'Long',
	'Hip dysplasia, Eye problems, Epilepsy, Ceroid lipofuscinosis (CL), Sensory 
	Neuropathy (SN), Trapped Neutrophil Syndrome (TNS)'),
	('Border Collie', 
	'Border Collies are intelligent dogs who love to be on the go all the time! 
	They thrive off plenty of exercise and lots to keep them occupied and are known 
	for their stealth, speed and herding instinct.',
	'53 cm',
	'25-30 kg',
	'Over 12 years',
	'2 hours',
	'Medium',
	'Hip dysplasia, Eye problems, Epilepsy, Ceroid lipofuscinosis (CL), Sensory 
	Neuropathy (SN), Trapped Neutrophil Syndrome (TNS)'),
	('Dobermann', 
	'Dobermanns are a large and powerful breed who love to be involved in everything 
	their owners are doing. They’re loyal and intelligent which makes them popular 
	pets, especially as they can adapt so well to different family lives.',
	'65-69 cm',
	'30-40 kg',
	'Over 10 years',
	'2 hours',
	'Short',
	'Hip dysplasia, Eye problems, Wobbler Syndrome, Certain cancers, Von Willebrands disease, 
	Dilated Cardiomyopathy, Gastric Dilatation Volvulus (GDV), Hypothyroidism'),
	('Rottweiler', 
	'They are loyal dogs, naturally protective and can fit in well with family life 
	if well trained and kept occupied. Rottweilers are intelligent, large, powerful 
	dogs. They thrive in a home with someone who understands the breed and 
	recognises the need for early socialisation and consistent, 
	reward-based training.',
	'54-69 cm',
	'35-60 kg',
	'Over 10 years',
	'2 hours',
	'Short',
	'Hip dysplasia, Elbow dysplasia, Inherited eye diseases, Heart probleme, 
	Certain cancers, Hot spots (acute moist dermatitis), Osteochondrosis dissecans (OCD)'),
	('Saint Bernard', 
	'Because they are so friendly, gentle and tolerant, Saints can be especially 
	good for families with well-behaved children. Known to be exceptionally 
	understanding and patient, Saints are careful not to injure a child. These 
	dogs are eager to please, which can make training easier than with other breeds.',
	'70-75 cm',
	'54-81 kg',
	'Under 10 years',
	'1 hours',
	'Short',
	'Hip dysplasia, Elbow dysplasia, Cruciate ligament disease, Skin problems, EAR problems, 
	Certain cancers, Gastric Dilatation Volvulus (GDV), Osteochondrosis dissecans (OCD), 
	Dilated cardiomyopathy (DCM)'),
	('Poodle', 
	'Poodles are good family dogs — fun, energetic, smart and easy to train. 
	They do best with plenty of exercise for both mind and body and prefer to 
	be with people most of the time.',
	NULL,
	'M: 30-35 kg, F: 21-32 kg',
	'12-14 years',
	NULL,
	'Medium',
	'Hip dysplasia, Luxating patellas, Legg-Perthes disease (Legg-Calvé-Perthes), 
	Progressive retinal atrophy, Epilepsy, Gastric Dilatation Volvulus (GDV), 
	Von Willebrands disease, Cardiomyopathy, Cushings syndrome (Hyperadrenocorticism), 
	Addisons Disease, Intervertebral disc disease, Dry eye – Keratoconjunctivitis sicca (KCS), 
	Hypothyroidism, Cataracts, Distichiasis, Entropion'),
	('Bulldog', 
	'Dependable and predictable, the bulldog is a wonderful family pet and loving 
	to most children. People-oriented as a breed, they actively solicit human 
	attention. However, they have retained the courage that was originally bred 
	into them for bull baiting, so they make fine watchdogs.',
	'31-40 cm',
	'23-25 kg',
	'Under 10 years',
	'1 hours',
	'Short',
	'Brachycephalic syndrome, Elbow dysplasia, Hip dysplasia, Eyelid problems, 
	Dry eye – Keratoconjunctivitis sicca (KCS), Cherry eye, Tail problems, 
	Skin infections'),
	('American Cocker Spaniel', 
	'Cocker Spaniels are lively dogs who love to play. They are known for being 
	"happy" dogs because their tails are always wagging! Although originally 
	bred as gun dogs, Cocker Spaniels have become popular family pets.', 
	'38-41 cm',
	'13-14.5 kg',
	'Over 10 years',
	'1 hours',
	'Medium',
	'Hip dysplasia, Atopy, Ear problems, Eye problems'),
	('Welsh Corgi', 
	'Welsh Corgis are an exceptionally affectionate dog breed and do well with all 
	sorts of families, making them an ideal pet for most homes. One of their most 
	popular personality traits is that they make great watchdogs. While they are 
	not particularly formidable, they have a loud bark and are not afraid to use it!',
	'25-30 cm',
	'9-12 kg',
	'Over 12 years',
	'1 hours',
	'Short',
	'Hip dysplasia, Intervertebral disc disease, Epilepsy, Eye problems (Cataracts, Lens luxation), 
	Von Willebrands disease, Bladder stones'),
	('Dachshund', 
	'Dachshunds are affectionate and playful little dogs who have a lot of energy 
	considering their smaller size. Once they’ve tired themselves out getting into 
	mischief, they’re happy to curl up somewhere warm with their owner.',
	'Standard 20-27cm, Mini 13-18cm',
	'Standard 9-12kg, Mini 4.5-8kg',
	'Over 12 years',
	'Standard 1 hours, Mini 30 min',
	'Short',
	'Intervertebral disc disease, Heart disease (miniature varieties), 
	Progressive Retinal Atrophy, Dry eye'),
	('Miniature Pinscher', 
	'The coat is smooth and short, so the dogs have a low shedding level and require 
	less grooming. They also have distinctive dark oval eyes and high-set ears, which 
	enhance the personality of this dog. Miniature Pinschers are social and playful 
	animals with a high affection for families and children.',
	'25-30 cm',
	'3.5-4.5 kg',
	'Over 12 years',
	'30 minutes',
	'Short',
	'Luxating patellas, Legg-Perthes disease (Legg-Calvé-Perthes), Heart defects,
	Progressive Retinal Atrophy, Cataracts, Urolithiasis'),
	('Chihuahua', 
	'Chihuahuas have remained a popular breed due to their small size and loving, 
	energetic and alert nature. They may be best known as lap dogs and this may 
	be the case some of the time, but they’re also busy, active and full of personality. 
	Chihuahuas can have short, smooth coats or longer, fluffier coats, which gives them 
	quite a different look, but both coat types of Chihuahua have the same needs.',
	'12-20 cm',
	'1.8-2.7 kg',
	'Over 12 years',
	'30 minutes',
	'Short',
	'Hip dysplasia, Luxating patellas, Legg-Perthes disease (Legg-Calvé-Perthes), 
	Heart disease, Eye problems, Hydrocephalus, Dental problems, Dystocia, 
	Cryptorchidism, Chiari malformation and Syringomyelia (CM/SM)'),
	('Pug', 
	'As a breed, they tend to be expressive, exuberant, and often comical. They are 
	eager to play and will follow you, well, pretty much everywhere. Pugs tend to 
	sleep more than other dogs (an average of 14 hours a day), and in this way are 
	much like cats. So while they are known as eager people-pleasers, they are also 
	snoozers. Pugs are also known to be great family dogs and are very playful and 
	affectionate with children. Also, because of their mouth shape, pugs have trouble 
	delivering an aggressive bite and so are considered to be on the more kid-safe 
	end of the breed spectrum.', 
	'25-33 cm',
	'6-8 kg',
	'Over 10 years',
	'Less than 1 hour',
	'Short',
	'Brachycephalic obstructive airway syndrome (BOAS), Eye problems (dry eye, eye infections, 
	corneal ulcers or eye trauma due to shallow eye sockets), Eyelid problems, Skin infections, 
	Luxating patellas, Pug Dog Encephalitis (PDE), Hemivertebrae, Elbow dysplasia, Hip dysplasia, 
	Legg Perthes disease, Hypothyroidism'),
	('Yorkshire Terrier', 
	'Yorkshire Terriers, or ‘Yorkies’ as they’re more affectionately known, are known to be small 
	but mighty! They have big attitudes, and aren’t worried about putting bigger dogs in their 
	place if they feel they need to. They can be quite stubborn, making training more of a challenge. 
	For this reason, training will require patience, but can be achieved using reward-based techniques. 
	For more information on training your dog, take a look at our dog behaviour page where you can 
	pick up plenty of tips to help you and your canine companion better understand each other.', 
	'20 cm',
	'3.2 kg',
	'Over 12 years',
	'30 minutes',
	'Long',
	'Luxating patellas, Bladder stones, Tracheal collapse, Dental problems, Progressive retinal atrophy, 
	Lens luxation, Atopy, Diabetes Mellitus, Legg-Perthes disease (Legg-Calvé-Perthes), Portosystemic shunt, 
	Keratoconjunctivitis sicca or "Dry eye", Hydrocephalus, Chiari malformation Syringomyelia (CM/SM)');

CREATE TABLE TypesOfFood 
(
TypeOfFoodID INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
FoodName NVARCHAR(35) NOT NULL,
[Description] TEXT,
TypeOfBreed NVARCHAR(30) DEFAULT 'Every', --Small/Medium/Large/Every
AverageAge NVARCHAR(70)
)

INSERT INTO TypesOfFood
VALUES ('Mother''s milk', NULL, 'Every', 'From birth to 4-6 weeks'),
	('Soaked food', 'Granules saked in water.', 'Every', 'From 4-6 to 12 weeks(3 months)'),
	('Puppy food', 'A well balanced puppy food contains those nutrients that a puppy specifically need for this 
	purpose, nutrients that are not necessary once the puppy has finished growing into a dog and that are not 
	added to adult formula dog foods.', 'Every', 'Small dogs: From 4-6 weeks to 9 weeks, Large: up to 15-24 weeks'),
	('Adults food 1', 'An adult dog diet, or maintenance diet, contains nutrients suited for animals that have passed 
	their growth stage. The granules are smaller and good for small breeds.', 'Small breeds', 'From 1 year to 6-8 years.'),
	('Adults food 2', 'The granules are bigger and good for bigger breeds.', 'Medium and Large breeds', 'From 1 year to 6-8 years.'),
	('Seniors food 1', 'Small granules', 'Small breeds', 'From 6 to 10 years'),
	('Seniors food 2', 'Big granules', 'Medium and Large breeds', 'From 6 to 10 years'),
	('Food for Pregnant or Nursing Dogs', 'These dogs should be eating food that is calorie dense and high in protein. 
	This kind of food is at least 22 percent protein.', 'Pregnant or Nursing Dogs', NULL);

CREATE TABLE DogsForSale 
(
DogID INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
DogName NVARCHAR(30) NOT NULL,
BreedID INT,
[Date of birth] DATE NOT NULL,
[Type of dog (Puppy/Adult/Father/Mather/Senior)] NVARCHAR(10) NOT NULL,
Mother NVARCHAR(30),
Father NVARCHAR(30),
TypeOfFoodID INT,
KennelID INT NOT NULL,
Price FLOAT,
	CONSTRAINT FK_DogBreedsDogsForSale FOREIGN KEY (BreedID) 
	REFERENCES DogBreeds (BreedID),
	CONSTRAINT FK_TypesOfFoodDogsForSale FOREIGN KEY (TypeOfFoodID) 
	REFERENCES TypesOfFood (TypeOfFoodID),
	CONSTRAINT FK_KennelsDogsForSale FOREIGN KEY (KennelID) 
	REFERENCES Kennels (KennelID)
)

INSERT INTO DogsForSale
VALUES ('Ares', 3, '2010/03/04', 'Senior', NULL, NULL, 7, 15, 150),
	('Iris', 5, '2019/10/05', 'Mother', NULL, NULL, 5, 4, 300),
	('Buster', 5, '2018/09/17', 'Father', NULL, NULL, 5, 4, 350),
	('Arter', 5, '2022/06/02', 'Puppy', 'Iris', 'Buster', 3, 4, 600),
	('Lisa', 5, '2022/06/02', 'Puppy', 'Iris', 'Buster', 3, 4, 600),
	('Bruno', 10, '2019/06/21', 'Adult', NULL, NULL, 5, 8, 500),
	('Tiara', 10, '2021/09/22', 'Adult', NULL, NULL, 5, 8, 450),
	('London', 3, '2018/12/25', 'Pregnant', NULL, NULL, 8, 1, 300),
	('Lady', 14, '2020/02/06', 'Mother', NULL, NULL, 5, 6, 600),
	('Bruck', 14, '2022/12/20', 'Puppy', 'Lady', NULL, 1, 6, 1100),
	('Daisy', 14, '2022/12/20', 'Puppy', 'Lady', NULL, 1, 6, 1100),
	('Pedro', 12, '2019/09/12', 'Adult', NULL, NULL, 5, 16, 1000),
	('Hachiko', 4, '2021/12/15', 'Adult', NULL, NULL, 5, 10, 1200),
	('Dexter', 4, '2022/08/25', 'Puppy', NULL, NULL, 3, 10, 1500),
	('Max', 15, '2021/02/24', 'Adult', NULL, NULL, 5, 9, 2500),
	('Becky', 15, '2021/03/14', 'Adult', NULL, NULL, 5, 9, 2500),
	('Rex', 15, '2022/07/23', 'Puppy', NULL, NULL, 3, 9, 3000),
	('Cooper', 2, '2020/10/26', 'Adult', NULL, NULL, 5, 13, 1000),
	('Karina', 1, '2021/09/14', 'Mother', NULL, NULL, 5, 2, 300),
	('Rocky', 1, '2021/11/29', 'Father', NULL, NULL, 5, 2, 300),
	('Zoe', 1, '2022/12/30', 'Puppy', 'Karina', 'Rocky', 1, 2, 500),
	('Jack', 1, '2022/12/30', 'Puppy', 'Karina', 'Rocky', 1, 2, 500),
	('Duke', 20, '2011/04/28', 'Senior', NULL, NULL, 6, 3, 500),
	('Tifany', 19, '2013/04/14', 'Senior', NULL, NULL, 6, 5, 2500),
	('Bella', 18, '2021/10/17', 'Mother', NULL, NULL, 5, 7, 2500),
	('Black', 17, '2021/05/27', 'Father', NULL, NULL, 5, 7, 2500),
	('Princess', NULL, '2022/10/01', 'Puppy', 'Bella', 'Black', 2, 7, 100),
	('Ginger', NULL, '2022/10/01', 'Puppy', 'Bella', 'Black', 2, 7, 100),
	('Murphey', NULL, '2022/10/01', 'Puppy', 'Bella', 'Black', 2, 7, 100),
	('HotDog', 16, '2021/03/03', 'Adult', NULL, NULL, 5, 12, 600),
	('Fify', 16, '2021/09/03', 'Adult', NULL, NULL, 5, 12, 600),
	('Betoven', 11, '2022/11/05', 'Puppy', NULL, NULL, 2, 15, 1000),
	('Ace', 13, '2020/04/13', 'Adult', NULL, NULL, 5, 14, 700),
	('Riley', 6, '2020/02/28', 'Mother', NULL, NULL, 5, 4, 500),
	('Budy', 6, '2018/06/06', 'Father', NULL, NULL, 5, 9, 500),
	('Coco', 6, '2022/12/08', 'Puppy', 'Riley', 'Budy', 1, 7, 500),
	('Finn', 6, '2022/12/08', 'Puppy', 'Riley', 'Budy', 1, 7, 500),
	('Lassy', 7, '2019/04/09', 'Adult', NULL, NULL, 5, 11, 1000),
	('Luna', 8, '2017/08/22', 'Adult', NULL, NULL, 5, 11, 500),
	('Hank', 9, '2022/05/10', 'Puppy', NULL, NULL, 3, 8, 700);

--2--
--Извежда DogID, DogName, BreedID и Type of dog
SELECT DogID, DogName, BreedID, [Type of dog (Puppy/Adult/Father/Mather/Senior)]
FROM DogsForSale;

--Извежда здравните проблеми на съответните породи
SELECT BreedID, BreedName, [Common health problems]
FROM DogBreeds

--3--
--Извежда кученцата
SELECT DogID, DogName, BreedID, 
[Type of dog (Puppy/Adult/Father/Mather/Senior)], Price
FROM DogsForSale
WHERE [Type of dog (Puppy/Adult/Father/Mather/Senior)] = 'Puppy' 
AND BreedID = 5;

--Извежда кученцата с определена порода (тоест без BreedID = NULL)
 SELECT DogID, DogName, BreedID, 
[Type of dog (Puppy/Adult/Father/Mather/Senior)], Price
FROM DogsForSale
WHERE [Type of dog (Puppy/Adult/Father/Mather/Senior)] = 'Puppy'
AND BreedID IS NOT NULL;

--4--
CREATE VIEW averagePrice AS
SELECT AVG(Price) AS averagePrice
FROM DogsForSale;

--5--
--Кучетата от Dog Kennel "Sapphire Spark", които не са бременни, са разменени с тези от Dog Kennel "Happy dog"
--в България, които са бременни. Напишете 2 заявки, чрез които да обнови данните.
UPDATE DogsForSale
SET KennelID = 1
WHERE KennelID = 4 AND [Type of dog (Puppy/Adult/Father/Mather/Senior)] <> 'Pregnant';

UPDATE DogsForSale
SET KennelID = 4
WHERE KennelID = 1 AND [Type of dog (Puppy/Adult/Father/Mather/Senior)] = 'Pregnant';

--6--
--Кучетата от развъдник 15 са продадени и развъдникът е закрит. Направете 2 заявки, които
--обновяват двете таблици.
DELETE FROM DogsForSale
WHERE KennelID = 15;

DELETE FROM Kennels
WHERE KennelID = 15;

--7--
--Извежда всички кучета, чиято цена е под средната.
SELECT ds.DogID, ds.DogName, db.BreedName, 
ds.[Type of dog (Puppy/Adult/Father/Mather/Senior)], ds.Price
FROM DogsForSale ds
JOIN DogBreeds db ON db.BreedID = ds.BreedID
WHERE ds.Price < (SELECT * FROM averagePrice)
ORDER BY ds.Price ASC, db.BreedName;

--Извежда кучетата от България със името на развъдника и градът, в който се намира.
SELECT ds.DogID, ds.DogName, ds.BreedID, 
ds.[Type of dog (Puppy/Adult/Father/Mather/Senior)], 
k.KennelName, t.TownName
FROM DogsForSale ds
JOIN Kennels k ON k.KennelID = ds.KennelID
JOIN Towns t ON t.TownID = k.TownID
WHERE ds.KennelID IN
	(SELECT KennelID
	FROM Kennels k
	WHERE TownID IN
		(SELECT TownID
		FROM Towns t
		WHERE CountryID =
			(SELECT CountryID
			FROM Countries c
			WHERE CountryName = 'Bulgaria')))
ORDER BY t.TownName ASC, ds.DogID;