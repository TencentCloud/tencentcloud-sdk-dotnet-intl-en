/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class GetPersonGroupInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// List of groups containing this person and their description fields
        /// </summary>
        [JsonProperty("PersonGroupInfos")]
        public PersonGroupInfo[] PersonGroupInfos{ get; set; }

        /// <summary>
        /// Total number of groups
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupNum")]
        public ulong? GroupNum{ get; set; }

        /// <summary>
        /// Algorithm model version used by the Face Recognition service.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "PersonGroupInfos.", this.PersonGroupInfos);
            this.SetParamSimple(map, prefix + "GroupNum", this.GroupNum);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

