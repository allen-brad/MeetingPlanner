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
                new Meeting{Date=DateTime.Parse("2018-12-02"), Invocation="Brother Grant", Announcements="Ward Party Dec 12th, Tithing Settlement Sign up", Choirister="Sister Musical",
                    Organist ="Sister Talented", Conducting="1", Presiding ="Bishop Wonderful", WardBusiness ="Tommy Jones advancement", StakeBusiness="none",
                    OpenHymn ="212 Far, Far Away on Judea's Plains",
                    SacHymn ="212 Far, Far Away on Judea's Plains",
                    IntHymn ="212 Far, Far Away on Judea's Plains",
                    CloseHymn ="203 Angels We Have Heard on High",
                    TalkName1 ="Brother Abbott", TalkSubj1 = "Prayer",
                    TalkName2 ="Brother Chang", TalkSubj2 = "Christ in our daily lives",
                    TalkName3 ="Sister Blumel", TalkSubj3 = "Scripture Study",
                    TalkName4 ="Brother Abbott", TalkSubj4 = "Prayer",
                    TalkName5 ="Brother Abbott", TalkSubj5 = "Prayer",
                    Benediction ="Sister Albrecht"},
                new Meeting{Date=DateTime.Parse("2018-12-09"), Invocation="Brother Rigby", Announcements="Ward Party Dec 12th", Choirister="Sister Musical", Organist="Sister Talented",
                    Conducting ="2", Presiding ="Bishop Wonderful", WardBusiness="none", StakeBusiness="none",
                    OpenHymn ="212 Far, Far Away on Judea's Plains",
                    SacHymn ="212 Far, Far Away on Judea's Plains",
                    IntHymn ="212 Far, Far Away on Judea's Plains",
                    CloseHymn ="203 Angels We Have Heard on High",
                    TalkName1 ="Brother Abbott", TalkSubj1 = "Prayer",
                    TalkName2 ="Brother Chang", TalkSubj2 = "Christ in our daily lives",
                    TalkName3 ="Sister Blumel", TalkSubj3 = "Scripture Study",
                    TalkName4 ="Brother Abbott", TalkSubj4 = "Prayer",
                    TalkName5 ="Brother Abbott", TalkSubj5 = "Prayer",
                    Benediction ="Sister Flores"},
                new Meeting{Date=DateTime.Parse("2018-12-16"), Invocation="Sister Pratt", Announcements="Great turnout at Ward Party - thanks!", Choirister="Sister Musical", Organist="Sister Talented", Conducting="3",
                    Presiding ="Bishop Wonderful", WardBusiness="Lilly laurel advancement", StakeBusiness="none",
                    OpenHymn ="212 Far, Far Away on Judea's Plains",
                    SacHymn ="212 Far, Far Away on Judea's Plains",
                    IntHymn ="212 Far, Far Away on Judea's Plains",
                    CloseHymn ="203 Angels We Have Heard on High",
                    TalkName1 ="Brother Abbott", TalkSubj1 = "Prayer",
                    TalkName2 ="Brother Chang", TalkSubj2 = "Christ in our daily lives",
                    TalkName3 ="Sister Blumel", TalkSubj3 = "Share Testimony",
                    TalkName4 ="", TalkSubj4 = "",
                    TalkName5 ="", TalkSubj5 = "",
                    Benediction ="Brother Allen"},
                new Meeting{Date=DateTime.Parse("2018-12-23"), Invocation="Brother Jones", Announcements="none", Choirister="Sister Musical", Organist="Sister Talented", Conducting="4",
                    Presiding ="Bishop Wonderful", WardBusiness="none", StakeBusiness="none",
                    OpenHymn ="212 Far, Far Away on Judea's Plains",
                    SacHymn ="212 Far, Far Away on Judea's Plains",
                    IntHymn ="212 Far, Far Away on Judea's Plains",
                    CloseHymn ="203 Angels We Have Heard on High",
                    TalkName1 ="Testimony Meeting", TalkSubj1 = "",
                    TalkName2 ="", TalkSubj2 = "",
                    TalkName3 ="", TalkSubj3 = "",
                    TalkName4 ="", TalkSubj4 = "",
                    TalkName5 ="", TalkSubj5 = "",
                    Benediction ="Sister Smith"},
                new Meeting{Date=DateTime.Parse("2018-12-30"), Invocation="Sister Newday", Announcements="Donations must be received by 12/31 in order to count for 2018", Choirister="Sister Musical", Organist="Sister Talented", Conducting="5",
                    Presiding ="Bishop Wonderful", WardBusiness="none", StakeBusiness="none",
                    OpenHymn ="212 Far, Far Away on Judea's Plains",
                    SacHymn ="212 Far, Far Away on Judea's Plains",
                    IntHymn ="212 Far, Far Away on Judea's Plains",
                    CloseHymn ="203 Angels We Have Heard on High",
                    TalkName1 ="Brother Chase", TalkSubj1 = "Prayer",
                    TalkName2 ="Sister Chase", TalkSubj2 = "Christ in our daily lives",
                    TalkName3 ="", TalkSubj3 = "",
                    TalkName4 ="", TalkSubj4 = "",
                    TalkName5 ="", TalkSubj5 = "",
                    Benediction ="Brother Chantry"},
            };
            foreach (Meeting m in meetings)
            {
                context.Meeting.Add(m);
            }
            context.SaveChanges();

            var bishopricMembers = new Bishopric[]
            {
                new Bishopric { name = "Bishop Abercrombie",
                    position = "Bishop, Bishopric" },
                new Bishopric { name = "John Doe",
                    position = "1st Counselor, Bishopric" },
                new Bishopric { name = "Terry Kirkland",
                    position = "2nd Counselor, Bishopric" },
                new Bishopric { name ="Dean Perkins",
                    position = "Elders Quorum President" },
                new Bishopric { name= "Mark Christensen",
                    position = "Stake President" }
            };

            foreach (Bishopric i in bishopricMembers)
            {
                context.Bishopric.Add(i);
            }
            context.SaveChanges();

        }
    }
}
