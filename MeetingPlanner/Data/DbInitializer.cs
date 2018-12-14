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
                    Organist ="Sister Talented", Conducting="Brother Counselor", Presiding ="Bishop Wonderful", WardBusiness ="Tommy Jones advancement", StakeBusiness="none",
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
                    Conducting ="Brother Counselor", Presiding ="Bishop Wonderful", WardBusiness="none", StakeBusiness="none",
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
                new Meeting{Date=DateTime.Parse("2018-12-16"), Invocation="Sister Pratt", Announcements="Great turnout at Ward Party - thanks!", Choirister="Sister Musical", Organist="Sister Talented", Conducting="Brother Counselor",
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
                new Meeting{Date=DateTime.Parse("2018-12-23"), Invocation="Brother Jones", Announcements="none", Choirister="Sister Musical", Organist="Sister Talented", Conducting="Brother Counselor",
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
                new Meeting{Date=DateTime.Parse("2018-12-30"), Invocation="Sister Newday", Announcements="Donations must be received by 12/31 in order to count for 2018", Choirister="Sister Musical", Organist="Sister Talented", Conducting="Brother Counselor",
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

            var musicalnumbers = new MusicalNumber[]
            {
                new MusicalNumber{MeetingID=1, Description= "Opening Hymn", HymnNumber=203, Title="Angels We Have Heard on High", SortOrder=1},
                new MusicalNumber{MeetingID=1, Description= "Sacrament Hymn", HymnNumber=176, Title="'Tis Sweet to Sing the Matchless Love",SortOrder=2},
                new MusicalNumber{MeetingID=1, Description= "Closing Hymn", HymnNumber=206, Title="Away in a Manger", SortOrder=3},

                new MusicalNumber{MeetingID=2, Description= "Opening Hymn", HymnNumber=212, Title="Far, Far Away on Judea's Plains", SortOrder=1},
                new MusicalNumber{MeetingID=2, Description= "Sacrament Hymn", HymnNumber=169, Title="As Now We Take the Sacrament", SortOrder=2},
                new MusicalNumber{MeetingID=2, Description= "Closing Hymn", HymnNumber=209, Title="Hark! The Herald Angels Sing", SortOrder=4},
                new MusicalNumber{MeetingID=2, Description= "Intermediate Hymn", HymnNumber=134, Title="I Belive In Christ", SortOrder=3},

                new MusicalNumber{MeetingID=3, Description= "Opening Hymn", HymnNumber=202, Title="Oh, Come, All Ye Faithful", SortOrder=1},
                new MusicalNumber{MeetingID=3, Description= "Sacrament Hymn", HymnNumber=172, Title="In Humility, Our Savior", SortOrder=2},
                new MusicalNumber{MeetingID=3, Description= "Closing Hymn", HymnNumber=208, Title="O Little Town of Bethlehem", SortOrder=4},
                new MusicalNumber{MeetingID=3, Description= "Intermediate Hymn", HymnNumber=210, Title="With Wondering Awe", SortOrder=3},

                new MusicalNumber{MeetingID=4, Description= "Opening Hymn", HymnNumber=201, Title="Joy to the World", SortOrder=1},
                new MusicalNumber{MeetingID=4, Description= "Sacrament Hymn", HymnNumber=196, Title="Jesus, Once of Humble Birth", SortOrder=2},
                new MusicalNumber{MeetingID=4, Description= "Closing Hymn", HymnNumber=214, Title="I heard the Bells on Christmas Day", SortOrder=6},
                new MusicalNumber{MeetingID=4, Description= "Intermediate Hymn", HymnNumber=210, Title="With Wondering Awe", SortOrder=3},
                new MusicalNumber{MeetingID=4, Description= "Other", Performers="Men's Choir", Accompaniement="Siter Chopin", Title="Sing We Now of Christmas", SortOrder=4},
                new MusicalNumber{MeetingID=4, Description= "Other", Performers="Primary Children", Accompaniement="Siter Pearly Whites", Title="The Shepherd's Carol", SortOrder=5},

                new MusicalNumber{MeetingID=5, Description= "Opening Hymn", HymnNumber=217, Title="Come, Let Us Anew", SortOrder=1},
                new MusicalNumber{MeetingID=5, Description= "Sacrament Hymn", HymnNumber=172, Title="In Humility, Our Savior", SortOrder=2},
                new MusicalNumber{MeetingID=5, Description= "Closing Hymn", HymnNumber=37, Title="the Wintry Day, Descending to Its Close", SortOrder=4},
                new MusicalNumber{MeetingID=5, Description= "Intermediate Hymn", HymnNumber=215, Title="Ring Out, Wild Bells", SortOrder=3},
            };
            foreach (MusicalNumber n in musicalnumbers)
            {
                context.MusicalNumber.Add(n);
            }
            context.SaveChanges();

            var talks = new Talk[]
            {
                new Talk{MeetingID=2, SortOrder=1, Topic="Gifts", SpeakerFirstName="Billy",SpeakerLastName="Jones",Accepted=true,Assigned=true},
                new Talk{MeetingID=2, SortOrder=2, Topic="Taking the Name of Christ Upon Us", SpeakerFirstName="Erin",SpeakerLastName="Smith",Accepted=true,Assigned=true},
                new Talk{MeetingID=2, SortOrder=3, Topic="Taking the Name of Christ Upon Us", SpeakerFirstName="Cathrine",SpeakerLastName="Flores",Accepted=true,Assigned=true},

                new Talk{MeetingID=3, SortOrder=1, Topic="Gifts", SpeakerFirstName="Sally",SpeakerLastName="Douglas",Accepted=true,Assigned=true},
                new Talk{MeetingID=3, SortOrder=2, Topic="Wise Men Still Seek Him", SpeakerFirstName="Jason",SpeakerLastName="Chantry",Accepted=true,Assigned=true},
                new Talk{MeetingID=3, SortOrder=3, Topic="Wise Men Still Seek Him", SpeakerFirstName="Brad",SpeakerLastName="Allen",Accepted=true,Assigned=true},

                new Talk{MeetingID=4, SortOrder=1, Topic="What the Wise Men Knew", SpeakerFirstName="Gary",SpeakerLastName="James",Accepted=false,Assigned=false},
                new Talk{MeetingID=4, SortOrder=2, Topic="The Gift's Christ Gave Us", SpeakerFirstName="Jean",SpeakerLastName="Johnson",Accepted=true,Assigned=true},
                new Talk{MeetingID=4, SortOrder=3, Topic="What will we give to Christ?", SpeakerFirstName="Bishop",SpeakerLastName="Wonderful",Accepted=true,Assigned=true},

                new Talk{MeetingID=5, SortOrder=1, Topic="Goals", SpeakerFirstName="Tim",SpeakerLastName="Jones",Accepted=false,Assigned=false},
                new Talk{MeetingID=5, SortOrder=2, Topic="The Dauntless Spirit of Resolution", SpeakerFirstName="Keith",SpeakerLastName="Seiter",Accepted=true,Assigned=true},
                new Talk{MeetingID=5, SortOrder=3, Topic="Endure to End", SpeakerFirstName="Walt",SpeakerLastName="Goodfella",Accepted=true,Assigned=true},

            };
            foreach (Talk t in talks)
            {
                context.Talk.Add(t);
            };
            context.SaveChanges();

            var testimony = new Testimonies {MeetingID=1 };
            context.Testimonies.Add(testimony);
            context.SaveChanges();
        }
    }
}
