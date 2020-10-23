/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Group ID, which is the `GroupId` in the `CreateGroup` API
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Custom description field of the group to be modified, which is a `key-value`
        /// </summary>
        [JsonProperty("GroupExDescriptionInfos")]
        public GroupExDescriptionInfo[] GroupExDescriptionInfos{ get; set; }

        /// <summary>
        /// Group remarks
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamArrayObj(map, prefix + "GroupExDescriptionInfos.", this.GroupExDescriptionInfos);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
        }
    }
}

