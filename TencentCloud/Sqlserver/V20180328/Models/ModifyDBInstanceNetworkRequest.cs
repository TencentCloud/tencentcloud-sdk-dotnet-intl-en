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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceNetworkRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// ID of the new VPC
        /// </summary>
        [JsonProperty("NewVpcId")]
        public string NewVpcId{ get; set; }

        /// <summary>
        /// ID of the new subnet
        /// </summary>
        [JsonProperty("NewSubnetId")]
        public string NewSubnetId{ get; set; }

        /// <summary>
        /// Retention period (in hours) of the original VIP. Value range: `0-168`. Default value: `0`, indicating the original VIP is released immediately.
        /// </summary>
        [JsonProperty("OldIpRetainTime")]
        public long? OldIpRetainTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NewVpcId", this.NewVpcId);
            this.SetParamSimple(map, prefix + "NewSubnetId", this.NewSubnetId);
            this.SetParamSimple(map, prefix + "OldIpRetainTime", this.OldIpRetainTime);
        }
    }
}

