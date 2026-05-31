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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterInstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Instance name</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Engine type</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Instance status</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>Instance status description</p>
        /// </summary>
        [JsonProperty("InstanceStatusDesc")]
        public string InstanceStatusDesc{ get; set; }

        /// <summary>
        /// <p>cpu cores</p>
        /// </summary>
        [JsonProperty("InstanceCpu")]
        public long? InstanceCpu{ get; set; }

        /// <summary>
        /// <p>Memory</p>
        /// </summary>
        [JsonProperty("InstanceMemory")]
        public long? InstanceMemory{ get; set; }

        /// <summary>
        /// <p>hard disk</p>
        /// </summary>
        [JsonProperty("InstanceStorage")]
        public long? InstanceStorage{ get; set; }

        /// <summary>
        /// <p>Instance role</p>
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// <p>Execution start time (seconds from 00:00).</p>
        /// </summary>
        [JsonProperty("MaintainStartTime")]
        public long? MaintainStartTime{ get; set; }

        /// <summary>
        /// <p>Duration (unit: s)</p>
        /// </summary>
        [JsonProperty("MaintainDuration")]
        public long? MaintainDuration{ get; set; }

        /// <summary>
        /// <p>The time when it can be executed, enumeration value: ["Mon","Tue","Wed","Thu","Fri", "Sat", "Sun"]</p>
        /// </summary>
        [JsonProperty("MaintainWeekDays")]
        public string[] MaintainWeekDays{ get; set; }

        /// <summary>
        /// <p>serverless instance substatus</p>
        /// </summary>
        [JsonProperty("ServerlessStatus")]
        public string ServerlessStatus{ get; set; }

        /// <summary>
        /// <p>Instance task information</p>
        /// </summary>
        [JsonProperty("InstanceTasks")]
        public ObjectTask[] InstanceTasks{ get; set; }

        /// <summary>
        /// <p>Instance Machine Type</p><ol><li>common, universal type.</li><li>exclusive, dedicated.</li></ol>
        /// </summary>
        [JsonProperty("InstanceDeviceType")]
        public string InstanceDeviceType{ get; set; }

        /// <summary>
        /// <p>Instance storage type<br>Description: This parameter returns a value only when the resource belonging to the query is LibraDB.</p>
        /// </summary>
        [JsonProperty("InstanceStorageType")]
        public string InstanceStorageType{ get; set; }

        /// <summary>
        /// <p>Database type</p>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// <p>Node list<br>Description: This parameter returns a value only when querying resources belonging to LibraDB.</p>
        /// </summary>
        [JsonProperty("NodeList")]
        public string[] NodeList{ get; set; }

        /// <summary>
        /// <p>AI optimizer status</p>
        /// </summary>
        [JsonProperty("AIOptimizerStatus")]
        public AIOptimizerStatus AIOptimizerStatus{ get; set; }


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
            this.SetParamObj(map, prefix + "AIOptimizerStatus.", this.AIOptimizerStatus);
        }
    }
}

