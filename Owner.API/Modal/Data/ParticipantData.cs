using System.Collections.Generic;

namespace Owner.API.Modal.Data
{
    public class ParticipantData
    {
        public List<Participant> GetAllParticipant()
        {
            return new List<Participant>
            {
                new Participant
                {
                    Id = 54,
                    Name= "Elisabeth",
                    Surname="Star",
                    Date="24.10.2022",
                    Description="CEO of Starlink Ins.",
                    Type="VIP member"

                },

                 new Participant
                {
                    Id = 78,
                    Name= "Tim",
                    Surname="Iron",
                    Date="25.10.2022",
                    Description="IK of Moon Ins.",
                    Type="GOLD member"

                },

                 new Participant
                {
                    Id = 98,
                    Name= "Klaus",
                    Surname="Mikealson",
                    Date="28.10.2022",
                    Description="Head of IT Department",
                    Type="SILVER member"

                }

            };
        }

    }
}
