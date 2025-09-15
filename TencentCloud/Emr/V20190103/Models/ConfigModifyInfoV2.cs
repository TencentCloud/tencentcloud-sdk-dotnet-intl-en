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

    public class ConfigModifyInfoV2 : AbstractModel
    {
        
        /// <summary>
        /// Operation type. Valid values:
        /// 
        /// - 0: create a queue.
        /// - 1: edit - full overwrite.
        /// - 2: create a sub-queue.
        /// - 3: delete.
        /// - 4: clone. It is the same as sub-queue creation. Especially, for `fair`, a sub-queue can be copied to a new queue.
        /// - 6: edit - incremental update.
        /// </summary>
        [JsonProperty("OpType")]
        public ulong? OpType{ get; set; }

        /// <summary>
        /// Queue name. It cannot be modified.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Create root queue: Pass "myId of root"; Create sub-queue: Pass "myId of the selected queue"; Clone queue: Pass "parentId of the selected queue".
        /// </summary>
        [JsonProperty("ParentId")]
        public string ParentId{ get; set; }

        /// <summary>
        /// Edit or delete operations: Require passing "myId of the selected queue". Passing is required for cloning only when the scheduler is `fair` in order to copy a sub-queue to a new queue.
        /// </summary>
        [JsonProperty("MyId")]
        public string MyId{ get; set; }

        /// <summary>
        /// Basic configuration. The value of key is consistent with the field returned by **DescribeYarnQueue**.###### Fair scheduler
        /// Values of key are as follows:
        /// 
        /// - type: parent queue. Value: **parent** or **null**.
        /// - aclSubmitApps: submission ACL. Value: **JSON string of the AclForYarnQueue type** or **null**.
        /// - aclAdministerApps: administration ACL. Value: **JSON string of the AclForYarnQueue type** or **null**.
        /// - minSharePreemptionTimeout: timeout of minimum share before preemption. Value: **numeric string** or **null**.
        /// - fairSharePreemptionTimeout: timeout of fair share before preemption. Value: **numeric string** or **null**.
        /// - fairSharePreemptionThreshold: fair share preemption threshold. Value: **numeric string** or **null**. Numeric string range: (0,1].
        /// - allowPreemptionFrom: preemption mode. Value: **Boolean string** or **null**.
        /// - schedulingPolicy: scheduling policy. Value: **drf**, **fair**, **fifo**, or **null**.
        /// 
        /// ```
        /// type AclForYarnQueue struct {
        /// 	User  *string `json:"user"` // Username
        /// 	Group *string `json:"group"`// Group name
        /// }
        /// ```
        /// ###### Capacity scheduler
        /// Values of key are as follows:
        /// 
        /// - state: queue status. Value: **STOPPED** or **RUNNING**.
        /// - default-node-label-expression: default tag expression. Value: **tag** or **null**.
        /// - acl_submit_applications: submission ACL. Value: **JSON string of the AclForYarnQueue type** or **null**.
        /// - acl_administer_queue: administration ACL. Value: **JSON string of the AclForYarnQueue type** or **null**.
        /// - maximum-allocation-mb: maximum memory allocated to each container. Value: **numeric string** or **null**.
        /// - maximum-allocation-vcores: maximum number of virtual cores allocated to each container. Value: **numeric string** or **null**.
        /// ```
        /// type AclForYarnQueue struct {
        /// 	User  *string `json:"user"` // Username
        /// 	Group *string `json:"group"`// Group name
        /// }
        /// ```
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BasicParams")]
        public ItemSeq BasicParams{ get; set; }

        /// <summary>
        /// Configuration set information. For the values, see the parameter description of ConfigSetInfo. Configuration set is the representation of the plan mode in the queue, containing different configuration item values for different time periods. The configuration set names of all queues are the same. For a single queue, the tags and parameters in each configuration set are the same, but the parameter values are different.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConfigSetParams")]
        public ConfigSetInfo[] ConfigSetParams{ get; set; }

        /// <summary>
        /// This parameter is specific for capacity scheduling and is valid only when `OpType` is set to `6`. It indicates tags to be deleted from the queue. This parameter has a higher priority than LabelParams in ConfigSetParams.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeleteLables")]
        public string[] DeleteLables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpType", this.OpType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "MyId", this.MyId);
            this.SetParamObj(map, prefix + "BasicParams.", this.BasicParams);
            this.SetParamArrayObj(map, prefix + "ConfigSetParams.", this.ConfigSetParams);
            this.SetParamArraySimple(map, prefix + "DeleteLables.", this.DeleteLables);
        }
    }
}

