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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllNodeResourceSpec : AbstractModel
    {
        
        /// <summary>
        /// The description of master nodes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MasterResourceSpec")]
        public NodeResourceSpec MasterResourceSpec{ get; set; }

        /// <summary>
        /// The description of core nodes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoreResourceSpec")]
        public NodeResourceSpec CoreResourceSpec{ get; set; }

        /// <summary>
        /// The description of task nodes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskResourceSpec")]
        public NodeResourceSpec TaskResourceSpec{ get; set; }

        /// <summary>
        /// The description of common nodes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CommonResourceSpec")]
        public NodeResourceSpec CommonResourceSpec{ get; set; }

        /// <summary>
        /// Number of Master nodes.
        /// </summary>
        [JsonProperty("MasterCount")]
        public long? MasterCount{ get; set; }

        /// <summary>
        /// Number of core nodes.
        /// </summary>
        [JsonProperty("CoreCount")]
        public long? CoreCount{ get; set; }

        /// <summary>
        /// Number of task nodes.
        /// </summary>
        [JsonProperty("TaskCount")]
        public long? TaskCount{ get; set; }

        /// <summary>
        /// Number of common nodes.
        /// </summary>
        [JsonProperty("CommonCount")]
        public long? CommonCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MasterResourceSpec.", this.MasterResourceSpec);
            this.SetParamObj(map, prefix + "CoreResourceSpec.", this.CoreResourceSpec);
            this.SetParamObj(map, prefix + "TaskResourceSpec.", this.TaskResourceSpec);
            this.SetParamObj(map, prefix + "CommonResourceSpec.", this.CommonResourceSpec);
            this.SetParamSimple(map, prefix + "MasterCount", this.MasterCount);
            this.SetParamSimple(map, prefix + "CoreCount", this.CoreCount);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "CommonCount", this.CommonCount);
        }
    }
}

