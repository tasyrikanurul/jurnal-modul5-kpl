using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302201131
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public string tubeuser;
        private object playCount;

        public SayaTubeUser(string tubeuser)
        {
            this.tubeuser = tubeuser;
        }

       
        public GetTotalVideoPlayCount()
        {
            return playCount;
        }
            
        
    }
}
