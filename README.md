# Practice-C#-OOP
Practice Project Description

Supernatural Inheritance
There are three ranks of magicians. They rank from least to most powerful: Pupils, Mages, and Archmages. In this project, you’ll be developing a system in C# to track the weather magicians in the guild and their spells.

Pupils have a title and can create one weak wind storm.
Mages have a title and can create a weak wind storm and a weak rain storm.
Archmages have a title and can create a weak wind storm, a strong rain storm, and a strong lightning storm.
Notice anything shared in these ranks? If we created a class for each type of magician, we would have a lot of duplicated code. For example, every magician has a title and wind storm. To avoid duplication, we’ll use inheritance.

Pupil is the base class
Mage inherits from Pupil
Archmage inherits from Mage
