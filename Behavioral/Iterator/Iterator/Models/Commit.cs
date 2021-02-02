using System;

namespace Iterator.Models
{
    public class Commit
    {
        public int Id { get; set; }
        public string Hash { get; private set; }
        public string Message { get; set; }

        public Commit()
        {
            Hash = Guid.NewGuid().ToString();
        }
    }
}
