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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Groups : AbstractModel
    {
        
        /// <summary>
        /// User APPID, which is the unique application ID that matches an account. Some Tencent Cloud products use this APPID.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Region ID.
        ///  - 1: Guangzhou.
        ///  - 4: Shanghai.
        ///  - 5: Hong Kong (China).
        ///  - 7: Shanghai Finance.
        ///  - 8: Beijing.
        ///  - 9: Singapore.
        ///  - 11: Shenzhen Finance.
        ///  - 15: Western US (Silicon Valley).
        ///  - 16: Chengdu.
        ///  - 17: Germany.
        ///  - 18: South Korea.
        ///  - 19: Chongqing.
        ///  - 22: Eastern US (Virginia).
        ///  - 23: Thailand.
        /// - 25: Japan.
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// Replication group ID in the format of "crs-rpl-deind****"
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Replication group name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Status of replication group
        /// - `37`: Associating replication group
        /// - `38`: Reconnecting to replication group
        /// - `51`: Disassociating replication group
        /// - `52`: Switching with master instance in replication group
        /// - `53`: Modifying the roles
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Number of replication groups
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// Instance information on the replication group.
        /// </summary>
        [JsonProperty("Instances")]
        public Instances[] Instances{ get; set; }

        /// <summary>
        /// Remark information.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamArrayObj(map, prefix + "Instances.", this.Instances);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

