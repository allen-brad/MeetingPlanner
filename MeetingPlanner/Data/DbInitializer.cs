using System;
using System.Linq;
using MeetingPlanner.Models;

namespace MeetingPlanner.Models
{
    public static class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            //Look for any meetings
            if (context.Meeting.Any())
            {
                return; //DB has already been seeded
            }

            var meetings = new Meeting[]
            {
                new Meeting{MeetingID=1001, Date=DateTime.Parse("2018-12-02"), Invocation="Brother Grant", Announcements="Ward Party Dec 12th, Tithing Settlement Sign up", Choirister="Sister Musical",
                    Organist ="Sister Talented", Conducting="Brother Counselor", Presiding ="Bishop Wonderful", WardBusiness ="Tommy Jones advancement", StakeBusiness="none", Benediction="Sister Albrecht"},
                new Meeting{MeetingID=1002, Date=DateTime.Parse("2018-12-09"), Invocation="Brother Rigby", Announcements="Ward Party Dec 12th", Choirister="Sister Musical", Organist="Sister Talented",
                    Conducting ="Brother Counselor", Presiding ="Bishop Wonderful", WardBusiness="none", StakeBusiness="none", Benediction="Sister Flores"},
                new Meeting{MeetingID=1003, Date=DateTime.Parse("2018-12-16"), Invocation="Sister Pratt", Announcements="Great turnout at Ward Party - thanks!", Choirister="Sister Musical", Organist="Sister Talented", Conducting="Brother Counselor",
                    Presiding ="Bishop Wonderful", WardBusiness="Lilly laurel advancement", StakeBusiness="none", Benediction="Brother Allen"},
                new Meeting{MeetingID=1004, Date=DateTime.Parse("2018-12-23"), Invocation="Brother Jones", Announcements="none", Choirister="Sister Musical", Organist="Sister Talented", Conducting="Brother Counselor",
                    Presiding ="Bishop Wonderful", WardBusiness="none", StakeBusiness="none", Benediction="Sister Smith"},
                new Meeting{MeetingID=1005, Date=DateTime.Parse("2018-12-30"), Invocation="Sister Newday", Announcements="Donations must be received by 12/31 in order to count for 2018", Choirister="Sister Musical", Organist="Sister Talented", Conducting="Brother Counselor",
                    Presiding ="Bishop Wonderful", WardBusiness="none", StakeBusiness="none", Benediction="Brother Chantry"},
            };
            foreach (Meeting m in meetings)
            {
                context.Meeting.Add(m);
            }
            context.SaveChanges();

            var musicalnumbers = new MusicalNumber[]
            {
                new MusicalNumber{MusicalNumberID=1001, MeetingID=1001, Description= "Opening Hymn", HymnNumber=203, Title="Angels We Have Heard on High"},
                new MusicalNumber{MusicalNumberID=1002, MeetingID=1001, Description= "Sacrament Hymn", HymnNumber=176, Title="'Tis Sweet to Sing the Matchless Love"},
                new MusicalNumber{MusicalNumberID=1003, MeetingID=1001, Description= "Closing Hymn", HymnNumber=206, Title="Away in a Manger"},

                new MusicalNumber{MusicalNumberID=1004, MeetingID=1002, Description= "Opening Hymn", HymnNumber=212, Title="Far, Far Away on Judea's Plains"},
                new MusicalNumber{MusicalNumberID=1005, MeetingID=1002, Description= "Sacrament Hymn", HymnNumber=169, Title="As Now We Take the Sacrament"},
                new MusicalNumber{MusicalNumberID=1006, MeetingID=1002, Description= "Closing Hymn", HymnNumber=209, Title="Hark! The Herald Angels Sing"},
            };
        }
    }
}
