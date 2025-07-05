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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAssistantCidrRequest : AbstractModel
    {
        
        /// <summary>
        /// `VPC` instance `ID`, such as `vpc-6v2ht8q5`.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Array of the secondary CIDR blocks to be added, such as ["10.0.0.0/16", "172.16.0.0/16"]. At least one of `NewCidrBlocks` and `OldCidrBlocks` must be specified.
        /// </summary>
        [JsonProperty("NewCidrBlocks")]
        public string[] NewCidrBlocks{ get; set; }

        /// <summary>
        /// Array of the secondary CIDR blocks to be deleted, such as ["10.0.0.0/16", "172.16.0.0/16"]. At least one of `NewCidrBlocks` or `OldCidrBlocks` must be specified.
        /// </summary>
        [JsonProperty("OldCidrBlocks")]
        public string[] OldCidrBlocks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "NewCidrBlocks.", this.NewCidrBlocks);
            this.SetParamArraySimple(map, prefix + "OldCidrBlocks.", this.OldCidrBlocks);
        }
    }
}

