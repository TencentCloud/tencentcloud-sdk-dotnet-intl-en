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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeComputeEnvCreateInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Compute environment ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// Compute environment name
        /// </summary>
        [JsonProperty("EnvName")]
        public string EnvName{ get; set; }

        /// <summary>
        /// Compute environment description
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EnvDescription")]
        public string EnvDescription{ get; set; }

        /// <summary>
        /// Compute environment type. Only `MANAGED` is supported
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// Compute environment parameter
        /// </summary>
        [JsonProperty("EnvData")]
        public EnvData EnvData{ get; set; }

        /// <summary>
        /// Data disk mounting option
        /// </summary>
        [JsonProperty("MountDataDisks")]
        public MountDataDisk[] MountDataDisks{ get; set; }

        /// <summary>
        /// Input mapping
        /// </summary>
        [JsonProperty("InputMappings")]
        public InputMapping[] InputMappings{ get; set; }

        /// <summary>
        /// Authorization information
        /// </summary>
        [JsonProperty("Authentications")]
        public Authentication[] Authentications{ get; set; }

        /// <summary>
        /// Notification information
        /// </summary>
        [JsonProperty("Notifications")]
        public Notification[] Notifications{ get; set; }

        /// <summary>
        /// Number of desired compute nodes
        /// </summary>
        [JsonProperty("DesiredComputeNodeCount")]
        public long? DesiredComputeNodeCount{ get; set; }

        /// <summary>
        /// Tag list bound to the compute environment.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "EnvName", this.EnvName);
            this.SetParamSimple(map, prefix + "EnvDescription", this.EnvDescription);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamObj(map, prefix + "EnvData.", this.EnvData);
            this.SetParamArrayObj(map, prefix + "MountDataDisks.", this.MountDataDisks);
            this.SetParamArrayObj(map, prefix + "InputMappings.", this.InputMappings);
            this.SetParamArrayObj(map, prefix + "Authentications.", this.Authentications);
            this.SetParamArrayObj(map, prefix + "Notifications.", this.Notifications);
            this.SetParamSimple(map, prefix + "DesiredComputeNodeCount", this.DesiredComputeNodeCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

