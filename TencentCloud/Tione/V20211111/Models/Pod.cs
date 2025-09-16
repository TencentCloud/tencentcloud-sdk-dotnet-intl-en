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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Pod : AbstractModel
    {
        
        /// <summary>
        /// Pod name.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Unique ID of the Pod.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// Service payment mode.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// Pod status.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Phase")]
        public string Phase{ get; set; }

        /// <summary>
        /// Pod IP address.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// Pod creation time.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Container list.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Containers")]
        [System.Obsolete]
        public Container Containers{ get; set; }

        /// <summary>
        /// Container list.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerInfos")]
        public Container[] ContainerInfos{ get; set; }

        /// <summary>
        /// Container calling information.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CrossTenantENIInfo")]
        public CrossTenantENIInfo CrossTenantENIInfo{ get; set; }

        /// <summary>
        /// Instance status information.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Instance scheduling start time.
        /// </summary>
        [JsonProperty("StartScheduleTime")]
        public string StartScheduleTime{ get; set; }

        /// <summary>
        /// Supplemental instance status information.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Node IP address of the current instance.
        /// </summary>
        [JsonProperty("NodeIP")]
        public string NodeIP{ get; set; }

        /// <summary>
        /// Node ID of the current instance.
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// Resource group ID to which the instance belonged.
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// Resource group name.
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// Resource usage information of the instance.
        /// </summary>
        [JsonProperty("ResourceInfo")]
        public ResourceInfo ResourceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "Phase", this.Phase);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "Containers.", this.Containers);
            this.SetParamArrayObj(map, prefix + "ContainerInfos.", this.ContainerInfos);
            this.SetParamObj(map, prefix + "CrossTenantENIInfo.", this.CrossTenantENIInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartScheduleTime", this.StartScheduleTime);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "NodeIP", this.NodeIP);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamObj(map, prefix + "ResourceInfo.", this.ResourceInfo);
        }
    }
}

