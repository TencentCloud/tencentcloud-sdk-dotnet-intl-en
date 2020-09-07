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

    public class CreateGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Group name, which is modifiable, must be unique, and can contain 1-60 characters.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Group ID, which is unmodifiable, must be unique, and can contain letters, digits, and special symbols (-%@#&_) of up to 64B.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Custom group description field that describes the person attributes in the group, which will be applied to all persons in the group. 
        /// Up to 5 ones can be created. 
        /// Each custom description field can contain 1-30 characters. 
        /// The custom description field must be unique in the group. 
        /// Example: if you set the "custom description field" of a group to ["student ID","employee ID","mobile number"], 
        /// then all the persons in the group will have description fields named "student ID", "employee ID", and "mobile number". 
        /// You can enter content in the corresponding field to register a person's student ID, employee ID, and mobile number.
        /// </summary>
        [JsonProperty("GroupExDescriptions")]
        public string[] GroupExDescriptions{ get; set; }

        /// <summary>
        /// Group remarks, which can contain 0-40 characters.
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// Algorithm model version used by the Face Recognition service. Valid values: 2.0, 3.0.
        /// This parameter is `3.0` by default starting from April 2, 2020. If it is left empty for accounts that used this API previously, `2.0` will be used by default. 
        /// Different algorithm model versions correspond to different face recognition algorithms. The 3.0 version has a better overall effect than the legacy version and is thus recommended.
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "GroupExDescriptions.", this.GroupExDescriptions);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
        }
    }
}

