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
        /// 0: Create a queue.
        /// 1: Edit - fully overwrite a queue.
        /// 2: Create a subqueue.
        /// 3: Delete a queue.
        /// 4: Clone a queue. This is the same as creating a subqueue. Specifically, for `fair`, a subqueue can be copied to a new queue.
        /// 6: Edit - incrementally update a queue.
        /// </summary>
        [JsonProperty("OpType")]
        public ulong? OpType{ get; set; }

        /// <summary>
        /// Queue name. It cannot be modified.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Create the root queue: pass "myId of root". Create a subqueue: pass "myId of the selected queue". Clone a queue: pass "parentId of the selected queue".
        /// </summary>
        [JsonProperty("ParentId")]
        public string ParentId{ get; set; }

        /// <summary>
        /// Edit or delete operations: pass "myId of the selected queue". Passing is required for cloning only when the scheduler is `fair` in order to copy a subqueue to a new queue.
        /// </summary>
        [JsonProperty("MyId")]
        public string MyId{ get; set; }

        /// <summary>
        /// Basic configuration information. The value of key is consistent with the field returned by **DescribeYarnQueue**.
        /// ###### Fair scheduler.
        /// The key value information is as follows:
        /// 
        /// - type: parent queue. The value is **parent** or **null**.
        /// - aclSubmitApps: submit access control. The value is a **JSON string of the AclForYarnQueue type** or **null**.
        /// - aclAdministerApps: administer access control. The value is a **JSON string of the AclForYarnQueue type** or **null**.
        /// - minSharePreemptionTimeout: minimum share preemption timeout. The value is a **numeric string** or **null**.
        /// - fairSharePreemptionTimeout: fair share preemption timeout. The value is a **numeric string** or **null**.
        /// - fairSharePreemptionThreshold: fair share preemption threshold. The value is a **numeric string** or **null**, where the numeric range is (0, 1].
        /// - allowPreemptionFrom: preemption mode. The value is a **boolean string** or **null**.
        /// - schedulingPolicy: scheduling policy. The value is **drf**, **fair**, **fifo**, or **null**.
        /// 
        /// ```
        /// type AclForYarnQueue struct {
        /// 	User  *string `json:"user"` // Username
        /// 	Group *string `json:"group"`// Group name
        /// }
        /// ```
        /// ###### Capacity scheduler.
        /// The key value information is as follows:
        /// 
        /// - state: queue status. The value is **STOPPED** or **RUNNING**.
        /// - default-node-label-expression: default label expression. The value is a **label** or **null**.
        /// - acl_submit_applications: submit access control. The value is a **JSON string of the AclForYarnQueue type** or **null**.
        /// - acl_administer_queue: administer access control. The value is a **JSON string of the AclForYarnQueue type** or **null**.
        /// - maximum-allocation-mb: maximum memory allocated to a container. The value is a **numeric string** or **null**.
        /// - maximum-allocation-vcores: maximum number of vCores allocated to a container. The value is a **numeric string** or **null**.
        /// ```
        /// type AclForYarnQueue struct {
        /// 	User  *string `json:"user"` // Username
        /// 	Group *string `json:"group"`// Group name
        /// }
        /// ```
        /// </summary>
        [JsonProperty("BasicParams")]
        public ItemSeq BasicParams{ get; set; }

        /// <summary>
        /// Configuration set information. For the value, see the parameter description of this complex type. A configuration set is the representation of the plan mode in a queue, indicating different configuration values in different time periods. All queues have the same configuration set name. For a single queue, the labels and parameters in each configuration set are the same, but the parameter values differ.
        /// </summary>
        [JsonProperty("ConfigSetParams")]
        public ConfigSetInfo[] ConfigSetParams{ get; set; }

        /// <summary>
        /// Specific to the capacity scheduler. It takes effect only when `OpType` is `6` and indicates which labels in this queue are to be deleted. Its priority is higher than that of LabelParams in ConfigSetParams.
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

