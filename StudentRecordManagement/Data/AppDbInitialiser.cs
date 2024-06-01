using StudentRecordManagement.Models.Entities;
using StudentRecordManagement.Models.Entities.Forms;
using StudentRecordManagement.Models.Entities.People;

namespace StudentRecordManagement.Data
{
    public class AppDbInitialiser
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDBContext>();

                context.Database.EnsureCreated();

                // Student
                if (context.Students.Any() || context.Staff.Any() || context.ParentContacts.Any()) return;

                var parentContacts = new List<ParentContact>
                {
                    new ParentContact
                    {
                        Firstname = "Lily",
                        Surname = "AKENFIELD",
                        Email="",
                        Phone="",
                        Address=""
                    },
                    new ParentContact
                    {
                        Firstname = "Mia",
                        Surname = "AKERS",
                        Email="",
                        Phone="",
                        Address=""
                    },
                    new ParentContact
                    {
                        Firstname = "Elijah",
                        Surname = "KLINE",
                        Email="",
                        Phone="",
                        Address=""
                    },
                    new ParentContact
                    {
                        Firstname = "Brooklyn",
                        Surname = "ALAM",
                        Email="",
                        Phone="",
                        Address=""
                    },
                    new ParentContact
                    {
                        Firstname = "Blake",
                        Surname = "ALDERSON",
                        Email="",
                        Phone="",
                        Address=""
                    },
                    new ParentContact
                    {
                        Firstname = "Paisley",
                        Surname = "ALEXANDER",
                        Email="",
                        Phone="",
                        Address=""
                    },
                    new ParentContact
                    {
                        Firstname = "Cole",
                        Surname = "ALLEN",
                        Email="",
                        Phone="",
                        Address=""
                    },
                    new ParentContact
                    {
                        Firstname = "Elizabeth",
                        Surname = "ALLISON",
                        Email="",
                        Phone="",
                        Address=""
                    },
                    new ParentContact
                    {
                        Firstname = "Eric",
                        Surname = "ALTMAN",
                        Email="",
                        Phone="",
                        Address=""
                    }
                };

                foreach (ParentContact p in parentContacts)
                {
                    p.Email = "104358130@student.swin.edu.au";
                }

                var students = new List<Student>
                {
                    new Student
                    {
                        Firstname = "Samantha",
                        Surname = "AKENFIELD",
                        Email="",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        PreferredName="Sam",
                        Year="8",
                        DOB=DateTime.Parse("20/09/2010"),
                        Gender='F',
                        ParentContact = parentContacts[0]
                    },
                    new Student
                    {
                        Firstname = "Julie",
                        Surname = "AKERS",
                        Email="",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        PreferredName="Julie",
                        Year="7",
                        DOB=DateTime.Parse("11/09/2011"),
                        Gender='F',
                        ParentContact = parentContacts[1]
                    },                  
                    new Student
                    {
                        Firstname = "Kevin",
                        Surname = "KLINE",
                        Email="",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        PreferredName="Kev",
                        Year="8",
                        DOB=DateTime.Parse("20/09/2010"),
                        Gender='M',
                        ParentContact = parentContacts[2]
                    },
                    new Student
                    {
                        Firstname = "Denise",
                        Surname = "ALAM",
                        Email="",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        PreferredName="Denise",
                        Year="6",
                        DOB=DateTime.Parse("20/08/2012"),
                        Gender='F',
                        ParentContact = parentContacts[3]
                    },
                    new Student
                    {
                        Firstname = "Roger",
                        Surname = "ALDERSON",
                        Email="",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        PreferredName="Roger",
                        Year="8",
                        DOB=DateTime.Parse("20/09/2010"),
                        Gender='M',
                        ParentContact = parentContacts[4]
                    },
                    new Student
                    {
                        Firstname = "Kim",
                        Surname = "ALEXANDER",
                        Email="",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        PreferredName="Kim",
                        Year="8",
                        DOB=DateTime.Parse("20/09/2010"),
                        Gender='F',
                        ParentContact = parentContacts[5]
                    },
                    new Student
                    {
                        Firstname = "Sandy",
                        Surname = "ALLEN",
                        Email="",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        PreferredName="Kev",
                        Year="8",
                        DOB=DateTime.Parse("20/09/2010"),
                        Gender='F',
                        ParentContact = parentContacts[6]
                    },
                    new Student
                    {
                        Firstname = "Penny",
                        Surname = "ALLISON",
                        Email="",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        PreferredName="Penny",
                        Year="8",
                        DOB=DateTime.Parse("20/09/2010"),
                        Gender='F',
                        ParentContact = parentContacts[7]
                    },
                    new Student
                    {
                        Firstname = "Robert",
                        Surname = "ALTMAN",
                        Email="",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        PreferredName="Robert",
                        Year="8",
                        DOB=DateTime.Parse("20/09/2010"),
                        Gender='M',
                        ParentContact = parentContacts[8]
                    }
                };

                var staff = new List<Staff>
                {
                    new Staff
                    {
                        Firstname = "Andrew",
                        Surname = "Johnston",
                        Email="Andrew_Johnston@studentrecordmanagement.com",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        StaffGroupMask = (int) StaffGroupBit.Teacher + (int) StaffGroupBit.HOD + (int) StaffGroupBit.MedicalOfficer
                    },
                    new Staff
                    {
                        Firstname = "Brendan",
                        Surname = "Cawdy",
                        Email="Brendan_Cawdy@studentrecordmanagement.com",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        StaffGroupMask = (int) StaffGroupBit.Teacher
                    },
                    new Staff
                    {
                        Firstname = "Bernard",
                        Surname = "Hubert",
                        Email="Bernard_Hubert@studentrecordmanagement.com",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        StaffGroupMask = (int) StaffGroupBit.TeacherAide
                    },
                    new Staff
                    {
                        Firstname = "Bernie",
                        Surname = "McHugh",
                        Email="Bernie_McHugh@studentrecordmanagement.com",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        StaffGroupMask = (int) StaffGroupBit.Teacher + (int) StaffGroupBit.Admin
                    },
                    new Staff
                    {
                        Firstname = "Bruce",
                        Surname = "Pick",
                        Email="Bruce_Pick@studentrecordmanagement.com",
                        Phone="",
                        Address="",
                        Created= DateTime.Now,
                        Modified=DateTime.Now,
                        StaffGroupMask = (int) StaffGroupBit.TeacherReplacement
                    },

                };

                var detentions = new List<Detention>
                {
                    new Detention
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[0],
                        PredefinedReasons = PredefinedReasons.Uniform,
                        DetentionTime = DetentionTime.BeforeSchool,
                        Status = DetentionStatus.NonProcessed
                    },
                    new Detention
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[1],
                        PredefinedReasons = PredefinedReasons.Behaviour,
                        BreachReason = "say bad words to a teacher",
                        DetentionTime = DetentionTime.LunchTime,
                        Status = DetentionStatus.NonProcessed
                    },
                    new Detention
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[2],
                        PredefinedReasons = PredefinedReasons.Late,
                        DetentionTime = DetentionTime.LunchTime,
                        Status = DetentionStatus.DetentionCompleted
                    }
                };


                var leavePassRecords = new List<LeavePass>
                {
                    new LeavePass
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[0],
                        Reason = AbsentReason.Family,
                        SignOutDateTime = new DateTime(2024,05,13,9,30,00)
                    },
                    new LeavePass
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[1],
                        Reason = AbsentReason.Unexplained,
                        SignOutDateTime = new DateTime(2024,05,14,11,30,00)
                    },
                    new LeavePass
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[2],
                        Reason = AbsentReason.Sick,
                        SignOutDateTime = new DateTime(2024,05,15,10,45,00)
                    }
                };

                var latePassRecords = new List<LatePass>
                {
                    new LatePass
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[0],
                        Reason = AbsentReason.Unexplained,
                        SignInDateTime = new DateTime(2024,05,13,9,00,00)
                    },
                    new LatePass
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[1],
                        Reason = AbsentReason.Sick,
                        SignInDateTime = new DateTime(2024,05,14,9,00,00)
                    },
                    new LatePass
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[2],
                        Reason = AbsentReason.Family,
                        SignInDateTime = new DateTime(2024,05,15,9,00,00)
                    }
                };

                var sickBayRecords = new List<SickBay> {
                    new SickBay
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[8],
                        Status = SickBayStatus.SickBayIn,
                        TimeIn = new DateTime(2024,05,12,9,30,00),
                        SickBayReason = SickBayReason.Injured
                    },
                    new SickBay
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[7],
                        Status = SickBayStatus.SickBayOut,
                        TimeIn = new DateTime(2024,05,12,11,30,00),
                        SickBayReason = SickBayReason.Sick,
                        Treatment = "Panadol Extra",
                        TimeOut = new DateTime(2024,05,12,14,20,00),
                        SickBayOutAction = SickBayOutAction.GoingHome,
                        ParentContacted =  true,
                        MedicalOfficer = staff[0]
                    },
                    new SickBay
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        RecordDate = DateTime.Now,
                        Student = students[6],
                        Status = SickBayStatus.SickBayOut,
                        TimeIn = new DateTime(2024,05,12,12,20,00),
                        SickBayReason = SickBayReason.Injured,
                        TimeOut = new DateTime(2024,05,12,15,40,00),
                        SickBayOutAction = SickBayOutAction.ReturnToClass,
                        ParentContacted =  false,
                        MedicalOfficer = staff[0]
                    }
                };

                context.Students.AddRange(students);
                context.Staff.AddRange(staff);
                context.ParentContacts.AddRange(parentContacts);
                context.DetentionRecords.AddRange(detentions);
                context.SickBayRecords.AddRange(sickBayRecords);
                context.LeavePassRecords.AddRange(leavePassRecords);
                context.LatePassRecords.AddRange(latePassRecords);
                context.SaveChanges();
            }
        }
    }
}
