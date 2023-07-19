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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// Task ID 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// Task start time 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task type. Valid values:  - `FLOW_CREATE`: Create an instance. - `FLOW_MODIFYCONNECTIONCONFIG`: Adjust the number of bandwidth connections. - `FLOW_MODIFYINSTANCEPASSWORDFREE`: Modify the process of password-free access. - `FLOW_CLEARNETWORK`: Returning VPC - `FLOW_SETPWD`: Set the access password. - `FLOW_EXPORSHR`: Expand or reduce the capacity. - `FLOW_UpgradeArch`: Upgrade the instance architecture. - `FLOW_MODIFYINSTANCEPARAMS`: Modify the instance parameters. - `FLOW_MODIFYINSTACEREADONLY`: Modify read-only process. - `FLOW_CLOSE`: Disable the instance. - `FLOW_DELETE`: Delete the instance. - `FLOW_OPEN_WAN`: Enable the public network. - `FLOW_FLOW_CLEAN`: Clear the instance. - `FLOW_MODIFYINSTANCEACCOUNT`: Modify the instance account. - `FLOW_ENABLEINSTANCE_REPLICATE`: Enable the replica read-only feature. - `FLOW_DISABLEINSTANCE_REPLICATE`: Disable the replica read-only feature. - `FLOW_SWITCHINSTANCEVIP`: Swap the VIPs of instances. - FLOW_CHANGE_REPLICA_TO_MSTER: Promote the replica node to the mater node. Backup instance 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Instance name 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance ID 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Project ID 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Task progress 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// Task end time 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Task execution status. Valid values: - `0` (initilized) - `1` (executing) - `2` (completed) - `4` (failed) 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Result", this.Result);
        }
    }
}

