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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostItem : AbstractModel
    {
        
        /// <summary>
        /// Location of the CDH instance. You can use this parameter to specify the attributes of the instance, such as its availability zone and project.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// CDH instance ID
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// CDH instance type
        /// </summary>
        [JsonProperty("HostType")]
        public string HostType{ get; set; }

        /// <summary>
        /// CDH instance name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Billing method of the CDH instance
        /// </summary>
        [JsonProperty("HostChargeType")]
        public string HostChargeType{ get; set; }

        /// <summary>
        /// Auto renewal flag of the CDH instance
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Creation time of the CDH instance
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Expiration time of the CDH instance
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// List of IDs of CVM instances created on the CDH
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// CDH instance state
        /// </summary>
        [JsonProperty("HostState")]
        public string HostState{ get; set; }

        /// <summary>
        /// CDH instance IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Resource information of the CDH instance
        /// </summary>
        [JsonProperty("HostResource")]
        public HostResource HostResource{ get; set; }

        /// <summary>
        /// Cage ID of the CDH instance. This parameter is only valid for CDH instances in the cages of finance availability zones.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostChargeType", this.HostChargeType);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "HostState", this.HostState);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamObj(map, prefix + "HostResource.", this.HostResource);
            this.SetParamSimple(map, prefix + "CageId", this.CageId);
        }
    }
}

