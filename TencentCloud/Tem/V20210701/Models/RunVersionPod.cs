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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunVersionPod : AbstractModel
    {
        
        /// <summary>
        /// Shell address
        /// </summary>
        [JsonProperty("Webshell")]
        public string Webshell{ get; set; }

        /// <summary>
        /// Pod ID
        /// </summary>
        [JsonProperty("PodId")]
        public string PodId{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Pod IP
        /// </summary>
        [JsonProperty("PodIp")]
        public string PodIp{ get; set; }

        /// <summary>
        /// Availability zone
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Deployed version
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// Number of restarts
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RestartCount")]
        public long? RestartCount{ get; set; }

        /// <summary>
        /// Whether the pod is ready
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ready")]
        public bool? Ready{ get; set; }

        /// <summary>
        /// Container status
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerState")]
        public string ContainerState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Webshell", this.Webshell);
            this.SetParamSimple(map, prefix + "PodId", this.PodId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PodIp", this.PodIp);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DeployVersion", this.DeployVersion);
            this.SetParamSimple(map, prefix + "RestartCount", this.RestartCount);
            this.SetParamSimple(map, prefix + "Ready", this.Ready);
            this.SetParamSimple(map, prefix + "ContainerState", this.ContainerState);
        }
    }
}

