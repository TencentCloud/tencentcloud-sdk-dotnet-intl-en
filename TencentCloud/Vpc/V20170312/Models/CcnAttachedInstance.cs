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

    public class CcnAttachedInstance : AbstractModel
    {
        
        /// <summary>
        /// The ID of a CCN instance.
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// The type of associated instances:
        /// <li>`VPC`: VPC</li>
        /// <li>`DIRECTCONNECT`: Direct Connect</li>
        /// <li>`BMVPC`: BM VPC</li>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// The ID of the associated instance.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The name of the associated instance.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// The region to which the associated instance belongs, such as `ap-guangzhou`.
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string InstanceRegion{ get; set; }

        /// <summary>
        /// The UIN (root account) to which the associated instance belongs.
        /// </summary>
        [JsonProperty("InstanceUin")]
        public string InstanceUin{ get; set; }

        /// <summary>
        /// The CIDR of the associated instance.
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string[] CidrBlock{ get; set; }

        /// <summary>
        /// The status of the associated instance:
        /// <li>`PENDING`: In application</li>
        /// <li>`ACTIVE`: Connected</li>
        /// <li>`EXPIRED`: Expired</li>
        /// <li>`REJECTED`: Rejected</li>
        /// <li>`DELETED`: Deleted</li>
        /// <li>`FAILED`: Failed (it will be asynchronously unbound after 2 hours)</li>
        /// <li>`ATTACHING`: binding</li>
        /// <li>`DETACHING`: Unbinding</li>
        /// <li>`DETACHFAILED`: The unbinding failed (it will be asynchronously unbound after 2 hours)</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Association Time.
        /// </summary>
        [JsonProperty("AttachedTime")]
        public string AttachedTime{ get; set; }

        /// <summary>
        /// The UIN (root account) to which the CCN belongs.
        /// </summary>
        [JsonProperty("CcnUin")]
        public string CcnUin{ get; set; }

        /// <summary>
        /// General location of the associated instance, such as CHINA_MAINLAND.
        /// </summary>
        [JsonProperty("InstanceArea")]
        public string InstanceArea{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceRegion", this.InstanceRegion);
            this.SetParamSimple(map, prefix + "InstanceUin", this.InstanceUin);
            this.SetParamArraySimple(map, prefix + "CidrBlock.", this.CidrBlock);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AttachedTime", this.AttachedTime);
            this.SetParamSimple(map, prefix + "CcnUin", this.CcnUin);
            this.SetParamSimple(map, prefix + "InstanceArea", this.InstanceArea);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

