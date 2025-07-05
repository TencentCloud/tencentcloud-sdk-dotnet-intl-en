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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpStatus : AbstractModel
    {
        
        /// <summary>
        /// Node IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Node region
        /// </summary>
        [JsonProperty("District")]
        public string District{ get; set; }

        /// <summary>
        /// Node ISP
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// Node city
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// Node status
        /// online: the node is online and scheduling normally
        /// offline: the node is offline
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Node IP creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

