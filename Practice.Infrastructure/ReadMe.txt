Types of Repositories
1. One repo per type
2. One Repo per object type
3.Read Repo, Write Repo
4.One Repo per context

Disconnected Graphs
DbSet.Add(root) : All elements State = Added. inserts each element, even if pre-existing in DB
DbSet.Attach(root): Al elements State = unchanged . Any new records with missing FKs will throw exception
Context.Entry(root).State = En


EF Validations

1.IValidateObject
2.override ValidateEntity

context.Entry(x).Property(y).GetValidationErrors
context.Entry(x).GetValidationErrors() : IEnumerable<DbEntityValidationResult>

context.GetValidationErrors() : only validates Added & Modified objects by default, SaveChanges calls this by default, customizable
DbEntityValidationException
DbEntityValidationResult properties : 
Validation Errors 
IsValid
Entry

Processing multiple Validations
1.Property-level validation : Entity & base class, complete type & base class
2.Complex type level validation : including base types , attributes & IValidateObjects
3.Entity Type level validation : including base entity types, attributes & IValidateObjects

SaveChanges calls DetectChanges before calling GetValidationErrors
GetValdiaitonErrors(iterates through all the entries) calls ValidateEntrity for each entry which calls GetValidateResult
GetValidationResult ( for single entity)