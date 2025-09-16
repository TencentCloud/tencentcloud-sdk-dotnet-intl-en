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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceLimit : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable throttling and speed limit at the instance level. Valid values: true and false. If the value is true, InstanceRpsLimit is required. If the value is false, InstanceRpsLimit does not take effect.
        /// </summary>
        [JsonProperty("EnableInstanceRpsLimit")]
        public bool? EnableInstanceRpsLimit{ get; set; }

        /// <summary>
        /// Speed limit for the requests per second (RPS) of each service instance. 0 indicates no throttling.
        /// </summary>
        [JsonProperty("InstanceRpsLimit")]
        public long? InstanceRpsLimit{ get; set; }

        /// <summary>
        /// Whether to enable the maximum concurrency quantity limit for a single instance. Valid values: true and false. If the value is true, InstanceReqLimit is required. If the value is false, InstanceReqLimit does not take effect.
        /// </summary>
        [JsonProperty("EnableInstanceReqLimit")]
        public bool? EnableInstanceReqLimit{ get; set; }

        /// <summary>
        /// Maximum concurrency for each service instance.
        /// </summary>
        [JsonProperty("InstanceReqLimit")]
        public long? InstanceReqLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableInstanceRpsLimit", this.EnableInstanceRpsLimit);
            this.SetParamSimple(map, prefix + "InstanceRpsLimit", this.InstanceRpsLimit);
            this.SetParamSimple(map, prefix + "EnableInstanceReqLimit", this.EnableInstanceReqLimit);
            this.SetParamSimple(map, prefix + "InstanceReqLimit", this.InstanceReqLimit);
        }
    }
}

