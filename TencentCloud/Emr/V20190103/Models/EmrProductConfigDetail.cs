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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmrProductConfigDetail : AbstractModel
    {
        
        /// <summary>
        /// Software information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SoftInfo")]
        public string[] SoftInfo{ get; set; }

        /// <summary>
        /// Number of Master nodes.
        /// </summary>
        [JsonProperty("MasterNodeSize")]
        public long? MasterNodeSize{ get; set; }

        /// <summary>
        /// Number of Core nodes.
        /// </summary>
        [JsonProperty("CoreNodeSize")]
        public long? CoreNodeSize{ get; set; }

        /// <summary>
        /// Number of Task nodes.
        /// </summary>
        [JsonProperty("TaskNodeSize")]
        public long? TaskNodeSize{ get; set; }

        /// <summary>
        /// Number of Common nodes.
        /// </summary>
        [JsonProperty("ComNodeSize")]
        public long? ComNodeSize{ get; set; }

        /// <summary>
        /// Primary node resources
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MasterResource")]
        public ResourceDetail MasterResource{ get; set; }

        /// <summary>
        /// Core node resources
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoreResource")]
        public ResourceDetail CoreResource{ get; set; }

        /// <summary>
        /// Task node resources
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskResource")]
        public ResourceDetail TaskResource{ get; set; }

        /// <summary>
        /// Common node resources
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComResource")]
        public ResourceDetail ComResource{ get; set; }

        /// <summary>
        /// Whether to use COS.
        /// </summary>
        [JsonProperty("OnCos")]
        public bool? OnCos{ get; set; }

        /// <summary>
        /// Charge type.
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// Number of Router nodes.
        /// </summary>
        [JsonProperty("RouterNodeSize")]
        public long? RouterNodeSize{ get; set; }

        /// <summary>
        /// Whether HA is supported.
        /// </summary>
        [JsonProperty("SupportHA")]
        public bool? SupportHA{ get; set; }

        /// <summary>
        /// Whether security mode is supported.
        /// </summary>
        [JsonProperty("SecurityOn")]
        public bool? SecurityOn{ get; set; }

        /// <summary>
        /// Security group name.
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string SecurityGroup{ get; set; }

        /// <summary>
        /// Whether to enable CBS encryption.
        /// </summary>
        [JsonProperty("CbsEncrypt")]
        public long? CbsEncrypt{ get; set; }

        /// <summary>
        /// Custom application role.
        /// </summary>
        [JsonProperty("ApplicationRole")]
        public string ApplicationRole{ get; set; }

        /// <summary>
        /// Security group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// SSH key ID.
        /// </summary>
        [JsonProperty("PublicKeyId")]
        public string PublicKeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SoftInfo.", this.SoftInfo);
            this.SetParamSimple(map, prefix + "MasterNodeSize", this.MasterNodeSize);
            this.SetParamSimple(map, prefix + "CoreNodeSize", this.CoreNodeSize);
            this.SetParamSimple(map, prefix + "TaskNodeSize", this.TaskNodeSize);
            this.SetParamSimple(map, prefix + "ComNodeSize", this.ComNodeSize);
            this.SetParamObj(map, prefix + "MasterResource.", this.MasterResource);
            this.SetParamObj(map, prefix + "CoreResource.", this.CoreResource);
            this.SetParamObj(map, prefix + "TaskResource.", this.TaskResource);
            this.SetParamObj(map, prefix + "ComResource.", this.ComResource);
            this.SetParamSimple(map, prefix + "OnCos", this.OnCos);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "RouterNodeSize", this.RouterNodeSize);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamSimple(map, prefix + "SecurityOn", this.SecurityOn);
            this.SetParamSimple(map, prefix + "SecurityGroup", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "CbsEncrypt", this.CbsEncrypt);
            this.SetParamSimple(map, prefix + "ApplicationRole", this.ApplicationRole);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "PublicKeyId", this.PublicKeyId);
        }
    }
}

