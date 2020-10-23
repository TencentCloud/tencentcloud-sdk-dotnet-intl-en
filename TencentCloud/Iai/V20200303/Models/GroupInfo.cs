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

    public class GroupInfo : AbstractModel
    {
        
        /// <summary>
        /// Group name
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Group ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Custom group description field
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupExDescriptions")]
        public string[] GroupExDescriptions{ get; set; }

        /// <summary>
        /// Group remarks
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// Algorithm model version used for face recognition.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// Group creation time and date (`CreationTimestamp`), whose value is the number of milliseconds between the UNIX epoch time and the group creation time. 
        /// The UNIX epoch time is 00:00:00, Thursday, January 1, 1970, Coordinated Universal Time (UTC). For more information, please see the UNIX time document.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreationTimestamp")]
        public ulong? CreationTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "GroupExDescriptions.", this.GroupExDescriptions);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "CreationTimestamp", this.CreationTimestamp);
        }
    }
}

