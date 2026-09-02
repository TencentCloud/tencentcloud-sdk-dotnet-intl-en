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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmIp : AbstractModel
    {
        
        /// <summary>
        /// IP address
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// ip type. public: public network; private: private network
        /// </summary>
        [JsonProperty("IpType")]
        public string IpType{ get; set; }

        /// <summary>
        /// ip tag information
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Whether it has been tagged with information
        /// </summary>
        [JsonProperty("IsRemarked")]
        public long? IsRemarked{ get; set; }

        /// <summary>
        /// ip belongs to the instance id
        /// </summary>
        [JsonProperty("ResourceInstanceId")]
        public string ResourceInstanceId{ get; set; }

        /// <summary>
        /// ip-associated product
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// ip region
        /// </summary>
        [JsonProperty("Area")]
        public DspmArea Area{ get; set; }

        /// <summary>
        /// Whether it is a new ip address
        /// </summary>
        [JsonProperty("IsNewIp")]
        public long? IsNewIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "IpType", this.IpType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "IsRemarked", this.IsRemarked);
            this.SetParamSimple(map, prefix + "ResourceInstanceId", this.ResourceInstanceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamObj(map, prefix + "Area.", this.Area);
            this.SetParamSimple(map, prefix + "IsNewIp", this.IsNewIp);
        }
    }
}

