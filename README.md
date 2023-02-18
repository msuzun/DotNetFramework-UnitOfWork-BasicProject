# DotNetFramework-UnitOfWork-BasicProject
BASIC UNIT OF WORK PROJECT WITH DOTNET FRAMEWORK AND ENTİTY FRAMEWORK


# The Repository Pattern

A repository is nothing but a class defined for an entity, with all the operations possible on that specific entity. For example, a repository for an entity Customer, will have basic CRUD operations and any other possible operations related to it.

##  A Repository Pattern can be implemented in Following ways:



Then, to run:

- **One repository per entity (non-generic)** : This type of implementation involves the use of one repository class for each entity. For example, if you have two entities Order and Customer, each entity will have its own repository.
- **Generic repository**: A generic repository is the one that can be used for all the entities, in other words it can be either used for Order or Customer or any other entity.

# Unit of Work in the Repository Pattern

Unit of Work is referred to as a single transaction that involves multiple operations of insert/update/delete and so on kinds. To say it in simple words, it means that for a specific user action (say registration on a website), all the transactions like insert/update/delete and so on are done in one single transaction, rather then doing multiple database transactions. This means, one unit of work here involves insert/update/delete operations, all in one single transaction.

