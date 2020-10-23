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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSubnetRequest : AbstractModel
    {
        
        /// <summary>
        /// The ID of the VPC instance to be operated on. You can obtain the parameter value from the VpcId field in the returned result of DescribeVpcs API.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The subnet name. The maximum length is 60 bytes.
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// The subnet IP address range. It must be within the VPC IP address range. Subnet IP address ranges cannot overlap with each other within the same VPC.
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// The ID of the availability zone in which the subnet resides. You can set up disaster recovery across availability zones by choosing different availability zones for different subnets.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Bound tags, such as [{"Key": "city", "Value": "shanghai"}].
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

