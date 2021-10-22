using EF.Models;
using System;
using System.Linq;

namespace EF
{
    public static class DbInitializer
    {
        public static void Initialize(MarkProcessingContext context)
        {
            context.Database.EnsureCreated();
            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            // Look for any Students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{GivenName="std1",Surname = "std11",Gender = "M",StudentPhoneNumber ="+6545321980",StudentEmailAddress="std1@insta.com",StudentNRIC="123456",StudentDateOfBirth=DateTime.Parse("1990-04-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std2",Surname = "std22",Gender = "F",StudentPhoneNumber ="+6545321660",StudentEmailAddress="std2@insta.com",StudentNRIC="123457",StudentDateOfBirth=DateTime.Parse("1988-05-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std3",Surname = "std33",Gender = "M",StudentPhoneNumber ="+6545321770",StudentEmailAddress="std3@insta.com",StudentNRIC="123458",StudentDateOfBirth=DateTime.Parse("1992-04-05"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std4",Surname = "std44",Gender = "F",StudentPhoneNumber ="+6545321330",StudentEmailAddress="std4@insta.com",StudentNRIC="123459",StudentDateOfBirth=DateTime.Parse("1984-06-23"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std5",Surname = "std55",Gender = "M",StudentPhoneNumber ="+6545321770",StudentEmailAddress="std5@insta.com",StudentNRIC="123410",StudentDateOfBirth=DateTime.Parse("1983-04-22"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},

                new Student{GivenName="std6",Surname = "std114",Gender = "M",StudentPhoneNumber ="+6545321980",StudentEmailAddress="std6@insta.com",StudentNRIC="123436",StudentDateOfBirth=DateTime.Parse("1993-04-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std7",Surname = "std224",Gender = "F",StudentPhoneNumber ="+6545321560",StudentEmailAddress="std7@insta.com",StudentNRIC="123157",StudentDateOfBirth=DateTime.Parse("1982-05-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std8",Surname = "std334",Gender = "M",StudentPhoneNumber ="+6545323770",StudentEmailAddress="std8@insta.com",StudentNRIC="123558",StudentDateOfBirth=DateTime.Parse("1993-04-05"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std9",Surname = "std444",Gender = "F",StudentPhoneNumber ="+6545322330",StudentEmailAddress="std9@insta.com",StudentNRIC="123759",StudentDateOfBirth=DateTime.Parse("1981-06-23"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std10",Surname = "std554",Gender = "M",StudentPhoneNumber ="+6545381770",StudentEmailAddress="std10@insta.com",StudentNRIC="121410",StudentDateOfBirth=DateTime.Parse("1988-04-22"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},

                new Student{GivenName="std11",Surname = "std111",Gender = "M",StudentPhoneNumber ="+6545311980",StudentEmailAddress="std11@insta.com",StudentNRIC="123856",StudentDateOfBirth=DateTime.Parse("1992-04-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std12",Surname = "std222",Gender = "F",StudentPhoneNumber ="+6545361660",StudentEmailAddress="std22@insta.com",StudentNRIC="123957",StudentDateOfBirth=DateTime.Parse("1980-05-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std13",Surname = "std333",Gender = "M",StudentPhoneNumber ="+6545371770",StudentEmailAddress="std33@insta.com",StudentNRIC="122458",StudentDateOfBirth=DateTime.Parse("1994-04-05"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std14",Surname = "std444",Gender = "F",StudentPhoneNumber ="+6545331330",StudentEmailAddress="std44@insta.com",StudentNRIC="123859",StudentDateOfBirth=DateTime.Parse("1985-06-23"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std15",Surname = "std555",Gender = "M",StudentPhoneNumber ="+6545391770",StudentEmailAddress="std55@insta.com",StudentNRIC="123910",StudentDateOfBirth=DateTime.Parse("1991-04-22"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},

                new Student{GivenName="std16",Surname = "std117",Gender = "M",StudentPhoneNumber ="+6545721980",StudentEmailAddress="std14@insta.com",StudentNRIC="123956",StudentDateOfBirth=DateTime.Parse("1998-04-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std17",Surname = "std227",Gender = "F",StudentPhoneNumber ="+6545371660",StudentEmailAddress="std24@insta.com",StudentNRIC="123957",StudentDateOfBirth=DateTime.Parse("1987-05-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std18",Surname = "std337",Gender = "M",StudentPhoneNumber ="+6545291770",StudentEmailAddress="std34@insta.com",StudentNRIC="123258",StudentDateOfBirth=DateTime.Parse("1994-04-05"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std19",Surname = "std447",Gender = "F",StudentPhoneNumber ="+6545011330",StudentEmailAddress="std44@insta.com",StudentNRIC="123499",StudentDateOfBirth=DateTime.Parse("1987-06-23"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std20",Surname = "std557",Gender = "M",StudentPhoneNumber ="+6545591770",StudentEmailAddress="std54@insta.com",StudentNRIC="123440",StudentDateOfBirth=DateTime.Parse("1981-04-22"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},

                new Student{GivenName="std21",Surname = "std113",Gender = "M",StudentPhoneNumber ="+6545221980",StudentEmailAddress="std16@insta.com",StudentNRIC="123156",StudentDateOfBirth=DateTime.Parse("1998-04-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std22",Surname = "std223",Gender = "F",StudentPhoneNumber ="+6545621660",StudentEmailAddress="std26@insta.com",StudentNRIC="123457",StudentDateOfBirth=DateTime.Parse("1983-05-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std23",Surname = "std333",Gender = "M",StudentPhoneNumber ="+6545921770",StudentEmailAddress="std36@insta.com",StudentNRIC="122458",StudentDateOfBirth=DateTime.Parse("1999-04-05"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std24",Surname = "std443",Gender = "F",StudentPhoneNumber ="+6545121330",StudentEmailAddress="std46@insta.com",StudentNRIC="123409",StudentDateOfBirth=DateTime.Parse("1981-06-23"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Student{GivenName="std25",Surname = "std553",Gender = "M",StudentPhoneNumber ="+6545821770",StudentEmailAddress="std56@insta.com",StudentNRIC="123210",StudentDateOfBirth=DateTime.Parse("1985-04-22"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-02-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
            };
            foreach (Student r in students)
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    context.Students.Add(r);
                    context.SaveChanges();
                    dbContextTransaction.Commit();
                }
            }
        }
    }
}
