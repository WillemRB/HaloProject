using System;

namespace HaloProject.Common
{
    public class Spartan
    {
        #region Information
        public string GamerTag { get; set; }
        #endregion

        #region Internal
        public bool QueuedForUpdate { get; set; }

        public DateTime LastUpdate { get; set; }
        #endregion
    }
}
