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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterInstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Engine type
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance status
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Instance status description
        /// </summary>
        [JsonProperty("InstanceStatusDesc")]
        public string InstanceStatusDesc{ get; set; }

        /// <summary>
        /// Number of CPU cores
        /// </summary>
        [JsonProperty("InstanceCpu")]
        public long? InstanceCpu{ get; set; }

        /// <summary>
        /// Memory
        /// </summary>
        [JsonProperty("InstanceMemory")]
        public long? InstanceMemory{ get; set; }

        /// <summary>
        /// Disk
        /// </summary>
        [JsonProperty("InstanceStorage")]
        public long? InstanceStorage{ get; set; }

        /// <summary>
        /// Instance role
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// Execution start time (seconds from 0 o'clock).	
        /// </summary>
        [JsonProperty("MaintainStartTime")]
        public long? MaintainStartTime{ get; set; }

        /// <summary>
        /// Specifies the continuous time. the unit is second.	
        /// </summary>
        [JsonProperty("MaintainDuration")]
        public long? MaintainDuration{ get; set; }

        /// <summary>
        /// Specifies the time when it can be executed. valid values: ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"].
        /// </summary>
        [JsonProperty("MaintainWeekDays")]
        public string[] MaintainWeekDays{ get; set; }

        /// <summary>
        /// serverless instance substatus.
        /// </summary>
        [JsonProperty("ServerlessStatus")]
        public string ServerlessStatus{ get; set; }

        /// <summary>
        /// Instance task information.
        /// </summary>
        [JsonProperty("InstanceTasks")]
        public ObjectTask[] InstanceTasks{ get; set; }

        /// <summary>
        /// Instance machine type.
        /// </summary>
        [JsonProperty("InstanceDeviceType")]
        public string InstanceDeviceType{ get; set; }

        /// <summary>
        /// Instance storage type.
        /// </summary>
        [JsonProperty("InstanceStorageType")]
        public string InstanceStorageType{ get; set; }

        /// <summary>
        /// Database type.
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// Node list
        /// </summary>
        [JsonProperty("NodeList")]
        public string[] NodeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "InstanceStatusDesc", this.InstanceStatusDesc);
            this.SetParamSimple(map, prefix + "InstanceCpu", this.InstanceCpu);
            this.SetParamSimple(map, prefix + "InstanceMemory", this.InstanceMemory);
            this.SetParamSimple(map, prefix + "InstanceStorage", this.InstanceStorage);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "MaintainStartTime", this.MaintainStartTime);
            this.SetParamSimple(map, prefix + "MaintainDuration", this.MaintainDuration);
            this.SetParamArraySimple(map, prefix + "MaintainWeekDays.", this.MaintainWeekDays);
            this.SetParamSimple(map, prefix + "ServerlessStatus", this.ServerlessStatus);
            this.SetParamArrayObj(map, prefix + "InstanceTasks.", this.InstanceTasks);
            this.SetParamSimple(map, prefix + "InstanceDeviceType", this.InstanceDeviceType);
            this.SetParamSimple(map, prefix + "InstanceStorageType", this.InstanceStorageType);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamArraySimple(map, prefix + "NodeList.", this.NodeList);
        }
    }
}

