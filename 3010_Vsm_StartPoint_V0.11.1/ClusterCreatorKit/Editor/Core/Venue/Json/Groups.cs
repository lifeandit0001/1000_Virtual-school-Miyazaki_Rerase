using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ClusterVR.CreatorKit.Editor.Core.Venue.Json
{
    [Serializable]
    public class Groups
    {
        [SerializeField] List<Group> groups;

        public List<Group> List => groups.OrderBy(x => x.GroupType).ToList();
    }
}
