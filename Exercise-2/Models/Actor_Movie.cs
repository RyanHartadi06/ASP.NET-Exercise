﻿namespace Exercise_2.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        public int ActorId { get; set; }
        //RELATIONSHIP
        public Actor? Actor { get; set; }
    }
}
