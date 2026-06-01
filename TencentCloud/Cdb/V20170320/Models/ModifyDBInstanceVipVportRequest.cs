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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceVipVportRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv, cdbro-c2nl9rpv, or cdbrg-c3nl9rpv. It is the same as the instance ID displayed on the TencentDB Console page. You can use the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872) API to query the ID, which is the value of the `InstanceId` output parameter.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Target IP address.
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// Destination port. Support scope: [1024-65535].
        /// </summary>
        [JsonProperty("DstPort")]
        public long? DstPort{ get; set; }

        /// <summary>
        /// Unified VPC ID
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Unified subnet ID
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Repossession duration in hours for old IP in the original network when changing from classic network to VPC or changing the VPC subnet. Value range: 0–168. Default value: `24`.
        /// </summary>
        [JsonProperty("ReleaseDuration")]
        public long? ReleaseDuration{ get; set; }

        /// <summary>
        /// When updating the read-only group of a cluster edition instance, specify the instance id in InstanceId and this parameter is required to indicate the operation is for the read-only group. If you perform the operation on the read-write node, this parameter is not required.
        /// </summary>
        [JsonProperty("OpResourceId")]
        public string OpResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ReleaseDuration", this.ReleaseDuration);
            this.SetParamSimple(map, prefix + "OpResourceId", this.OpResourceId);
        }
    }
}

