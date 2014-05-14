Types of Repositories
1. One repo per type
2. One Repo per object type
3.Read Repo, Write Repo
4.One Repo per context

Disconnected Graphs
DbSet.Add(root) : All elements State = Added. inserts each element, even if pre-existing in DB
DbSet.Attach(root): Al elements State = unchanged . Any new records with missing FKs will throw


EF Validations

1.IValidateObject
2.override ValidateEntity

context.Entry(x).Property(y).GetValidationErrors
context.Entry(x).GetValidationErrors()

context.GetValidationErrors() : only validates Added & Modified objects by default, SaveChanges calls this by default, customizable
DbEntityValidationException
DbEntityValidationResult properties : 
Validation Errors 
IsValid
Entry